using System.Windows.Forms;
using System.Xml.Linq;

namespace JogodaMemoria
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            label1 = new Label();
            pictureBox14 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox10 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.alberto;
            pictureBox1.Location = new Point(54, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "0";
            pictureBox1.Click += ClickImg_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.alberto;
            pictureBox2.Location = new Point(191, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "0";
            pictureBox2.Click += ClickImg_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.daniela;
            pictureBox3.Location = new Point(327, 77);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(130, 141);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "1";
            pictureBox3.Click += ClickImg_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.daniela;
            pictureBox4.Location = new Point(462, 77);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(130, 141);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "1";
            pictureBox4.Click += ClickImg_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.gato;
            pictureBox5.Location = new Point(55, 224);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(130, 141);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "2";
            pictureBox5.Click += ClickImg_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.luca2;
            pictureBox6.Location = new Point(55, 518);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(130, 141);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "6";
            pictureBox6.Click += ClickImg_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.giulia;
            pictureBox11.Location = new Point(462, 224);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(130, 141);
            pictureBox11.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox11.TabIndex = 10;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "3";
            pictureBox11.Click += ClickImg_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.lorenzo;
            pictureBox13.Location = new Point(55, 371);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(130, 141);
            pictureBox13.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox13.TabIndex = 12;
            pictureBox13.TabStop = false;
            pictureBox13.Tag = "4";
            pictureBox13.Click += ClickImg_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Properties.Resources.giulia;
            pictureBox15.Location = new Point(327, 224);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(130, 141);
            pictureBox15.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox15.TabIndex = 14;
            pictureBox15.TabStop = false;
            pictureBox15.Tag = "3";
            pictureBox15.Click += ClickImg_Click;
            // 
            // pictureBox16
            // 
            pictureBox16.Image = Properties.Resources.gato;
            pictureBox16.Location = new Point(191, 224);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(130, 141);
            pictureBox16.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox16.TabIndex = 15;
            pictureBox16.TabStop = false;
            pictureBox16.Tag = "2";
            pictureBox16.Click += ClickImg_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.luca;
            pictureBox7.Location = new Point(327, 371);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(130, 141);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "5";
            pictureBox7.Click += ClickImg_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.massimo;
            pictureBox9.Location = new Point(327, 518);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(130, 141);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 19;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "7";
            pictureBox9.Click += ClickImg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yearbook", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 22);
            label1.Name = "label1";
            label1.Size = new Size(151, 35);
            label1.TabIndex = 21;
            label1.Text = "Movimentos:";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.lorenzo;
            pictureBox14.Location = new Point(191, 371);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(130, 141);
            pictureBox14.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox14.TabIndex = 22;
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "4";
            pictureBox14.Click += ClickImg_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.luca;
            pictureBox8.Location = new Point(462, 371);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(130, 141);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 23;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "5";
            pictureBox8.Click += ClickImg_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.luca2;
            pictureBox12.Location = new Point(191, 518);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(130, 141);
            pictureBox12.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox12.TabIndex = 24;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "6";
            pictureBox12.Click += ClickImg_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.massimo;
            pictureBox10.Location = new Point(462, 518);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(130, 141);
            pictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox10.TabIndex = 25;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "7";
            pictureBox10.Click += ClickImg_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = Properties.Resources.fundo1;
            ClientSize = new Size(645, 701);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox14);
            Controls.Add(label1);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo da Memória";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox11;
        private PictureBox pictureBox13;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private Label label1;
        private PictureBox pictureBox14;
        private PictureBox pictureBox8;
        private PictureBox pictureBox12;
        private PictureBox pictureBox10;
    }
}