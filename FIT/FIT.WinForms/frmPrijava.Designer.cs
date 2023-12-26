namespace FIT.WinForms
{
    partial class frmPrijava
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtKorisnickoIme = new TextBox();
            txtLozinka = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnPrijava = new Button();
            label3 = new Label();
            err = new ErrorProvider(components);
            lblRegistracija = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 39);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Korisnicko ime:";
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKorisnickoIme.Location = new Point(189, 57);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(219, 29);
            txtKorisnickoIme.TabIndex = 1;
            // 
            // txtLozinka
            // 
            txtLozinka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLozinka.Location = new Point(189, 110);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(219, 29);
            txtLozinka.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 92);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Lozinka:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_fit;
            pictureBox1.Location = new Point(12, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnPrijava
            // 
            btnPrijava.Location = new Point(333, 155);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(75, 23);
            btnPrijava.TabIndex = 5;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.InactiveCaptionText;
            label3.Location = new Point(167, 26);
            label3.Name = "label3";
            label3.Size = new Size(1, 168);
            label3.TabIndex = 6;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // lblRegistracija
            // 
            lblRegistracija.AutoSize = true;
            lblRegistracija.Location = new Point(189, 163);
            lblRegistracija.Name = "lblRegistracija";
            lblRegistracija.Size = new Size(99, 15);
            lblRegistracija.TabIndex = 7;
            lblRegistracija.TabStop = true;
            lblRegistracija.Text = "Niste registrovani";
            lblRegistracija.LinkClicked += lblRegistracija_LinkClicked;
            // 
            // frmPrijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 224);
            Controls.Add(lblRegistracija);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnPrijava);
            Controls.Add(txtLozinka);
            Controls.Add(label2);
            Controls.Add(txtKorisnickoIme);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrijava";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DLWMS = Prijava";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKorisnickoIme;
        private TextBox txtLozinka;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnPrijava;
        private Label label3;
        private ErrorProvider err;
        private LinkLabel lblRegistracija;
    }
}