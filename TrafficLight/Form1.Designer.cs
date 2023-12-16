namespace TrafficLight
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            RedLight = new PictureBox();
            YellowLight = new PictureBox();
            GreenLight = new PictureBox();
            buttonstart = new Button();
            buttonstop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)RedLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YellowLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreenLight).BeginInit();
            SuspendLayout();
            // 
            // RedLight
            // 
            RedLight.Image = (Image)resources.GetObject("RedLight.Image");
            RedLight.Location = new Point(110, 29);
            RedLight.Name = "RedLight";
            RedLight.Size = new Size(266, 336);
            RedLight.SizeMode = PictureBoxSizeMode.StretchImage;
            RedLight.TabIndex = 0;
            RedLight.TabStop = false;
            // 
            // YellowLight
            // 
            YellowLight.Image = (Image)resources.GetObject("YellowLight.Image");
            YellowLight.Location = new Point(110, 12);
            YellowLight.Name = "YellowLight";
            YellowLight.Size = new Size(266, 370);
            YellowLight.SizeMode = PictureBoxSizeMode.StretchImage;
            YellowLight.TabIndex = 1;
            YellowLight.TabStop = false;
            // 
            // GreenLight
            // 
            GreenLight.BackColor = Color.White;
            GreenLight.Image = (Image)resources.GetObject("GreenLight.Image");
            GreenLight.Location = new Point(110, -4);
            GreenLight.Name = "GreenLight";
            GreenLight.Size = new Size(266, 402);
            GreenLight.SizeMode = PictureBoxSizeMode.StretchImage;
            GreenLight.TabIndex = 2;
            GreenLight.TabStop = false;
            // 
            // buttonstart
            // 
            buttonstart.BackColor = Color.White;
            buttonstart.Location = new Point(496, 90);
            buttonstart.Name = "buttonstart";
            buttonstart.Size = new Size(166, 51);
            buttonstart.TabIndex = 3;
            buttonstart.Text = "Start";
            buttonstart.UseVisualStyleBackColor = false;
            buttonstart.Click += buttonstart_Click;
            // 
            // buttonstop
            // 
            buttonstop.BackColor = Color.White;
            buttonstop.Location = new Point(496, 197);
            buttonstop.Name = "buttonstop";
            buttonstop.Size = new Size(166, 49);
            buttonstop.TabIndex = 4;
            buttonstop.Text = "Stop";
            buttonstop.UseVisualStyleBackColor = false;
            buttonstop.Click += buttonstop_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(buttonstop);
            Controls.Add(buttonstart);
            Controls.Add(GreenLight);
            Controls.Add(YellowLight);
            Controls.Add(RedLight);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)RedLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)YellowLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreenLight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox RedLight;
        private PictureBox YellowLight;
        private PictureBox GreenLight;
        private Button buttonstart;
        private Button buttonstop;
        private System.Windows.Forms.Timer timer1;
    }
}