namespace Memorija
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p00 = new System.Windows.Forms.PictureBox();
            this.p01 = new System.Windows.Forms.PictureBox();
            this.p02 = new System.Windows.Forms.PictureBox();
            this.p03 = new System.Windows.Forms.PictureBox();
            this.p13 = new System.Windows.Forms.PictureBox();
            this.p12 = new System.Windows.Forms.PictureBox();
            this.p11 = new System.Windows.Forms.PictureBox();
            this.p10 = new System.Windows.Forms.PictureBox();
            this.p23 = new System.Windows.Forms.PictureBox();
            this.p22 = new System.Windows.Forms.PictureBox();
            this.p21 = new System.Windows.Forms.PictureBox();
            this.p20 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p33 = new System.Windows.Forms.PictureBox();
            this.p32 = new System.Windows.Forms.PictureBox();
            this.p31 = new System.Windows.Forms.PictureBox();
            this.p30 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ShortPause = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.p00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p30)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // p00
            // 
            this.p00.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p00.Location = new System.Drawing.Point(125, 151);
            this.p00.Name = "p00";
            this.p00.Size = new System.Drawing.Size(100, 100);
            this.p00.TabIndex = 0;
            this.p00.TabStop = false;
            this.p00.Tag = "1";
            this.p00.Click += new System.EventHandler(this.Check_Click);
            // 
            // p01
            // 
            this.p01.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p01.Location = new System.Drawing.Point(275, 151);
            this.p01.Name = "p01";
            this.p01.Size = new System.Drawing.Size(100, 100);
            this.p01.TabIndex = 2;
            this.p01.TabStop = false;
            this.p01.Click += new System.EventHandler(this.Check_Click);
            // 
            // p02
            // 
            this.p02.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p02.Location = new System.Drawing.Point(425, 151);
            this.p02.Name = "p02";
            this.p02.Size = new System.Drawing.Size(100, 100);
            this.p02.TabIndex = 3;
            this.p02.TabStop = false;
            this.p02.Click += new System.EventHandler(this.Check_Click);
            // 
            // p03
            // 
            this.p03.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p03.Location = new System.Drawing.Point(575, 151);
            this.p03.Name = "p03";
            this.p03.Size = new System.Drawing.Size(100, 100);
            this.p03.TabIndex = 4;
            this.p03.TabStop = false;
            this.p03.Click += new System.EventHandler(this.Check_Click);
            // 
            // p13
            // 
            this.p13.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p13.Location = new System.Drawing.Point(575, 301);
            this.p13.Name = "p13";
            this.p13.Size = new System.Drawing.Size(100, 100);
            this.p13.TabIndex = 8;
            this.p13.TabStop = false;
            this.p13.Click += new System.EventHandler(this.Check_Click);
            // 
            // p12
            // 
            this.p12.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p12.Location = new System.Drawing.Point(425, 301);
            this.p12.Name = "p12";
            this.p12.Size = new System.Drawing.Size(100, 100);
            this.p12.TabIndex = 7;
            this.p12.TabStop = false;
            this.p12.Click += new System.EventHandler(this.Check_Click);
            // 
            // p11
            // 
            this.p11.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p11.Location = new System.Drawing.Point(275, 301);
            this.p11.Name = "p11";
            this.p11.Size = new System.Drawing.Size(100, 100);
            this.p11.TabIndex = 6;
            this.p11.TabStop = false;
            this.p11.Click += new System.EventHandler(this.Check_Click);
            // 
            // p10
            // 
            this.p10.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p10.Location = new System.Drawing.Point(125, 301);
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(100, 100);
            this.p10.TabIndex = 5;
            this.p10.TabStop = false;
            this.p10.Click += new System.EventHandler(this.Check_Click);
            // 
            // p23
            // 
            this.p23.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p23.Location = new System.Drawing.Point(575, 451);
            this.p23.Name = "p23";
            this.p23.Size = new System.Drawing.Size(100, 100);
            this.p23.TabIndex = 12;
            this.p23.TabStop = false;
            this.p23.Click += new System.EventHandler(this.Check_Click);
            // 
            // p22
            // 
            this.p22.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p22.Location = new System.Drawing.Point(425, 451);
            this.p22.Name = "p22";
            this.p22.Size = new System.Drawing.Size(100, 100);
            this.p22.TabIndex = 11;
            this.p22.TabStop = false;
            this.p22.Click += new System.EventHandler(this.Check_Click);
            // 
            // p21
            // 
            this.p21.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p21.Location = new System.Drawing.Point(275, 451);
            this.p21.Name = "p21";
            this.p21.Size = new System.Drawing.Size(100, 100);
            this.p21.TabIndex = 10;
            this.p21.TabStop = false;
            this.p21.Click += new System.EventHandler(this.Check_Click);
            // 
            // p20
            // 
            this.p20.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p20.Location = new System.Drawing.Point(125, 451);
            this.p20.Name = "p20";
            this.p20.Size = new System.Drawing.Size(100, 100);
            this.p20.TabIndex = 9;
            this.p20.TabStop = false;
            this.p20.Click += new System.EventHandler(this.Check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(158, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "00:00";
            // 
            // p33
            // 
            this.p33.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p33.Location = new System.Drawing.Point(575, 601);
            this.p33.Name = "p33";
            this.p33.Size = new System.Drawing.Size(100, 100);
            this.p33.TabIndex = 17;
            this.p33.TabStop = false;
            this.p33.Click += new System.EventHandler(this.Check_Click);
            // 
            // p32
            // 
            this.p32.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p32.Location = new System.Drawing.Point(425, 601);
            this.p32.Name = "p32";
            this.p32.Size = new System.Drawing.Size(100, 100);
            this.p32.TabIndex = 16;
            this.p32.TabStop = false;
            this.p32.Click += new System.EventHandler(this.Check_Click);
            // 
            // p31
            // 
            this.p31.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p31.Location = new System.Drawing.Point(275, 601);
            this.p31.Name = "p31";
            this.p31.Size = new System.Drawing.Size(100, 100);
            this.p31.TabIndex = 15;
            this.p31.TabStop = false;
            this.p31.Click += new System.EventHandler(this.Check_Click);
            // 
            // p30
            // 
            this.p30.BackgroundImage = global::Memorija.Properties.Resources.cover;
            this.p30.Location = new System.Drawing.Point(125, 601);
            this.p30.Name = "p30";
            this.p30.Size = new System.Drawing.Size(100, 100);
            this.p30.TabIndex = 14;
            this.p30.TabStop = false;
            this.p30.Click += new System.EventHandler(this.Check_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Time:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(659, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShortPause
            // 
            this.ShortPause.Interval = 800;
            this.ShortPause.Tick += new System.EventHandler(this.ShortPause_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memorija.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p33);
            this.Controls.Add(this.p32);
            this.Controls.Add(this.p31);
            this.Controls.Add(this.p30);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p23);
            this.Controls.Add(this.p22);
            this.Controls.Add(this.p21);
            this.Controls.Add(this.p20);
            this.Controls.Add(this.p13);
            this.Controls.Add(this.p12);
            this.Controls.Add(this.p11);
            this.Controls.Add(this.p10);
            this.Controls.Add(this.p03);
            this.Controls.Add(this.p02);
            this.Controls.Add(this.p01);
            this.Controls.Add(this.p00);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Меморија";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p30)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p00;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox p01;
        private System.Windows.Forms.PictureBox p02;
        private System.Windows.Forms.PictureBox p03;
        private System.Windows.Forms.PictureBox p13;
        private System.Windows.Forms.PictureBox p12;
        private System.Windows.Forms.PictureBox p11;
        private System.Windows.Forms.PictureBox p10;
        private System.Windows.Forms.PictureBox p23;
        private System.Windows.Forms.PictureBox p22;
        private System.Windows.Forms.PictureBox p21;
        private System.Windows.Forms.PictureBox p20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox p33;
        private System.Windows.Forms.PictureBox p32;
        private System.Windows.Forms.PictureBox p31;
        private System.Windows.Forms.PictureBox p30;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer ShortPause;
        private System.Windows.Forms.Timer timer2;
    }
}

