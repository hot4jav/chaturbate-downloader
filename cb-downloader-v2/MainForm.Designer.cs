﻿namespace cb_downloader_v2
{
    partial class MainForm
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
            this.modelsBox = new System.Windows.Forms.CheckedListBox();
            this.modelsBoxCtxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelsGroupBox = new System.Windows.Forms.GroupBox();
            this.modelNameTextBox = new System.Windows.Forms.TextBox();
            this.addModelButton = new System.Windows.Forms.Button();
            this.modelsBoxCtxMenu.SuspendLayout();
            this.modelsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelsBox
            // 
            this.modelsBox.ContextMenuStrip = this.modelsBoxCtxMenu;
            this.modelsBox.FormattingEnabled = true;
            this.modelsBox.Location = new System.Drawing.Point(6, 19);
            this.modelsBox.Name = "modelsBox";
            this.modelsBox.Size = new System.Drawing.Size(387, 259);
            this.modelsBox.Sorted = true;
            this.modelsBox.TabIndex = 0;
            // 
            // modelsBoxCtxMenu
            // 
            this.modelsBoxCtxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeMenuItem});
            this.modelsBoxCtxMenu.Name = "modelsBoxCtxMenu";
            this.modelsBoxCtxMenu.ShowImageMargin = false;
            this.modelsBoxCtxMenu.Size = new System.Drawing.Size(93, 26);
            // 
            // removeMenuItem
            // 
            this.removeMenuItem.Name = "removeMenuItem";
            this.removeMenuItem.Size = new System.Drawing.Size(92, 22);
            this.removeMenuItem.Text = "Remove";
            this.removeMenuItem.Click += new System.EventHandler(this.removeMenuItem_Click);
            // 
            // modelsGroupBox
            // 
            this.modelsGroupBox.Controls.Add(this.modelsBox);
            this.modelsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.modelsGroupBox.Name = "modelsGroupBox";
            this.modelsGroupBox.Size = new System.Drawing.Size(399, 292);
            this.modelsGroupBox.TabIndex = 1;
            this.modelsGroupBox.TabStop = false;
            this.modelsGroupBox.Text = "Models";
            // 
            // modelNameTextBox
            // 
            this.modelNameTextBox.Location = new System.Drawing.Point(12, 310);
            this.modelNameTextBox.Name = "modelNameTextBox";
            this.modelNameTextBox.Size = new System.Drawing.Size(318, 20);
            this.modelNameTextBox.TabIndex = 2;
            this.modelNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modelNameTextBox_KeyDown);
            this.modelNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.modelNameTextBox_KeyUp);
            // 
            // addModelButton
            // 
            this.addModelButton.Location = new System.Drawing.Point(336, 310);
            this.addModelButton.Name = "addModelButton";
            this.addModelButton.Size = new System.Drawing.Size(75, 23);
            this.addModelButton.TabIndex = 2;
            this.addModelButton.Text = "Add";
            this.addModelButton.UseVisualStyleBackColor = true;
            this.addModelButton.Click += new System.EventHandler(this.addModelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 344);
            this.Controls.Add(this.modelNameTextBox);
            this.Controls.Add(this.addModelButton);
            this.Controls.Add(this.modelsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "cb-downloader-2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.modelsBoxCtxMenu.ResumeLayout(false);
            this.modelsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox modelsBox;
        private System.Windows.Forms.GroupBox modelsGroupBox;
        private System.Windows.Forms.TextBox modelNameTextBox;
        private System.Windows.Forms.Button addModelButton;
        private System.Windows.Forms.ContextMenuStrip modelsBoxCtxMenu;
        private System.Windows.Forms.ToolStripMenuItem removeMenuItem;
    }
}
