namespace Match_BPM {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TargetBPMTextBox = new System.Windows.Forms.TextBox();
            this.ResetTargetBPM = new System.Windows.Forms.Button();
            this.MeasureTargetBPM = new System.Windows.Forms.TextBox();
            this.MeasureImageBPM = new System.Windows.Forms.TextBox();
            this.ResetImageBPM = new System.Windows.Forms.Button();
            this.ImageBPMTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TargetDelay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ImageDelay = new System.Windows.Forms.TextBox();
            this.Ima = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TrueDelay = new System.Windows.Forms.TextBox();
            this.TrueSpeed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Prefix = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Interfix = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Suffix = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SelectLocation = new System.Windows.Forms.Button();
            this.BeginFrame = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.EndFrame = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.FPS = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.Frames = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Load = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target BPM: ";
            // 
            // TargetBPMTextBox
            // 
            this.TargetBPMTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TargetBPMTextBox.Location = new System.Drawing.Point(694, 9);
            this.TargetBPMTextBox.Name = "TargetBPMTextBox";
            this.TargetBPMTextBox.Size = new System.Drawing.Size(94, 20);
            this.TargetBPMTextBox.TabIndex = 2;
            this.TargetBPMTextBox.Text = "120";
            this.TargetBPMTextBox.TextChanged += new System.EventHandler(this.TargetBPMTextBox_TextChanged);
            // 
            // ResetTargetBPM
            // 
            this.ResetTargetBPM.Location = new System.Drawing.Point(621, 59);
            this.ResetTargetBPM.Name = "ResetTargetBPM";
            this.ResetTargetBPM.Size = new System.Drawing.Size(75, 23);
            this.ResetTargetBPM.TabIndex = 3;
            this.ResetTargetBPM.Text = "Reset";
            this.ResetTargetBPM.UseVisualStyleBackColor = true;
            // 
            // MeasureTargetBPM
            // 
            this.MeasureTargetBPM.Location = new System.Drawing.Point(703, 61);
            this.MeasureTargetBPM.Name = "MeasureTargetBPM";
            this.MeasureTargetBPM.Size = new System.Drawing.Size(85, 20);
            this.MeasureTargetBPM.TabIndex = 4;
            // 
            // MeasureImageBPM
            // 
            this.MeasureImageBPM.Location = new System.Drawing.Point(703, 396);
            this.MeasureImageBPM.Name = "MeasureImageBPM";
            this.MeasureImageBPM.Size = new System.Drawing.Size(85, 20);
            this.MeasureImageBPM.TabIndex = 8;
            // 
            // ResetImageBPM
            // 
            this.ResetImageBPM.Location = new System.Drawing.Point(621, 394);
            this.ResetImageBPM.Name = "ResetImageBPM";
            this.ResetImageBPM.Size = new System.Drawing.Size(75, 23);
            this.ResetImageBPM.TabIndex = 7;
            this.ResetImageBPM.Text = "Reset";
            this.ResetImageBPM.UseVisualStyleBackColor = true;
            // 
            // ImageBPMTextBox
            // 
            this.ImageBPMTextBox.Location = new System.Drawing.Point(694, 342);
            this.ImageBPMTextBox.Name = "ImageBPMTextBox";
            this.ImageBPMTextBox.Size = new System.Drawing.Size(94, 20);
            this.ImageBPMTextBox.TabIndex = 6;
            this.ImageBPMTextBox.Text = "120";
            this.ImageBPMTextBox.TextChanged += new System.EventHandler(this.ImageBPMTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Image BPM: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Click \"Reset\", select the text box";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "and press any key to the rythm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "to measure BPM";
            // 
            // TargetDelay
            // 
            this.TargetDelay.Location = new System.Drawing.Point(694, 35);
            this.TargetDelay.Name = "TargetDelay";
            this.TargetDelay.Size = new System.Drawing.Size(94, 20);
            this.TargetDelay.TabIndex = 13;
            this.TargetDelay.Text = "0";
            this.TargetDelay.TextChanged += new System.EventHandler(this.TargetDelay_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Target Delay: ";
            // 
            // ImageDelay
            // 
            this.ImageDelay.Location = new System.Drawing.Point(694, 368);
            this.ImageDelay.Name = "ImageDelay";
            this.ImageDelay.Size = new System.Drawing.Size(94, 20);
            this.ImageDelay.TabIndex = 15;
            this.ImageDelay.Text = "0";
            this.ImageDelay.TextChanged += new System.EventHandler(this.ImageDelay_TextChanged);
            // 
            // Ima
            // 
            this.Ima.AutoSize = true;
            this.Ima.Location = new System.Drawing.Point(618, 371);
            this.Ima.Name = "Ima";
            this.Ima.Size = new System.Drawing.Size(72, 13);
            this.Ima.TabIndex = 14;
            this.Ima.Text = "Image Delay: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(621, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Result:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Delay by:";
            // 
            // TrueDelay
            // 
            this.TrueDelay.Enabled = false;
            this.TrueDelay.Location = new System.Drawing.Point(679, 496);
            this.TrueDelay.Name = "TrueDelay";
            this.TrueDelay.Size = new System.Drawing.Size(106, 20);
            this.TrueDelay.TabIndex = 18;
            this.TrueDelay.Text = "Not calculated";
            // 
            // TrueSpeed
            // 
            this.TrueSpeed.Enabled = false;
            this.TrueSpeed.Location = new System.Drawing.Point(691, 522);
            this.TrueSpeed.Name = "TrueSpeed";
            this.TrueSpeed.Size = new System.Drawing.Size(94, 20);
            this.TrueSpeed.TabIndex = 20;
            this.TrueSpeed.Text = "Not calculated";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(621, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Speed factor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(618, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Image Sequence:";
            // 
            // Prefix
            // 
            this.Prefix.Location = new System.Drawing.Point(660, 131);
            this.Prefix.Name = "Prefix";
            this.Prefix.Size = new System.Drawing.Size(128, 20);
            this.Prefix.TabIndex = 23;
            this.Prefix.Text = "frame";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(618, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Prefix:";
            // 
            // Interfix
            // 
            this.Interfix.Location = new System.Drawing.Point(660, 157);
            this.Interfix.Name = "Interfix";
            this.Interfix.Size = new System.Drawing.Size(128, 20);
            this.Interfix.TabIndex = 25;
            this.Interfix.Text = "0000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(618, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Interfix:";
            // 
            // Suffix
            // 
            this.Suffix.Location = new System.Drawing.Point(660, 183);
            this.Suffix.Name = "Suffix";
            this.Suffix.Size = new System.Drawing.Size(128, 20);
            this.Suffix.TabIndex = 27;
            this.Suffix.Text = ".png";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(618, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Suffix:";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(675, 105);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(82, 20);
            this.Location.TabIndex = 29;
            this.Location.Text = "./example";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(618, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Location:";
            // 
            // SelectLocation
            // 
            this.SelectLocation.Location = new System.Drawing.Point(764, 105);
            this.SelectLocation.Name = "SelectLocation";
            this.SelectLocation.Size = new System.Drawing.Size(24, 20);
            this.SelectLocation.TabIndex = 30;
            this.SelectLocation.UseVisualStyleBackColor = true;
            // 
            // BeginFrame
            // 
            this.BeginFrame.Location = new System.Drawing.Point(660, 209);
            this.BeginFrame.Name = "BeginFrame";
            this.BeginFrame.Size = new System.Drawing.Size(128, 20);
            this.BeginFrame.TabIndex = 32;
            this.BeginFrame.Text = "auto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(618, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Begin:";
            // 
            // EndFrame
            // 
            this.EndFrame.Location = new System.Drawing.Point(660, 235);
            this.EndFrame.Name = "EndFrame";
            this.EndFrame.Size = new System.Drawing.Size(128, 20);
            this.EndFrame.TabIndex = 34;
            this.EndFrame.Text = "auto";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(618, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "End:";
            // 
            // FPS
            // 
            this.FPS.Location = new System.Drawing.Point(660, 260);
            this.FPS.Name = "FPS";
            this.FPS.Size = new System.Drawing.Size(128, 20);
            this.FPS.TabIndex = 36;
            this.FPS.Text = "60";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(618, 263);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "FPS:";
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(621, 570);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 37;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(624, 549);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Click on one of the beats";
            // 
            // Frames
            // 
            this.Frames.Enabled = false;
            this.Frames.Location = new System.Drawing.Point(668, 287);
            this.Frames.Name = "Frames";
            this.Frames.Size = new System.Drawing.Size(120, 20);
            this.Frames.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(618, 290);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Frames:";
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(620, 313);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(168, 23);
            this.Load.TabIndex = 41;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Splash ( F4 )";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Frames);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.FPS);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.EndFrame);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BeginFrame);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.SelectLocation);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Suffix);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Interfix);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Prefix);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TrueSpeed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TrueDelay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ImageDelay);
            this.Controls.Add(this.Ima);
            this.Controls.Add(this.TargetDelay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MeasureImageBPM);
            this.Controls.Add(this.ResetImageBPM);
            this.Controls.Add(this.ImageBPMTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MeasureTargetBPM);
            this.Controls.Add(this.ResetTargetBPM);
            this.Controls.Add(this.TargetBPMTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Match BPM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TargetBPMTextBox;
        private System.Windows.Forms.Button ResetTargetBPM;
        private System.Windows.Forms.TextBox MeasureTargetBPM;
        private System.Windows.Forms.TextBox MeasureImageBPM;
        private System.Windows.Forms.Button ResetImageBPM;
        private System.Windows.Forms.TextBox ImageBPMTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TargetDelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ImageDelay;
        private System.Windows.Forms.Label Ima;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TrueDelay;
        private System.Windows.Forms.TextBox TrueSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Prefix;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Interfix;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Suffix;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button SelectLocation;
        private System.Windows.Forms.TextBox BeginFrame;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox EndFrame;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox FPS;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Frames;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button button1;
    }
}

