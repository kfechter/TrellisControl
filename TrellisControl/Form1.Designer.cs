
namespace TrellisControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trellisComStatus = new System.Windows.Forms.StatusStrip();
            this.trellisSerialStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.trellisComLabel = new System.Windows.Forms.ToolStripLabel();
            this.trellisComSelection = new System.Windows.Forms.ToolStripComboBox();
            this.trellisConnectSerial = new System.Windows.Forms.ToolStripSplitButton();
            this.trellisAutoConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.trellisSetAllColors = new System.Windows.Forms.ToolStripButton();
            this.setNeoTrellisBrightness = new System.Windows.Forms.ToolStripButton();
            this.trellisButton1 = new System.Windows.Forms.Button();
            this.trellisButton2 = new System.Windows.Forms.Button();
            this.trellisButton3 = new System.Windows.Forms.Button();
            this.trellisButton4 = new System.Windows.Forms.Button();
            this.trellisButton5 = new System.Windows.Forms.Button();
            this.trellisButton6 = new System.Windows.Forms.Button();
            this.trellisButton8 = new System.Windows.Forms.Button();
            this.trellisButton7 = new System.Windows.Forms.Button();
            this.trellisButton15 = new System.Windows.Forms.Button();
            this.trellisButton16 = new System.Windows.Forms.Button();
            this.trellisButton14 = new System.Windows.Forms.Button();
            this.trellisButton13 = new System.Windows.Forms.Button();
            this.trellisButton12 = new System.Windows.Forms.Button();
            this.trellisButton11 = new System.Windows.Forms.Button();
            this.trellisButton10 = new System.Windows.Forms.Button();
            this.trellisButton9 = new System.Windows.Forms.Button();
            this.trellisButton23 = new System.Windows.Forms.Button();
            this.trellisButton24 = new System.Windows.Forms.Button();
            this.trellisButton22 = new System.Windows.Forms.Button();
            this.trellisButton21 = new System.Windows.Forms.Button();
            this.trellisButton20 = new System.Windows.Forms.Button();
            this.trellisButton19 = new System.Windows.Forms.Button();
            this.trellisButton18 = new System.Windows.Forms.Button();
            this.trellisButton17 = new System.Windows.Forms.Button();
            this.trellisButton31 = new System.Windows.Forms.Button();
            this.trellisButton32 = new System.Windows.Forms.Button();
            this.trellisButton30 = new System.Windows.Forms.Button();
            this.trellisButton29 = new System.Windows.Forms.Button();
            this.trellisButton28 = new System.Windows.Forms.Button();
            this.trellisButton27 = new System.Windows.Forms.Button();
            this.trellisButton26 = new System.Windows.Forms.Button();
            this.trellisButton25 = new System.Windows.Forms.Button();
            this.trellisComStatus.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trellisComStatus
            // 
            this.trellisComStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trellisComStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trellisSerialStatusLabel});
            this.trellisComStatus.Location = new System.Drawing.Point(0, 330);
            this.trellisComStatus.Name = "trellisComStatus";
            this.trellisComStatus.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.trellisComStatus.Size = new System.Drawing.Size(584, 22);
            this.trellisComStatus.TabIndex = 0;
            this.trellisComStatus.Text = "trellisStatusStrip";
            // 
            // trellisSerialStatusLabel
            // 
            this.trellisSerialStatusLabel.Name = "trellisSerialStatusLabel";
            this.trellisSerialStatusLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trellisComLabel,
            this.trellisComSelection,
            this.trellisConnectSerial,
            this.trellisSetAllColors,
            this.setNeoTrellisBrightness});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "trellisToolStrip";
            // 
            // trellisComLabel
            // 
            this.trellisComLabel.Name = "trellisComLabel";
            this.trellisComLabel.Size = new System.Drawing.Size(94, 29);
            this.trellisComLabel.Text = "COM Port:";
            // 
            // trellisComSelection
            // 
            this.trellisComSelection.Name = "trellisComSelection";
            this.trellisComSelection.Size = new System.Drawing.Size(150, 34);
            // 
            // trellisConnectSerial
            // 
            this.trellisConnectSerial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.trellisConnectSerial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trellisAutoConnect});
            this.trellisConnectSerial.Image = ((System.Drawing.Image)(resources.GetObject("trellisConnectSerial.Image")));
            this.trellisConnectSerial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.trellisConnectSerial.Name = "trellisConnectSerial";
            this.trellisConnectSerial.Size = new System.Drawing.Size(98, 29);
            this.trellisConnectSerial.Text = "Connect";
            // 
            // trellisAutoConnect
            // 
            this.trellisAutoConnect.CheckOnClick = true;
            this.trellisAutoConnect.Name = "trellisAutoConnect";
            this.trellisAutoConnect.Size = new System.Drawing.Size(223, 34);
            this.trellisAutoConnect.Text = "Auto Connect";
            // 
            // trellisSetAllColors
            // 
            this.trellisSetAllColors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.trellisSetAllColors.Image = ((System.Drawing.Image)(resources.GetObject("trellisSetAllColors.Image")));
            this.trellisSetAllColors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.trellisSetAllColors.Name = "trellisSetAllColors";
            this.trellisSetAllColors.Size = new System.Drawing.Size(92, 29);
            this.trellisSetAllColors.Text = "All Colors";
            // 
            // setNeoTrellisBrightness
            // 
            this.setNeoTrellisBrightness.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.setNeoTrellisBrightness.Image = ((System.Drawing.Image)(resources.GetObject("setNeoTrellisBrightness.Image")));
            this.setNeoTrellisBrightness.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setNeoTrellisBrightness.Name = "setNeoTrellisBrightness";
            this.setNeoTrellisBrightness.Size = new System.Drawing.Size(128, 29);
            this.setNeoTrellisBrightness.Text = "Set Brightness";
            // 
            // trellisButton1
            // 
            this.trellisButton1.Location = new System.Drawing.Point(15, 39);
            this.trellisButton1.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton1.Name = "trellisButton1";
            this.trellisButton1.Size = new System.Drawing.Size(62, 62);
            this.trellisButton1.TabIndex = 2;
            this.trellisButton1.Tag = "Button1";
            this.trellisButton1.UseVisualStyleBackColor = true;
            this.trellisButton1.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton2
            // 
            this.trellisButton2.Location = new System.Drawing.Point(85, 39);
            this.trellisButton2.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton2.Name = "trellisButton2";
            this.trellisButton2.Size = new System.Drawing.Size(62, 62);
            this.trellisButton2.TabIndex = 3;
            this.trellisButton2.Tag = "Button2";
            this.trellisButton2.UseVisualStyleBackColor = true;
            this.trellisButton2.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton3
            // 
            this.trellisButton3.Location = new System.Drawing.Point(155, 39);
            this.trellisButton3.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton3.Name = "trellisButton3";
            this.trellisButton3.Size = new System.Drawing.Size(62, 62);
            this.trellisButton3.TabIndex = 4;
            this.trellisButton3.Tag = "Button3";
            this.trellisButton3.UseVisualStyleBackColor = true;
            this.trellisButton3.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton4
            // 
            this.trellisButton4.Location = new System.Drawing.Point(225, 39);
            this.trellisButton4.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton4.Name = "trellisButton4";
            this.trellisButton4.Size = new System.Drawing.Size(62, 62);
            this.trellisButton4.TabIndex = 5;
            this.trellisButton4.Tag = "Button4";
            this.trellisButton4.UseVisualStyleBackColor = true;
            this.trellisButton4.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton5
            // 
            this.trellisButton5.Location = new System.Drawing.Point(295, 39);
            this.trellisButton5.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton5.Name = "trellisButton5";
            this.trellisButton5.Size = new System.Drawing.Size(62, 62);
            this.trellisButton5.TabIndex = 6;
            this.trellisButton5.Tag = "Button5";
            this.trellisButton5.UseVisualStyleBackColor = true;
            this.trellisButton5.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton6
            // 
            this.trellisButton6.Location = new System.Drawing.Point(365, 39);
            this.trellisButton6.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton6.Name = "trellisButton6";
            this.trellisButton6.Size = new System.Drawing.Size(62, 62);
            this.trellisButton6.TabIndex = 7;
            this.trellisButton6.Tag = "Button6";
            this.trellisButton6.UseVisualStyleBackColor = true;
            this.trellisButton6.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton8
            // 
            this.trellisButton8.Location = new System.Drawing.Point(505, 39);
            this.trellisButton8.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton8.Name = "trellisButton8";
            this.trellisButton8.Size = new System.Drawing.Size(62, 62);
            this.trellisButton8.TabIndex = 8;
            this.trellisButton8.Tag = "Button8";
            this.trellisButton8.UseVisualStyleBackColor = true;
            this.trellisButton8.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton7
            // 
            this.trellisButton7.Location = new System.Drawing.Point(435, 39);
            this.trellisButton7.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton7.Name = "trellisButton7";
            this.trellisButton7.Size = new System.Drawing.Size(62, 62);
            this.trellisButton7.TabIndex = 9;
            this.trellisButton7.Tag = "Button7";
            this.trellisButton7.UseVisualStyleBackColor = true;
            this.trellisButton7.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton15
            // 
            this.trellisButton15.Location = new System.Drawing.Point(435, 109);
            this.trellisButton15.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton15.Name = "trellisButton15";
            this.trellisButton15.Size = new System.Drawing.Size(62, 62);
            this.trellisButton15.TabIndex = 17;
            this.trellisButton15.Tag = "Button15";
            this.trellisButton15.UseVisualStyleBackColor = true;
            this.trellisButton15.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton16
            // 
            this.trellisButton16.Location = new System.Drawing.Point(505, 109);
            this.trellisButton16.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton16.Name = "trellisButton16";
            this.trellisButton16.Size = new System.Drawing.Size(62, 62);
            this.trellisButton16.TabIndex = 16;
            this.trellisButton16.Tag = "Button16";
            this.trellisButton16.UseVisualStyleBackColor = true;
            this.trellisButton16.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton14
            // 
            this.trellisButton14.Location = new System.Drawing.Point(365, 109);
            this.trellisButton14.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton14.Name = "trellisButton14";
            this.trellisButton14.Size = new System.Drawing.Size(62, 62);
            this.trellisButton14.TabIndex = 15;
            this.trellisButton14.Tag = "Button14";
            this.trellisButton14.UseVisualStyleBackColor = true;
            this.trellisButton14.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton13
            // 
            this.trellisButton13.Location = new System.Drawing.Point(295, 109);
            this.trellisButton13.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton13.Name = "trellisButton13";
            this.trellisButton13.Size = new System.Drawing.Size(62, 62);
            this.trellisButton13.TabIndex = 14;
            this.trellisButton13.Tag = "Button13";
            this.trellisButton13.UseVisualStyleBackColor = true;
            this.trellisButton13.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton12
            // 
            this.trellisButton12.Location = new System.Drawing.Point(225, 109);
            this.trellisButton12.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton12.Name = "trellisButton12";
            this.trellisButton12.Size = new System.Drawing.Size(62, 62);
            this.trellisButton12.TabIndex = 13;
            this.trellisButton12.Tag = "Button12";
            this.trellisButton12.UseVisualStyleBackColor = true;
            this.trellisButton12.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton11
            // 
            this.trellisButton11.Location = new System.Drawing.Point(155, 109);
            this.trellisButton11.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton11.Name = "trellisButton11";
            this.trellisButton11.Size = new System.Drawing.Size(62, 62);
            this.trellisButton11.TabIndex = 12;
            this.trellisButton11.Tag = "Button11";
            this.trellisButton11.UseVisualStyleBackColor = true;
            this.trellisButton11.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton10
            // 
            this.trellisButton10.Location = new System.Drawing.Point(85, 109);
            this.trellisButton10.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton10.Name = "trellisButton10";
            this.trellisButton10.Size = new System.Drawing.Size(62, 62);
            this.trellisButton10.TabIndex = 11;
            this.trellisButton10.Tag = "Button10";
            this.trellisButton10.UseVisualStyleBackColor = true;
            this.trellisButton10.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton9
            // 
            this.trellisButton9.Location = new System.Drawing.Point(15, 109);
            this.trellisButton9.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton9.Name = "trellisButton9";
            this.trellisButton9.Size = new System.Drawing.Size(62, 62);
            this.trellisButton9.TabIndex = 10;
            this.trellisButton9.Tag = "Button9";
            this.trellisButton9.UseVisualStyleBackColor = true;
            this.trellisButton9.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton23
            // 
            this.trellisButton23.Location = new System.Drawing.Point(435, 179);
            this.trellisButton23.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton23.Name = "trellisButton23";
            this.trellisButton23.Size = new System.Drawing.Size(62, 62);
            this.trellisButton23.TabIndex = 25;
            this.trellisButton23.Tag = "Button23";
            this.trellisButton23.UseVisualStyleBackColor = true;
            this.trellisButton23.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton24
            // 
            this.trellisButton24.Location = new System.Drawing.Point(505, 179);
            this.trellisButton24.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton24.Name = "trellisButton24";
            this.trellisButton24.Size = new System.Drawing.Size(62, 62);
            this.trellisButton24.TabIndex = 24;
            this.trellisButton24.Tag = "Button24";
            this.trellisButton24.UseVisualStyleBackColor = true;
            this.trellisButton24.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton22
            // 
            this.trellisButton22.Location = new System.Drawing.Point(365, 179);
            this.trellisButton22.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton22.Name = "trellisButton22";
            this.trellisButton22.Size = new System.Drawing.Size(62, 62);
            this.trellisButton22.TabIndex = 23;
            this.trellisButton22.Tag = "Button22";
            this.trellisButton22.UseVisualStyleBackColor = true;
            this.trellisButton22.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton21
            // 
            this.trellisButton21.Location = new System.Drawing.Point(295, 179);
            this.trellisButton21.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton21.Name = "trellisButton21";
            this.trellisButton21.Size = new System.Drawing.Size(62, 62);
            this.trellisButton21.TabIndex = 22;
            this.trellisButton21.Tag = "Button21";
            this.trellisButton21.UseVisualStyleBackColor = true;
            this.trellisButton21.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton20
            // 
            this.trellisButton20.Location = new System.Drawing.Point(225, 179);
            this.trellisButton20.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton20.Name = "trellisButton20";
            this.trellisButton20.Size = new System.Drawing.Size(62, 62);
            this.trellisButton20.TabIndex = 21;
            this.trellisButton20.Tag = "Button20";
            this.trellisButton20.UseVisualStyleBackColor = true;
            this.trellisButton20.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton19
            // 
            this.trellisButton19.Location = new System.Drawing.Point(155, 179);
            this.trellisButton19.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton19.Name = "trellisButton19";
            this.trellisButton19.Size = new System.Drawing.Size(62, 62);
            this.trellisButton19.TabIndex = 20;
            this.trellisButton19.Tag = "Button19";
            this.trellisButton19.UseVisualStyleBackColor = true;
            this.trellisButton19.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton18
            // 
            this.trellisButton18.Location = new System.Drawing.Point(85, 179);
            this.trellisButton18.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton18.Name = "trellisButton18";
            this.trellisButton18.Size = new System.Drawing.Size(62, 62);
            this.trellisButton18.TabIndex = 19;
            this.trellisButton18.Tag = "Button18";
            this.trellisButton18.UseVisualStyleBackColor = true;
            this.trellisButton18.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton17
            // 
            this.trellisButton17.Location = new System.Drawing.Point(15, 179);
            this.trellisButton17.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton17.Name = "trellisButton17";
            this.trellisButton17.Size = new System.Drawing.Size(62, 62);
            this.trellisButton17.TabIndex = 18;
            this.trellisButton17.Tag = "Button17";
            this.trellisButton17.UseVisualStyleBackColor = true;
            this.trellisButton17.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton31
            // 
            this.trellisButton31.Location = new System.Drawing.Point(435, 249);
            this.trellisButton31.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton31.Name = "trellisButton31";
            this.trellisButton31.Size = new System.Drawing.Size(62, 62);
            this.trellisButton31.TabIndex = 33;
            this.trellisButton31.Tag = "Button31";
            this.trellisButton31.UseVisualStyleBackColor = true;
            this.trellisButton31.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton32
            // 
            this.trellisButton32.Location = new System.Drawing.Point(505, 249);
            this.trellisButton32.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton32.Name = "trellisButton32";
            this.trellisButton32.Size = new System.Drawing.Size(62, 62);
            this.trellisButton32.TabIndex = 32;
            this.trellisButton32.Tag = "Button32";
            this.trellisButton32.UseVisualStyleBackColor = true;
            this.trellisButton32.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton30
            // 
            this.trellisButton30.Location = new System.Drawing.Point(365, 249);
            this.trellisButton30.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton30.Name = "trellisButton30";
            this.trellisButton30.Size = new System.Drawing.Size(62, 62);
            this.trellisButton30.TabIndex = 31;
            this.trellisButton30.Tag = "Button30";
            this.trellisButton30.UseVisualStyleBackColor = true;
            this.trellisButton30.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton29
            // 
            this.trellisButton29.Location = new System.Drawing.Point(295, 249);
            this.trellisButton29.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton29.Name = "trellisButton29";
            this.trellisButton29.Size = new System.Drawing.Size(62, 62);
            this.trellisButton29.TabIndex = 30;
            this.trellisButton29.Tag = "Button29";
            this.trellisButton29.UseVisualStyleBackColor = true;
            this.trellisButton29.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton28
            // 
            this.trellisButton28.Location = new System.Drawing.Point(225, 249);
            this.trellisButton28.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton28.Name = "trellisButton28";
            this.trellisButton28.Size = new System.Drawing.Size(62, 62);
            this.trellisButton28.TabIndex = 29;
            this.trellisButton28.Tag = "Button28";
            this.trellisButton28.UseVisualStyleBackColor = true;
            this.trellisButton28.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton27
            // 
            this.trellisButton27.Location = new System.Drawing.Point(155, 249);
            this.trellisButton27.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton27.Name = "trellisButton27";
            this.trellisButton27.Size = new System.Drawing.Size(62, 62);
            this.trellisButton27.TabIndex = 28;
            this.trellisButton27.Tag = "Button27";
            this.trellisButton27.UseVisualStyleBackColor = true;
            this.trellisButton27.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton26
            // 
            this.trellisButton26.Location = new System.Drawing.Point(85, 249);
            this.trellisButton26.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton26.Name = "trellisButton26";
            this.trellisButton26.Size = new System.Drawing.Size(62, 62);
            this.trellisButton26.TabIndex = 27;
            this.trellisButton26.Tag = "Button26";
            this.trellisButton26.UseVisualStyleBackColor = true;
            this.trellisButton26.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // trellisButton25
            // 
            this.trellisButton25.Location = new System.Drawing.Point(15, 249);
            this.trellisButton25.Margin = new System.Windows.Forms.Padding(4);
            this.trellisButton25.Name = "trellisButton25";
            this.trellisButton25.Size = new System.Drawing.Size(62, 62);
            this.trellisButton25.TabIndex = 26;
            this.trellisButton25.Tag = "Button25";
            this.trellisButton25.UseVisualStyleBackColor = true;
            this.trellisButton25.Click += new System.EventHandler(this.TrellisButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 349);
            this.Controls.Add(this.trellisButton31);
            this.Controls.Add(this.trellisButton32);
            this.Controls.Add(this.trellisButton30);
            this.Controls.Add(this.trellisButton29);
            this.Controls.Add(this.trellisButton28);
            this.Controls.Add(this.trellisButton27);
            this.Controls.Add(this.trellisButton26);
            this.Controls.Add(this.trellisButton25);
            this.Controls.Add(this.trellisButton23);
            this.Controls.Add(this.trellisButton24);
            this.Controls.Add(this.trellisButton22);
            this.Controls.Add(this.trellisButton21);
            this.Controls.Add(this.trellisButton20);
            this.Controls.Add(this.trellisButton19);
            this.Controls.Add(this.trellisButton18);
            this.Controls.Add(this.trellisButton17);
            this.Controls.Add(this.trellisButton15);
            this.Controls.Add(this.trellisButton16);
            this.Controls.Add(this.trellisButton14);
            this.Controls.Add(this.trellisButton13);
            this.Controls.Add(this.trellisButton12);
            this.Controls.Add(this.trellisButton11);
            this.Controls.Add(this.trellisButton10);
            this.Controls.Add(this.trellisButton9);
            this.Controls.Add(this.trellisButton7);
            this.Controls.Add(this.trellisButton8);
            this.Controls.Add(this.trellisButton6);
            this.Controls.Add(this.trellisButton5);
            this.Controls.Add(this.trellisButton4);
            this.Controls.Add(this.trellisButton3);
            this.Controls.Add(this.trellisButton2);
            this.Controls.Add(this.trellisButton1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.trellisComStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TrellisControl";
            this.trellisComStatus.ResumeLayout(false);
            this.trellisComStatus.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip trellisComStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel trellisComLabel;
        private System.Windows.Forms.ToolStripComboBox trellisComSelection;
        private System.Windows.Forms.ToolStripSplitButton trellisConnectSerial;
        private System.Windows.Forms.ToolStripMenuItem trellisAutoConnect;
        private System.Windows.Forms.ToolStripStatusLabel trellisSerialStatusLabel;
        private System.Windows.Forms.Button trellisButton1;
        private System.Windows.Forms.Button trellisButton2;
        private System.Windows.Forms.Button trellisButton3;
        private System.Windows.Forms.Button trellisButton4;
        private System.Windows.Forms.Button trellisButton5;
        private System.Windows.Forms.Button trellisButton6;
        private System.Windows.Forms.Button trellisButton8;
        private System.Windows.Forms.Button trellisButton7;
        private System.Windows.Forms.Button trellisButton15;
        private System.Windows.Forms.Button trellisButton16;
        private System.Windows.Forms.Button trellisButton14;
        private System.Windows.Forms.Button trellisButton13;
        private System.Windows.Forms.Button trellisButton12;
        private System.Windows.Forms.Button trellisButton11;
        private System.Windows.Forms.Button trellisButton10;
        private System.Windows.Forms.Button trellisButton9;
        private System.Windows.Forms.Button trellisButton23;
        private System.Windows.Forms.Button trellisButton24;
        private System.Windows.Forms.Button trellisButton22;
        private System.Windows.Forms.Button trellisButton21;
        private System.Windows.Forms.Button trellisButton20;
        private System.Windows.Forms.Button trellisButton19;
        private System.Windows.Forms.Button trellisButton18;
        private System.Windows.Forms.Button trellisButton17;
        private System.Windows.Forms.Button trellisButton30;
        private System.Windows.Forms.Button trellisButton29;
        private System.Windows.Forms.Button trellisButton28;
        private System.Windows.Forms.Button trellisButton27;
        private System.Windows.Forms.Button trellisButton26;
        private System.Windows.Forms.Button trellisButton25;
        private System.Windows.Forms.ToolStripButton trellisSetAllColors;
        private System.Windows.Forms.Button trellisButton31;
        private System.Windows.Forms.Button trellisButton32;
        private System.Windows.Forms.ToolStripButton setNeoTrellisBrightness;
    }
}

