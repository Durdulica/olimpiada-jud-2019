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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataImprumut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStatistici = new System.Windows.Forms.TabPage();
            this.lblIesire = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabImprumutate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabImprumutate.Controls.Add(this.dataGridView1);
            this.tabImprumutate.Location = new System.Drawing.Point(4, 28);
            this.tabImprumutate.Name = "tabImprumutate";
            this.tabImprumutate.Padding = new System.Windows.Forms.Padding(3);
            this.tabImprumutate.Size = new System.Drawing.Size(836, 324);
            this.tabImprumutate.TabIndex = 1;
            this.tabImprumutate.Text = "Carti Imprumutate";
            this.tabImprumutate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Titlu,
            this.Autor,
            this.DataImprumut,
            this.Data});
            this.dataGridView1.Location = new System.Drawing.Point(23, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // Titlu
            // 
            this.Titlu.HeaderText = "Titlu";
            this.Titlu.Name = "Titlu";
            this.Titlu.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // DataImprumut
            // 
            this.DataImprumut.HeaderText = "Data imprumut";
            this.DataImprumut.Name = "DataImprumut";
            this.DataImprumut.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data Disponibilitate";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
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
            this.tabImprumutate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDisponibile;
        private System.Windows.Forms.TabPage tabImprumutate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabStatistici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataImprumut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Label lblIesire;
    }
}