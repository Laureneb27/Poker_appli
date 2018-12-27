﻿namespace Poker
{
    partial class FormPartie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPartie));
            this.table = new System.Windows.Forms.PictureBox();
            this.button_seCoucher = new System.Windows.Forms.Button();
            this.button_miser = new System.Windows.Forms.Button();
            this.button_check = new System.Windows.Forms.Button();
            this.button_suivre = new System.Windows.Forms.Button();
            this.numericUpDown_mise = new System.Windows.Forms.NumericUpDown();
            this.label_pseudo = new System.Windows.Forms.Label();
            this.label_argent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("table.BackgroundImage")));
            this.table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.table.Location = new System.Drawing.Point(-64, -102);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(1366, 768);
            this.table.TabIndex = 7;
            this.table.TabStop = false;
            // 
            // button_seCoucher
            // 
            this.button_seCoucher.Location = new System.Drawing.Point(589, 540);
            this.button_seCoucher.Name = "button_seCoucher";
            this.button_seCoucher.Size = new System.Drawing.Size(75, 23);
            this.button_seCoucher.TabIndex = 8;
            this.button_seCoucher.Text = "Se coucher";
            this.button_seCoucher.UseVisualStyleBackColor = true;
            // 
            // button_miser
            // 
            this.button_miser.Location = new System.Drawing.Point(1059, 540);
            this.button_miser.Name = "button_miser";
            this.button_miser.Size = new System.Drawing.Size(75, 23);
            this.button_miser.TabIndex = 9;
            this.button_miser.Text = "Miser";
            this.button_miser.UseVisualStyleBackColor = true;
            this.button_miser.Click += new System.EventHandler(this.button_miser_Click);
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(796, 540);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(75, 23);
            this.button_check.TabIndex = 10;
            this.button_check.Text = "Check";
            this.button_check.UseVisualStyleBackColor = true;
            // 
            // button_suivre
            // 
            this.button_suivre.Location = new System.Drawing.Point(683, 540);
            this.button_suivre.Name = "button_suivre";
            this.button_suivre.Size = new System.Drawing.Size(75, 23);
            this.button_suivre.TabIndex = 11;
            this.button_suivre.Text = "Suivre";
            this.button_suivre.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_mise
            // 
            this.numericUpDown_mise.Location = new System.Drawing.Point(912, 543);
            this.numericUpDown_mise.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_mise.Name = "numericUpDown_mise";
            this.numericUpDown_mise.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_mise.TabIndex = 12;
            this.numericUpDown_mise.ValueChanged += new System.EventHandler(this.numericUpDown_mise_ValueChanged);
            // 
            // label_pseudo
            // 
            this.label_pseudo.AutoSize = true;
            this.label_pseudo.BackColor = System.Drawing.Color.Salmon;
            this.label_pseudo.Location = new System.Drawing.Point(142, 497);
            this.label_pseudo.Name = "label_pseudo";
            this.label_pseudo.Size = new System.Drawing.Size(43, 13);
            this.label_pseudo.TabIndex = 13;
            this.label_pseudo.Text = "Pseudo";
            // 
            // label_argent
            // 
            this.label_argent.AutoSize = true;
            this.label_argent.BackColor = System.Drawing.Color.Salmon;
            this.label_argent.Location = new System.Drawing.Point(147, 520);
            this.label_argent.Name = "label_argent";
            this.label_argent.Size = new System.Drawing.Size(38, 13);
            this.label_argent.TabIndex = 14;
            this.label_argent.Text = "Argent";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1021, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 119);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1053, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 119);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(408, 207);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 119);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(499, 207);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 119);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(590, 207);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(86, 119);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(1069, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Argent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(1064, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pseudo";
            // 
            // FormPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_argent);
            this.Controls.Add(this.label_pseudo);
            this.Controls.Add(this.numericUpDown_mise);
            this.Controls.Add(this.button_suivre);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.button_miser);
            this.Controls.Add(this.button_seCoucher);
            this.Controls.Add(this.table);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPartie";
            this.Text = "FormPartie";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox table;
        private System.Windows.Forms.Button button_seCoucher;
        private System.Windows.Forms.Button button_miser;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_suivre;
        private System.Windows.Forms.NumericUpDown numericUpDown_mise;
        private System.Windows.Forms.Label label_pseudo;
        private System.Windows.Forms.Label label_argent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

