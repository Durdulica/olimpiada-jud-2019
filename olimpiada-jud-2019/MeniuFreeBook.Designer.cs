namespace olimpiada_jud_2019
{
    partial class MeniuFreeBook
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDisponibile = new System.Windows.Forms.TabPage();
            this.tabImprumutate = new System.Windows.Forms.TabPage();
            this.dgvImprumut = new System.Windows.Forms.DataGridView();
            this.tabStatistici = new System.Windows.Forms.TabPage();
            this.lblIesire = new System.Windows.Forms.Label();
            this.dgvDisponibile = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabDisponibile.SuspendLayout();
            this.tabImprumutate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImprumut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 23);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 19);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "lblEmail";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDisponibile);
            this.tabControl.Controls.Add(this.tabImprumutate);
            this.tabControl.Controls.Add(this.tabStatistici);
            this.tabControl.Location = new System.Drawing.Point(12, 65);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(844, 356);
            this.tabControl.TabIndex = 1;
            // 
            // tabDisponibile
            // 
            this.tabDisponibile.Controls.Add(this.dgvDisponibile);
            this.tabDisponibile.Location = new System.Drawing.Point(4, 28);
            this.tabDisponibile.Name = "tabDisponibile";
            this.tabDisponibile.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisponibile.Size = new System.Drawing.Size(836, 324);
            this.tabDisponibile.TabIndex = 0;
            this.tabDisponibile.Text = "Carti disponibile";
            this.tabDisponibile.UseVisualStyleBackColor = true;
            // 
            // tabImprumutate
            // 
            this.tabImprumutate.Controls.Add(this.dgvImprumut);
            this.tabImprumutate.Location = new System.Drawing.Point(4, 28);
            this.tabImprumutate.Name = "tabImprumutate";
            this.tabImprumutate.Padding = new System.Windows.Forms.Padding(3);
            this.tabImprumutate.Size = new System.Drawing.Size(836, 324);
            this.tabImprumutate.TabIndex = 1;
            this.tabImprumutate.Text = "Carti Imprumutate";
            this.tabImprumutate.UseVisualStyleBackColor = true;
            // 
            // dgvImprumut
            // 
            this.dgvImprumut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImprumut.Location = new System.Drawing.Point(6, 6);
            this.dgvImprumut.Name = "dgvImprumut";
            this.dgvImprumut.Size = new System.Drawing.Size(824, 218);
            this.dgvImprumut.TabIndex = 0;
            this.dgvImprumut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabStatistici
            // 
            this.tabStatistici.Location = new System.Drawing.Point(4, 28);
            this.tabStatistici.Name = "tabStatistici";
            this.tabStatistici.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistici.Size = new System.Drawing.Size(836, 324);
            this.tabStatistici.TabIndex = 2;
            this.tabStatistici.Text = "Statistici biblioteca";
            this.tabStatistici.UseVisualStyleBackColor = true;
            // 
            // lblIesire
            // 
            this.lblIesire.AutoSize = true;
            this.lblIesire.Location = new System.Drawing.Point(35, 424);
            this.lblIesire.Name = "lblIesire";
            this.lblIesire.Size = new System.Drawing.Size(208, 19);
            this.lblIesire.TabIndex = 2;
            this.lblIesire.Text = "Apasati tasta ESC pentru a iesi";
            // 
            // dgvDisponibile
            // 
            this.dgvDisponibile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibile.Location = new System.Drawing.Point(6, 16);
            this.dgvDisponibile.Name = "dgvDisponibile";
            this.dgvDisponibile.Size = new System.Drawing.Size(829, 277);
            this.dgvDisponibile.TabIndex = 0;
            // 
            // MeniuFreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(874, 445);
            this.Controls.Add(this.lblIesire);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblEmail);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeniuFreeBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuFreeBook";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MeniuFreeBook_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.tabDisponibile.ResumeLayout(false);
            this.tabImprumutate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImprumut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDisponibile;
        private System.Windows.Forms.TabPage tabImprumutate;
        private System.Windows.Forms.DataGridView dgvImprumut;
        private System.Windows.Forms.TabPage tabStatistici;
        private System.Windows.Forms.Label lblIesire;
        private System.Windows.Forms.DataGridView dgvDisponibile;
    }
}