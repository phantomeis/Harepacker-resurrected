﻿namespace HaCreator.GUI
{
    partial class Initialization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Initialization));
            this.button1 = new System.Windows.Forms.Button();
            this.versionBox = new System.Windows.Forms.ComboBox();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pathBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.debugButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button1.Location = new System.Drawing.Point(18, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Initialize";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // versionBox
            // 
            this.versionBox.FormattingEnabled = true;
            this.versionBox.Items.AddRange(new object[] {
            "GMS",
            "EMS , MSEA , KMS",
            "BMS , JMS",
            "Auto-Detect"});
            this.versionBox.Location = new System.Drawing.Point(118, 58);
            this.versionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(300, 28);
            this.versionBox.TabIndex = 3;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 16);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Encryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "MS Path";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 152);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(400, 26);
            this.textBox2.TabIndex = 2;
            // 
            // pathBox
            // 
            this.pathBox.FormattingEnabled = true;
            this.pathBox.Location = new System.Drawing.Point(118, 18);
            this.pathBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(236, 28);
            this.pathBox.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button2.Location = new System.Drawing.Point(366, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // debugButton
            // 
            this.debugButton.Location = new System.Drawing.Point(275, 96);
            this.debugButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(159, 71);
            this.debugButton.TabIndex = 15;
            this.debugButton.Text = "DEBUG - check map errors";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Visible = false;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // Initialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 202);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.versionBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Initialization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HaCreator";
            this.Load += new System.EventHandler(this.Initialization_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Initialization_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox versionBox;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox pathBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button debugButton;
    }
}

