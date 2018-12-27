namespace Poker.Vue
{
    partial class FormCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreation));
            this.button_creer = new System.Windows.Forms.Button();
            this.label_pseudo = new System.Windows.Forms.Label();
            this.label_argent = new System.Windows.Forms.Label();
            this.numericUpDown_argent = new System.Windows.Forms.NumericUpDown();
            this.textBox_pseudo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_fermer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_argent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_creer
            // 
            this.button_creer.Location = new System.Drawing.Point(99, 228);
            this.button_creer.Name = "button_creer";
            this.button_creer.Size = new System.Drawing.Size(75, 23);
            this.button_creer.TabIndex = 0;
            this.button_creer.Text = "Creer";
            this.button_creer.UseVisualStyleBackColor = true;
            this.button_creer.Click += new System.EventHandler(this.button_creer_Click);
            // 
            // label_pseudo
            // 
            this.label_pseudo.AutoSize = true;
            this.label_pseudo.Location = new System.Drawing.Point(60, 110);
            this.label_pseudo.Name = "label_pseudo";
            this.label_pseudo.Size = new System.Drawing.Size(88, 13);
            this.label_pseudo.TabIndex = 1;
            this.label_pseudo.Text = "Entrer un pseudo";
            // 
            // label_argent
            // 
            this.label_argent.AutoSize = true;
            this.label_argent.Location = new System.Drawing.Point(61, 172);
            this.label_argent.Name = "label_argent";
            this.label_argent.Size = new System.Drawing.Size(129, 13);
            this.label_argent.TabIndex = 2;
            this.label_argent.Text = "Entrer l\'argent des joueurs";
            // 
            // numericUpDown_argent
            // 
            this.numericUpDown_argent.Location = new System.Drawing.Point(205, 169);
            this.numericUpDown_argent.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numericUpDown_argent.Name = "numericUpDown_argent";
            this.numericUpDown_argent.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown_argent.TabIndex = 3;
            // 
            // textBox_pseudo
            // 
            this.textBox_pseudo.Location = new System.Drawing.Point(205, 107);
            this.textBox_pseudo.Name = "textBox_pseudo";
            this.textBox_pseudo.Size = new System.Drawing.Size(101, 20);
            this.textBox_pseudo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Créer votre partie !";
            // 
            // button_fermer
            // 
            this.button_fermer.BackColor = System.Drawing.SystemColors.Control;
            this.button_fermer.Location = new System.Drawing.Point(205, 228);
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.Size = new System.Drawing.Size(75, 23);
            this.button_fermer.TabIndex = 6;
            this.button_fermer.Text = "Fermer";
            this.button_fermer.UseVisualStyleBackColor = false;
            this.button_fermer.Click += new System.EventHandler(this.button_fermer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(323, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(205, 145);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(101, 20);
            this.txtIp.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Entrer une IP";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(366, 107);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(90, 144);
            this.txtStatus.TabIndex = 18;
            // 
            // FormCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 295);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_pseudo);
            this.Controls.Add(this.numericUpDown_argent);
            this.Controls.Add(this.label_argent);
            this.Controls.Add(this.label_pseudo);
            this.Controls.Add(this.button_creer);
            this.Name = "FormCreation";
            this.Text = "FormCreation";
            this.Load += new System.EventHandler(this.FormCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_argent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_creer;
        private System.Windows.Forms.Label label_pseudo;
        private System.Windows.Forms.Label label_argent;
        private System.Windows.Forms.NumericUpDown numericUpDown_argent;
        private System.Windows.Forms.TextBox textBox_pseudo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_fermer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
    }
}