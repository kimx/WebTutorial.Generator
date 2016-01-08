using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebTutorial.Generator.Models;

namespace WebTutorial.Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            SettingModel model = new SettingModel();
            model.ControllerName = txtControllerName.Text.Trim();
            model.ProgramName = txtProgramName.Text.Trim();
            model.Descript = txtDescript.Text.Trim();
            WriteFile("MvcController", "Controllers", model.ControllerName + "Controller.cs", model);
            WriteFile("MvcView", "Views\\" + model.ControllerName, "Index.cshtml", model);
            WriteFile("MvcModel", "Models", model.ControllerName + "IndexModel.cs", model);
            WriteFile("AngularApp", "Views\\" + model.ControllerName, "App.ts", model);
            WriteFile("AngularController", "Views\\" + model.ControllerName, "IndexController.ts", model);
            WriteFile("AngularModel", "Views\\App\\Model", model.ControllerName + "IndexModel.ts", model);
            WriteFile("TutorialMenu", "", "asset.cshtml", model);
            Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tutorial"));
        }

        private void WriteFile(string templateName, string folder, string fileName, SettingModel model)
        {
            Type type = this.FindType(templateName);
            if (type == null)//沒有此類別
                return;
            string areaPath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, "Tutorial");

            dynamic template = Activator.CreateInstance(type);
            template.Session = new Dictionary<string, object>();
            template.Session.Add("Setting", model);

            template.Initialize();
            string result = template.TransformText();

            string path = string.Format(@"{0}\{1}", areaPath, folder);
            string file = string.Format(@"{0}\{1}", path, fileName);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            File.WriteAllText(file, result,Encoding.UTF8);
        }

        static string typeNameGeneratorTemplate = "WebTutorial.Generator.Templates.{0}";
        private Type FindType(string templateName)
        {

            string typeName = string.Format(typeNameGeneratorTemplate, templateName);
            Type type = Type.GetType(typeName, false);
            return type;
        }
    }
}
