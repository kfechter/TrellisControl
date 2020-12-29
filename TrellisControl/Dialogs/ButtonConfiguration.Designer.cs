﻿
namespace TrellisControl.Dialogs
{
    partial class ButtonConfiguration
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
            this.label1 = new System.Windows.Forms.Label();
            this.trellisButtonColor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.trellisButtonAction = new System.Windows.Forms.ComboBox();
            this.executablePathLabel = new System.Windows.Forms.Label();
            this.executablePath = new System.Windows.Forms.TextBox();
            this.executableBrowseButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Button Color:";
            // 
            // trellisButtonColor
            // 
            this.trellisButtonColor.Location = new System.Drawing.Point(114, 9);
            this.trellisButtonColor.Name = "trellisButtonColor";
            this.trellisButtonColor.Size = new System.Drawing.Size(50, 50);
            this.trellisButtonColor.TabIndex = 1;
            this.trellisButtonColor.Click += new System.EventHandler(this.trellisButtonColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Button Action:";
            // 
            // trellisButtonAction
            // 
            this.trellisButtonAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trellisButtonAction.FormattingEnabled = true;
            this.trellisButtonAction.Items.AddRange(new object[] {
            "None",
            "Executable"});
            this.trellisButtonAction.Location = new System.Drawing.Point(121, 103);
            this.trellisButtonAction.Name = "trellisButtonAction";
            this.trellisButtonAction.Size = new System.Drawing.Size(151, 28);
            this.trellisButtonAction.TabIndex = 3;
            this.trellisButtonAction.SelectionChangeCommitted += new System.EventHandler(this.trellisButtonAction_SelectionChangeCommitted);
            // 
            // executablePathLabel
            // 
            this.executablePathLabel.AutoSize = true;
            this.executablePathLabel.Location = new System.Drawing.Point(13, 192);
            this.executablePathLabel.Name = "executablePathLabel";
            this.executablePathLabel.Size = new System.Drawing.Size(116, 20);
            this.executablePathLabel.TabIndex = 4;
            this.executablePathLabel.Text = "Executable Path:";
            // 
            // executablePath
            // 
            this.executablePath.Location = new System.Drawing.Point(135, 189);
            this.executablePath.Name = "executablePath";
            this.executablePath.ReadOnly = true;
            this.executablePath.Size = new System.Drawing.Size(321, 27);
            this.executablePath.TabIndex = 5;
            // 
            // executableBrowseButton
            // 
            this.executableBrowseButton.Location = new System.Drawing.Point(462, 189);
            this.executableBrowseButton.Name = "executableBrowseButton";
            this.executableBrowseButton.Size = new System.Drawing.Size(94, 29);
            this.executableBrowseButton.TabIndex = 6;
            this.executableBrowseButton.Text = "Browse";
            this.executableBrowseButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(485, 230);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(94, 29);
            this.acceptButton.TabIndex = 7;
            this.acceptButton.Text = "OK";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(385, 230);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ButtonConfiguration
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(591, 271);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.executableBrowseButton);
            this.Controls.Add(this.executablePath);
            this.Controls.Add(this.executablePathLabel);
            this.Controls.Add(this.trellisButtonAction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trellisButtonColor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ButtonConfiguration";
            this.Text = "Button Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel trellisButtonColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox trellisButtonAction;
        private System.Windows.Forms.Label executablePathLabel;
        private System.Windows.Forms.TextBox executablePath;
        private System.Windows.Forms.Button executableBrowseButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
    }
}