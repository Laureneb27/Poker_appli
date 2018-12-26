namespace Poker.Vue
{
    partial class FormRejoindre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRejoindre));
            this.textBox_idPartie = new System.Windows.Forms.TextBox();
            this.label_pseudo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_rejoindre = new System.Windows.Forms.Button();
            this.textBox_pseudoRejoindre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_fermer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_idPartie
            // 
            this.textBox_idPartie.Location = new System.Drawing.Point(207, 105);
            this.textBox_idPartie.Name = "textBox_idPartie";
            this.textBox_idPartie.Size = new System.Drawing.Size(101, 20);
            this.textBox_idPartie.TabIndex = 6;
            // 
            // label_pseudo
            // 
            this.label_pseudo.AutoSize = true;
            this.label_pseudo.Location = new System.Drawing.Point(62, 108);
            this.label_pseudo.Name = "label_pseudo";
            this.label_pseudo.Size = new System.Drawing.Size(105, 13);
            this.label_pseudo.TabIndex = 5;
            this.label_pseudo.Text = "Entrer l\'id de la partie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rejoindre une partie !";
            // 
            // button_rejoindre
            // 
            this.button_rejoindre.Location = new System.Drawing.Point(92, 238);
            this.button_rejoindre.Name = "button_rejoindre";
            this.button_rejoindre.Size = new System.Drawing.Size(75, 23);
            this.button_rejoindre.TabIndex = 8;
            this.button_rejoindre.Text = "Rejoindre";
            this.button_rejoindre.UseVisualStyleBackColor = true;
            this.button_rejoindre.Click += new System.EventHandler(this.button_rejoindre_Click);
            // 
            // textBox_pseudoRejoindre
            // 
            this.textBox_pseudoRejoindre.Location = new System.Drawing.Point(207, 160);
            this.textBox_pseudoRejoindre.Name = "textBox_pseudoRejoindre";
            this.textBox_pseudoRejoindre.Size = new System.Drawing.Size(101, 20);
            this.textBox_pseudoRejoindre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Entrer un pseudo";
            // 
            // button_fermer
            // 
            this.button_fermer.BackColor = System.Drawing.SystemColors.Control;
            this.button_fermer.Location = new System.Drawing.Point(221, 238);
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.Size = new System.Drawing.Size(75, 23);
            this.button_fermer.TabIndex = 11;
            this.button_fermer.Text = "Fermer";
            this.button_fermer.UseVisualStyleBackColor = false;
            this.button_fermer.Click += new System.EventHandler(this.button_fermer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // FormRejoindre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.textBox_pseudoRejoindre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_rejoindre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_idPartie);
            this.Controls.Add(this.label_pseudo);
            this.Name = "FormRejoindre";
            this.Text = "FormRejoindre";
            this.Load += new System.EventHandler(this.FormRejoindre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_idPartie;
        private System.Windows.Forms.Label label_pseudo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_rejoindre;
        private System.Windows.Forms.TextBox textBox_pseudoRejoindre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_fermer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}