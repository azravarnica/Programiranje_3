namespace FIT.WinForms
{
    partial class frmIgraci
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
            txtIgrac1 = new TextBox();
            txtIgrac2 = new TextBox();
            label1 = new Label();
            btnStart = new Button();
            SuspendLayout();
            // 
            // txtIgrac1
            // 
            txtIgrac1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtIgrac1.Location = new Point(27, 37);
            txtIgrac1.Name = "txtIgrac1";
            txtIgrac1.Size = new Size(135, 34);
            txtIgrac1.TabIndex = 0;
            // 
            // txtIgrac2
            // 
            txtIgrac2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtIgrac2.Location = new Point(331, 37);
            txtIgrac2.Name = "txtIgrac2";
            txtIgrac2.Size = new Size(135, 34);
            txtIgrac2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(224, 37);
            label1.Name = "label1";
            label1.Size = new Size(50, 37);
            label1.TabIndex = 2;
            label1.Text = "VS";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(199, 140);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 36);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // frmIgraci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 227);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Controls.Add(txtIgrac2);
            Controls.Add(txtIgrac1);
            Name = "frmIgraci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmIgraci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIgrac1;
        private TextBox txtIgrac2;
        private Label label1;
        private Button btnStart;
    }
}