
namespace UserMaintenance
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
            this.listUserNames = new System.Windows.Forms.ListBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.textFullName = new System.Windows.Forms.TextBox();
            this.buttonAddName = new System.Windows.Forms.Button();
            this.buttonWriteToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUserNames
            // 
            this.listUserNames.FormattingEnabled = true;
            this.listUserNames.ItemHeight = 16;
            this.listUserNames.Location = new System.Drawing.Point(12, 12);
            this.listUserNames.Name = "listUserNames";
            this.listUserNames.Size = new System.Drawing.Size(170, 228);
            this.listUserNames.TabIndex = 0;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(190, 20);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(46, 17);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "label1";
            // 
            // textFullName
            // 
            this.textFullName.Location = new System.Drawing.Point(287, 17);
            this.textFullName.Name = "textFullName";
            this.textFullName.Size = new System.Drawing.Size(140, 22);
            this.textFullName.TabIndex = 3;
            // 
            // buttonAddName
            // 
            this.buttonAddName.Location = new System.Drawing.Point(193, 59);
            this.buttonAddName.Name = "buttonAddName";
            this.buttonAddName.Size = new System.Drawing.Size(234, 28);
            this.buttonAddName.TabIndex = 5;
            this.buttonAddName.Text = "button1";
            this.buttonAddName.UseVisualStyleBackColor = true;
            this.buttonAddName.Click += new System.EventHandler(this.buttonAddName_Click);
            // 
            // buttonWriteToFile
            // 
            this.buttonWriteToFile.Location = new System.Drawing.Point(193, 105);
            this.buttonWriteToFile.Name = "buttonWriteToFile";
            this.buttonWriteToFile.Size = new System.Drawing.Size(234, 28);
            this.buttonWriteToFile.TabIndex = 6;
            this.buttonWriteToFile.Text = "button1";
            this.buttonWriteToFile.UseVisualStyleBackColor = true;
            this.buttonWriteToFile.Click += new System.EventHandler(this.buttonWriteToFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 252);
            this.Controls.Add(this.buttonWriteToFile);
            this.Controls.Add(this.buttonAddName);
            this.Controls.Add(this.textFullName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.listUserNames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUserNames;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox textFullName;
        private System.Windows.Forms.Button buttonAddName;
        private System.Windows.Forms.Button buttonWriteToFile;
    }
}

