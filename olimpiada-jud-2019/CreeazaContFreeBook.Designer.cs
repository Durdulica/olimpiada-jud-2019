namespace olimpiada_jud_2019
{
    partial class CreeazaContFreeBook
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblParola2 = new System.Windows.Forms.Label();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtParola2 = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblIesire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(71, 73);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 19);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(71, 106);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(47, 19);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(71, 134);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(66, 19);
            this.lblPrenume.TabIndex = 2;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(71, 167);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(50, 19);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parola";
            // 
            // lblParola2
            // 
            this.lblParola2.AutoSize = true;
            this.lblParola2.Location = new System.Drawing.Point(71, 200);
            this.lblParola2.Name = "lblParola2";
            this.lblParola2.Size = new System.Drawing.Size(125, 19);
            this.lblParola2.TabIndex = 4;
            this.lblParola2.Text = "Confirmare parola";
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.Location = new System.Drawing.Point(197, 272);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(144, 47);
            this.btnInregistrare.TabIndex = 5;
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = true;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(234, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 27);
            this.txtEmail.TabIndex = 0;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(234, 164);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(232, 27);
            this.txtParola.TabIndex = 3;
            // 
            // txtParola2
            // 
            this.txtParola2.Location = new System.Drawing.Point(234, 197);
            this.txtParola2.Name = "txtParola2";
            this.txtParola2.PasswordChar = '*';
            this.txtParola2.Size = new System.Drawing.Size(232, 27);
            this.txtParola2.TabIndex = 4;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(234, 131);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(232, 27);
            this.txtPrenume.TabIndex = 2;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(234, 98);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(232, 27);
            this.txtNume.TabIndex = 1;
            // 
            // lblIesire
            // 
            this.lblIesire.AutoSize = true;
            this.lblIesire.Location = new System.Drawing.Point(12, 334);
            this.lblIesire.Name = "lblIesire";
            this.lblIesire.Size = new System.Drawing.Size(208, 19);
            this.lblIesire.TabIndex = 6;
            this.lblIesire.Text = "Apasati tasta ESC pentru a iesi";
            // 
            // CreeazaContFreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(559, 362);
            this.Controls.Add(this.lblIesire);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtParola2);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.lblParola2);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblEmail);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreeazaContFreeBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreeazaContFreeBook";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreeazaContFreeBook_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblParola2;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtParola2;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblIesire;
    }
}