namespace Taxi_Meter
{
    partial class mainframe
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
            this.GroupBox_Info = new System.Windows.Forms.GroupBox();
            this.ComboBox_Code = new System.Windows.Forms.ComboBox();
            this.Button_Submit = new System.Windows.Forms.Button();
            this.TextBox_Destination = new System.Windows.Forms.TextBox();
            this.Label_Destination = new System.Windows.Forms.Label();
            this.TextBox_StartPt = new System.Windows.Forms.TextBox();
            this.TextBox_PhoneNo = new System.Windows.Forms.TextBox();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.Label_StartPt = new System.Windows.Forms.Label();
            this.Label_PhoneNo = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Button_Pause = new System.Windows.Forms.Button();
            this.Button_Stop = new System.Windows.Forms.Button();
            this.TextBox_Log = new System.Windows.Forms.TextBox();
            this.GroupBox_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Info
            // 
            this.GroupBox_Info.AccessibleName = "";
            this.GroupBox_Info.Controls.Add(this.ComboBox_Code);
            this.GroupBox_Info.Controls.Add(this.Button_Submit);
            this.GroupBox_Info.Controls.Add(this.TextBox_Destination);
            this.GroupBox_Info.Controls.Add(this.Label_Destination);
            this.GroupBox_Info.Controls.Add(this.TextBox_StartPt);
            this.GroupBox_Info.Controls.Add(this.TextBox_PhoneNo);
            this.GroupBox_Info.Controls.Add(this.TextBox_Name);
            this.GroupBox_Info.Controls.Add(this.Label_StartPt);
            this.GroupBox_Info.Controls.Add(this.Label_PhoneNo);
            this.GroupBox_Info.Controls.Add(this.Label_Name);
            this.GroupBox_Info.Location = new System.Drawing.Point(13, 12);
            this.GroupBox_Info.Name = "GroupBox_Info";
            this.GroupBox_Info.Size = new System.Drawing.Size(260, 118);
            this.GroupBox_Info.TabIndex = 9;
            this.GroupBox_Info.TabStop = false;
            this.GroupBox_Info.Text = "Customer Info";
            // 
            // ComboBox_Code
            // 
            this.ComboBox_Code.FormattingEnabled = true;
            this.ComboBox_Code.Items.AddRange(new object[] {
            "+1",
            "+86"});
            this.ComboBox_Code.Location = new System.Drawing.Point(80, 44);
            this.ComboBox_Code.Name = "ComboBox_Code";
            this.ComboBox_Code.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboBox_Code.Size = new System.Drawing.Size(42, 20);
            this.ComboBox_Code.TabIndex = 2;
            // 
            // Button_Submit
            // 
            this.Button_Submit.BackgroundImage = global::Taxi_Meter.Properties.Resources.submit;
            this.Button_Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Submit.Location = new System.Drawing.Point(225, 85);
            this.Button_Submit.Name = "Button_Submit";
            this.Button_Submit.Size = new System.Drawing.Size(30, 30);
            this.Button_Submit.TabIndex = 5;
            this.Button_Submit.UseVisualStyleBackColor = true;
            this.Button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // TextBox_Destination
            // 
            this.TextBox_Destination.Location = new System.Drawing.Point(123, 90);
            this.TextBox_Destination.Name = "TextBox_Destination";
            this.TextBox_Destination.Size = new System.Drawing.Size(100, 21);
            this.TextBox_Destination.TabIndex = 4;
            // 
            // Label_Destination
            // 
            this.Label_Destination.AutoSize = true;
            this.Label_Destination.Location = new System.Drawing.Point(12, 93);
            this.Label_Destination.Name = "Label_Destination";
            this.Label_Destination.Size = new System.Drawing.Size(71, 12);
            this.Label_Destination.TabIndex = 13;
            this.Label_Destination.Text = "Destination";
            // 
            // TextBox_StartPt
            // 
            this.TextBox_StartPt.Location = new System.Drawing.Point(123, 67);
            this.TextBox_StartPt.Name = "TextBox_StartPt";
            this.TextBox_StartPt.Size = new System.Drawing.Size(100, 21);
            this.TextBox_StartPt.TabIndex = 3;
            // 
            // TextBox_PhoneNo
            // 
            this.TextBox_PhoneNo.Location = new System.Drawing.Point(123, 44);
            this.TextBox_PhoneNo.Name = "TextBox_PhoneNo";
            this.TextBox_PhoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBox_PhoneNo.Size = new System.Drawing.Size(100, 21);
            this.TextBox_PhoneNo.TabIndex = 1;
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(123, 21);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(100, 21);
            this.TextBox_Name.TabIndex = 0;
            // 
            // Label_StartPt
            // 
            this.Label_StartPt.AutoSize = true;
            this.Label_StartPt.Location = new System.Drawing.Point(12, 70);
            this.Label_StartPt.Name = "Label_StartPt";
            this.Label_StartPt.Size = new System.Drawing.Size(89, 12);
            this.Label_StartPt.TabIndex = 12;
            this.Label_StartPt.Text = "Starting Point";
            // 
            // Label_PhoneNo
            // 
            this.Label_PhoneNo.AutoSize = true;
            this.Label_PhoneNo.Location = new System.Drawing.Point(12, 47);
            this.Label_PhoneNo.Name = "Label_PhoneNo";
            this.Label_PhoneNo.Size = new System.Drawing.Size(41, 12);
            this.Label_PhoneNo.TabIndex = 11;
            this.Label_PhoneNo.Text = "Phone#";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(12, 24);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(29, 12);
            this.Label_Name.TabIndex = 10;
            this.Label_Name.Text = "Name";
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(14, 149);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(75, 23);
            this.Button_Start.TabIndex = 6;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Button_Pause
            // 
            this.Button_Pause.Location = new System.Drawing.Point(105, 149);
            this.Button_Pause.Name = "Button_Pause";
            this.Button_Pause.Size = new System.Drawing.Size(75, 23);
            this.Button_Pause.TabIndex = 7;
            this.Button_Pause.Text = "Pause";
            this.Button_Pause.UseVisualStyleBackColor = true;
            this.Button_Pause.Click += new System.EventHandler(this.Button_Pause_Click);
            // 
            // Button_Stop
            // 
            this.Button_Stop.Location = new System.Drawing.Point(196, 149);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(75, 23);
            this.Button_Stop.TabIndex = 8;
            this.Button_Stop.Text = "Stop";
            this.Button_Stop.UseVisualStyleBackColor = true;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // TextBox_Log
            // 
            this.TextBox_Log.Location = new System.Drawing.Point(0, 179);
            this.TextBox_Log.Multiline = true;
            this.TextBox_Log.Name = "TextBox_Log";
            this.TextBox_Log.ReadOnly = true;
            this.TextBox_Log.Size = new System.Drawing.Size(284, 328);
            this.TextBox_Log.TabIndex = 14;
            this.TextBox_Log.TextChanged += new System.EventHandler(this.TextBox_Log_TextChanged);
            // 
            // mainframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 507);
            this.Controls.Add(this.TextBox_Log);
            this.Controls.Add(this.Button_Stop);
            this.Controls.Add(this.Button_Pause);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.GroupBox_Info);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "mainframe";
            this.ShowIcon = false;
            this.Text = "Taxi Meter";
            this.GroupBox_Info.ResumeLayout(false);
            this.GroupBox_Info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Info;
        private System.Windows.Forms.Label Label_PhoneNo;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_StartPt;
        private System.Windows.Forms.TextBox TextBox_StartPt;
        private System.Windows.Forms.TextBox TextBox_PhoneNo;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.TextBox TextBox_Destination;
        private System.Windows.Forms.Label Label_Destination;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button Button_Pause;
        private System.Windows.Forms.Button Button_Stop;
        private System.Windows.Forms.TextBox TextBox_Log;
        private System.Windows.Forms.Button Button_Submit;
        private System.Windows.Forms.ComboBox ComboBox_Code;
    }
}