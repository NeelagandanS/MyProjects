namespace stoplight
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
            this.Btnstart = new System.Windows.Forms.Button();
            this.Btnstop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Car = new System.Windows.Forms.PictureBox();
            this.greenStopLight = new System.Windows.Forms.PictureBox();
            this.yellowStopLight = new System.Windows.Forms.PictureBox();
            this.redStopLight = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenStopLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStopLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redStopLight)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnstart
            // 
            this.Btnstart.Location = new System.Drawing.Point(460, 59);
            this.Btnstart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btnstart.Name = "Btnstart";
            this.Btnstart.Size = new System.Drawing.Size(123, 48);
            this.Btnstart.TabIndex = 3;
            this.Btnstart.Text = "start";
            this.Btnstart.UseVisualStyleBackColor = true;
            this.Btnstart.Click += new System.EventHandler(this.Btnstart_Click_1);
            // 
            // Btnstop
            // 
            this.Btnstop.Location = new System.Drawing.Point(460, 138);
            this.Btnstop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btnstop.Name = "Btnstop";
            this.Btnstop.Size = new System.Drawing.Size(123, 42);
            this.Btnstop.TabIndex = 4;
            this.Btnstop.Text = "stop";
            this.Btnstop.UseVisualStyleBackColor = true;
            this.Btnstop.Click += new System.EventHandler(this.Btnstop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Car
            // 
            this.Car.Image = global::stoplight.Properties.Resources._2car;
            this.Car.Location = new System.Drawing.Point(135, 394);
            this.Car.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(204, 81);
            this.Car.TabIndex = 5;
            this.Car.TabStop = false;
            // 
            // greenStopLight
            // 
            this.greenStopLight.Image = global::stoplight.Properties.Resources.green;
            this.greenStopLight.Location = new System.Drawing.Point(69, 34);
            this.greenStopLight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.greenStopLight.Name = "greenStopLight";
            this.greenStopLight.Size = new System.Drawing.Size(296, 325);
            this.greenStopLight.TabIndex = 2;
            this.greenStopLight.TabStop = false;
            // 
            // yellowStopLight
            // 
            this.yellowStopLight.Image = global::stoplight.Properties.Resources.yellow;
            this.yellowStopLight.Location = new System.Drawing.Point(69, 34);
            this.yellowStopLight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yellowStopLight.Name = "yellowStopLight";
            this.yellowStopLight.Size = new System.Drawing.Size(296, 325);
            this.yellowStopLight.TabIndex = 1;
            this.yellowStopLight.TabStop = false;
            // 
            // redStopLight
            // 
            this.redStopLight.Image = global::stoplight.Properties.Resources.red2;
            this.redStopLight.Location = new System.Drawing.Point(69, 34);
            this.redStopLight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.redStopLight.Name = "redStopLight";
            this.redStopLight.Size = new System.Drawing.Size(296, 325);
            this.redStopLight.TabIndex = 0;
            this.redStopLight.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 561);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.Btnstop);
            this.Controls.Add(this.Btnstart);
            this.Controls.Add(this.greenStopLight);
            this.Controls.Add(this.yellowStopLight);
            this.Controls.Add(this.redStopLight);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenStopLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStopLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redStopLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redStopLight;
        private System.Windows.Forms.PictureBox yellowStopLight;
        private System.Windows.Forms.PictureBox greenStopLight;
        private System.Windows.Forms.Button Btnstart;
        private System.Windows.Forms.Button Btnstop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.Timer timer2;
    }
}

