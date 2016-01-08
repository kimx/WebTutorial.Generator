namespace WebTutorial.Generator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtControllerName = new System.Windows.Forms.TextBox();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.txtDescript = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(119, 123);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ControllerName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Program Name:";
            // 
            // txtControllerName
            // 
            this.txtControllerName.Location = new System.Drawing.Point(119, 23);
            this.txtControllerName.Name = "txtControllerName";
            this.txtControllerName.Size = new System.Drawing.Size(235, 22);
            this.txtControllerName.TabIndex = 3;
            this.txtControllerName.Text = "Angular";
            // 
            // txtProgramName
            // 
            this.txtProgramName.Location = new System.Drawing.Point(119, 60);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(235, 22);
            this.txtProgramName.TabIndex = 4;
            this.txtProgramName.Text = "Sample Program";
            // 
            // txtDescript
            // 
            this.txtDescript.Location = new System.Drawing.Point(119, 95);
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Size = new System.Drawing.Size(235, 22);
            this.txtDescript.TabIndex = 6;
            this.txtDescript.Text = "Sample Descript";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descript:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 373);
            this.Controls.Add(this.txtDescript);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProgramName);
            this.Controls.Add(this.txtControllerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tutorial Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtControllerName;
        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.TextBox txtDescript;
        private System.Windows.Forms.Label label3;
    }
}

