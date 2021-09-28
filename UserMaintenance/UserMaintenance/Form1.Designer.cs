
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textFullName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.buttonAddName = new System.Windows.Forms.Button();
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
            this.labelFullName.Location = new System.Drawing.Point(193, 12);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(46, 17);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "label1";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(193, 51);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(46, 17);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "label2";
            // 
            // textFullName
            // 
            this.textFullName.Location = new System.Drawing.Point(245, 12);
            this.textFullName.Name = "textFullName";
            this.textFullName.Size = new System.Drawing.Size(140, 22);
            this.textFullName.TabIndex = 3;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(245, 51);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(140, 22);
            this.textFirstName.TabIndex = 4;
            // 
            // buttonAddName
            // 
            this.buttonAddName.Location = new System.Drawing.Point(196, 88);
            this.buttonAddName.Name = "buttonAddName";
            this.buttonAddName.Size = new System.Drawing.Size(189, 28);
            this.buttonAddName.TabIndex = 5;
            this.buttonAddName.Text = "button1";
            this.buttonAddName.UseVisualStyleBackColor = true;
            this.buttonAddName.Click += new System.EventHandler(this.buttonAddName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 252);
            this.Controls.Add(this.buttonAddName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textFullName);
            this.Controls.Add(this.labelFirstName);
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
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textFullName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Button buttonAddName;
    }
}

