
namespace week08
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.ballButton = new System.Windows.Forms.Button();
            this.carButton = new System.Windows.Forms.Button();
            this.nextLabel = new System.Windows.Forms.Label();
            this.ballColorButton = new System.Windows.Forms.Button();
            this.presentButton = new System.Windows.Forms.Button();
            this.boxButton = new System.Windows.Forms.Button();
            this.ribbonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 272);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1180, 169);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 1500;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // ballButton
            // 
            this.ballButton.Location = new System.Drawing.Point(12, 12);
            this.ballButton.Name = "ballButton";
            this.ballButton.Size = new System.Drawing.Size(116, 49);
            this.ballButton.TabIndex = 1;
            this.ballButton.Text = "BALL";
            this.ballButton.UseVisualStyleBackColor = true;
            this.ballButton.Click += new System.EventHandler(this.ballButton_Click);
            // 
            // carButton
            // 
            this.carButton.Location = new System.Drawing.Point(145, 12);
            this.carButton.Name = "carButton";
            this.carButton.Size = new System.Drawing.Size(116, 49);
            this.carButton.TabIndex = 2;
            this.carButton.Text = "CAR";
            this.carButton.UseVisualStyleBackColor = true;
            this.carButton.Click += new System.EventHandler(this.carButton_Click);
            // 
            // nextLabel
            // 
            this.nextLabel.AutoSize = true;
            this.nextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nextLabel.Location = new System.Drawing.Point(415, 12);
            this.nextLabel.Name = "nextLabel";
            this.nextLabel.Size = new System.Drawing.Size(107, 20);
            this.nextLabel.TabIndex = 3;
            this.nextLabel.Text = "Coming next:";
            // 
            // ballColorButton
            // 
            this.ballColorButton.BackColor = System.Drawing.Color.Purple;
            this.ballColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ballColorButton.Location = new System.Drawing.Point(12, 67);
            this.ballColorButton.Name = "ballColorButton";
            this.ballColorButton.Size = new System.Drawing.Size(116, 49);
            this.ballColorButton.TabIndex = 4;
            this.ballColorButton.UseVisualStyleBackColor = false;
            this.ballColorButton.Click += new System.EventHandler(this.ballColorButton_Click);
            // 
            // presentButton
            // 
            this.presentButton.Location = new System.Drawing.Point(281, 12);
            this.presentButton.Name = "presentButton";
            this.presentButton.Size = new System.Drawing.Size(116, 49);
            this.presentButton.TabIndex = 5;
            this.presentButton.Text = "PRESENT";
            this.presentButton.UseVisualStyleBackColor = true;
            this.presentButton.Click += new System.EventHandler(this.presentButton_Click);
            // 
            // boxButton
            // 
            this.boxButton.BackColor = System.Drawing.Color.DarkGreen;
            this.boxButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.boxButton.Location = new System.Drawing.Point(281, 122);
            this.boxButton.Name = "boxButton";
            this.boxButton.Size = new System.Drawing.Size(116, 49);
            this.boxButton.TabIndex = 6;
            this.boxButton.UseVisualStyleBackColor = false;
            this.boxButton.Click += new System.EventHandler(this.ballColorButton_Click);
            // 
            // ribbonButton
            // 
            this.ribbonButton.BackColor = System.Drawing.Color.Red;
            this.ribbonButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ribbonButton.Location = new System.Drawing.Point(281, 67);
            this.ribbonButton.Name = "ribbonButton";
            this.ribbonButton.Size = new System.Drawing.Size(116, 49);
            this.ribbonButton.TabIndex = 7;
            this.ribbonButton.UseVisualStyleBackColor = false;
            this.ribbonButton.Click += new System.EventHandler(this.ballColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 526);
            this.Controls.Add(this.ribbonButton);
            this.Controls.Add(this.boxButton);
            this.Controls.Add(this.presentButton);
            this.Controls.Add(this.ballColorButton);
            this.Controls.Add(this.nextLabel);
            this.Controls.Add(this.carButton);
            this.Controls.Add(this.ballButton);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button ballButton;
        private System.Windows.Forms.Button carButton;
        private System.Windows.Forms.Label nextLabel;
        private System.Windows.Forms.Button ballColorButton;
        private System.Windows.Forms.Button presentButton;
        private System.Windows.Forms.Button boxButton;
        private System.Windows.Forms.Button ribbonButton;
    }
}

