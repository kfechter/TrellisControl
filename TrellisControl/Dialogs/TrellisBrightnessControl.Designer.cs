
namespace TrellisControl.Dialogs
{
    partial class TrellisBrightnessControl
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
            this.neotrellisBrightnessControl = new System.Windows.Forms.TrackBar();
            this.brightnessValueLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.neotrellisBrightnessControl)).BeginInit();
            this.SuspendLayout();
            // 
            // neotrellisBrightnessControl
            // 
            this.neotrellisBrightnessControl.Location = new System.Drawing.Point(12, 12);
            this.neotrellisBrightnessControl.Maximum = 255;
            this.neotrellisBrightnessControl.Name = "neotrellisBrightnessControl";
            this.neotrellisBrightnessControl.Size = new System.Drawing.Size(761, 69);
            this.neotrellisBrightnessControl.TabIndex = 0;
            this.neotrellisBrightnessControl.TickFrequency = 10;
            this.neotrellisBrightnessControl.ValueChanged += new System.EventHandler(this.neotrellisBrightnessControl_ValueChanged);
            // 
            // brightnessValueLabel
            // 
            this.brightnessValueLabel.AutoSize = true;
            this.brightnessValueLabel.Location = new System.Drawing.Point(12, 84);
            this.brightnessValueLabel.Name = "brightnessValueLabel";
            this.brightnessValueLabel.Size = new System.Drawing.Size(113, 25);
            this.brightnessValueLabel.TabIndex = 1;
            this.brightnessValueLabel.Text = "Brightness: 0";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(696, 109);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(112, 34);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(578, 109);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 34);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // TrellisBrightnessControl
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(820, 163);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.brightnessValueLabel);
            this.Controls.Add(this.neotrellisBrightnessControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TrellisBrightnessControl";
            this.Text = "Brightness";
            ((System.ComponentModel.ISupportInitialize)(this.neotrellisBrightnessControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar neotrellisBrightnessControl;
        private System.Windows.Forms.Label brightnessValueLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}