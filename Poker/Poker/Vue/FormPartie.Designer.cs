namespace Poker
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
            this.button_seCoucher = new System.Windows.Forms.Button();
            this.button_miser = new System.Windows.Forms.Button();
            this.button_check = new System.Windows.Forms.Button();
            this.button_suivre = new System.Windows.Forms.Button();
            this.numericUpDown_mise = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // button_seCoucher
            // 
            this.button_seCoucher.Location = new System.Drawing.Point(785, 665);
            this.button_seCoucher.Margin = new System.Windows.Forms.Padding(4);
            this.button_seCoucher.Name = "button_seCoucher";
            this.button_seCoucher.Size = new System.Drawing.Size(100, 28);
            this.button_seCoucher.TabIndex = 8;
            this.button_seCoucher.Text = "Se coucher";
            this.button_seCoucher.UseVisualStyleBackColor = true;
            // 
            // button_miser
            // 
            this.button_miser.Location = new System.Drawing.Point(1412, 665);
            this.button_miser.Margin = new System.Windows.Forms.Padding(4);
            this.button_miser.Name = "button_miser";
            this.button_miser.Size = new System.Drawing.Size(100, 28);
            this.button_miser.TabIndex = 9;
            this.button_miser.Text = "Miser";
            this.button_miser.UseVisualStyleBackColor = true;
            this.button_miser.Click += new System.EventHandler(this.button_miser_Click);
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(1061, 665);
            this.button_check.Margin = new System.Windows.Forms.Padding(4);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(100, 28);
            this.button_check.TabIndex = 10;
            this.button_check.Text = "Check";
            this.button_check.UseVisualStyleBackColor = true;
            // 
            // button_suivre
            // 
            this.button_suivre.Location = new System.Drawing.Point(911, 665);
            this.button_suivre.Margin = new System.Windows.Forms.Padding(4);
            this.button_suivre.Name = "button_suivre";
            this.button_suivre.Size = new System.Drawing.Size(100, 28);
            this.button_suivre.TabIndex = 11;
            this.button_suivre.Text = "Suivre";
            this.button_suivre.UseVisualStyleBackColor = true;
            this.button_suivre.Click += new System.EventHandler(this.button_suivre_Click);
            // 
            // numericUpDown_mise
            // 
            this.numericUpDown_mise.Location = new System.Drawing.Point(1216, 668);
            this.numericUpDown_mise.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_mise.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_mise.Name = "numericUpDown_mise";
            this.numericUpDown_mise.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown_mise.TabIndex = 12;
            this.numericUpDown_mise.ValueChanged += new System.EventHandler(this.numericUpDown_mise_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1361, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 146);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1404, 54);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 146);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(544, 255);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 146);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(665, 255);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 146);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(787, 255);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(115, 146);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(64, 39);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 22;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("table.BackgroundImage")));
            this.table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.table.Location = new System.Drawing.Point(-85, -126);
            this.table.Margin = new System.Windows.Forms.Padding(4);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(1821, 945);
            this.table.TabIndex = 7;
            this.table.TabStop = false;
            // 
            // FormPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 809);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDown_mise);
            this.Controls.Add(this.button_suivre);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.button_miser);
            this.Controls.Add(this.button_seCoucher);
            this.Controls.Add(this.table);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPartie";
            this.Text = "FormPartie";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_seCoucher;
        private System.Windows.Forms.Button button_miser;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_suivre;
        private System.Windows.Forms.NumericUpDown numericUpDown_mise;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.PictureBox table;
    }
}

