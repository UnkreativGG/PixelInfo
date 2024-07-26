namespace PixelInfo
{
    partial class PixelInfoWindow
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
            components = new System.ComponentModel.Container();
            Position_Lablel = new Label();
            Color_Label = new Label();
            Update_Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Position_Lablel
            // 
            Position_Lablel.AutoSize = true;
            Position_Lablel.ForeColor = SystemColors.ControlDarkDark;
            Position_Lablel.Location = new Point(10, 10);
            Position_Lablel.Margin = new Padding(1);
            Position_Lablel.Name = "Position_Lablel";
            Position_Lablel.Size = new Size(58, 15);
            Position_Lablel.TabIndex = 0;
            Position_Lablel.Text = "X:{0} Y:{1}";
            // 
            // Color_Label
            // 
            Color_Label.AutoSize = true;
            Color_Label.ForeColor = SystemColors.ControlDarkDark;
            Color_Label.Location = new Point(10, 29);
            Color_Label.Margin = new Padding(3);
            Color_Label.Name = "Color_Label";
            Color_Label.Size = new Size(83, 15);
            Color_Label.TabIndex = 1;
            Color_Label.Text = "RGB: {0} {1} {2}";
            // 
            // Update_Timer
            // 
            Update_Timer.Enabled = true;
            Update_Timer.Interval = 25;
            Update_Timer.Tick += Update_Timer_Tick;
            // 
            // PixelInfoWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(150, 55);
            Controls.Add(Color_Label);
            Controls.Add(Position_Lablel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PixelInfoWindow";
            Text = "PixelInfo";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Position_Lablel;
        private Label Color_Label;
        private System.Windows.Forms.Timer Update_Timer;
    }
}