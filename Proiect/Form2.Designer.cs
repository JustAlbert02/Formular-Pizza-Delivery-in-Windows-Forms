namespace Proiect
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLogComenzi = new System.Windows.Forms.DataGridView();
            this.btnEditareComanda = new System.Windows.Forms.Button();
            this.btnStergereComanda = new System.Windows.Forms.Button();
            this.btnVeziPizze = new System.Windows.Forms.Button();
            this.btnInchidere = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogComenzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log Comenzi";
            // 
            // dgvLogComenzi
            // 
            this.dgvLogComenzi.AllowUserToAddRows = false;
            this.dgvLogComenzi.AllowUserToDeleteRows = false;
            this.dgvLogComenzi.AutoGenerateColumns = false;
            this.dgvLogComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogComenzi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresaClientDataGridViewTextBoxColumn});
            this.dgvLogComenzi.DataSource = this.clientBindingSource;
            this.dgvLogComenzi.Location = new System.Drawing.Point(34, 62);
            this.dgvLogComenzi.Name = "dgvLogComenzi";
            this.dgvLogComenzi.ReadOnly = true;
            this.dgvLogComenzi.Size = new System.Drawing.Size(700, 268);
            this.dgvLogComenzi.TabIndex = 1;
            // 
            // btnEditareComanda
            // 
            this.btnEditareComanda.Location = new System.Drawing.Point(533, 370);
            this.btnEditareComanda.Name = "btnEditareComanda";
            this.btnEditareComanda.Size = new System.Drawing.Size(201, 56);
            this.btnEditareComanda.TabIndex = 2;
            this.btnEditareComanda.Text = "Editeaza Comanda";
            this.btnEditareComanda.UseVisualStyleBackColor = true;
            this.btnEditareComanda.Click += new System.EventHandler(this.btnEditareComanda_Click);
            // 
            // btnStergereComanda
            // 
            this.btnStergereComanda.Location = new System.Drawing.Point(34, 370);
            this.btnStergereComanda.Name = "btnStergereComanda";
            this.btnStergereComanda.Size = new System.Drawing.Size(201, 56);
            this.btnStergereComanda.TabIndex = 3;
            this.btnStergereComanda.Text = "Sterge Comanda";
            this.btnStergereComanda.UseVisualStyleBackColor = true;
            this.btnStergereComanda.Click += new System.EventHandler(this.btnStergereComanda_Click);
            // 
            // btnVeziPizze
            // 
            this.btnVeziPizze.Location = new System.Drawing.Point(299, 370);
            this.btnVeziPizze.Name = "btnVeziPizze";
            this.btnVeziPizze.Size = new System.Drawing.Size(174, 23);
            this.btnVeziPizze.TabIndex = 4;
            this.btnVeziPizze.Text = "Vezi Pizze Comanda";
            this.btnVeziPizze.UseVisualStyleBackColor = true;
            this.btnVeziPizze.Click += new System.EventHandler(this.btnVeziPizze_Click);
            // 
            // btnInchidere
            // 
            this.btnInchidere.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInchidere.Location = new System.Drawing.Point(299, 402);
            this.btnInchidere.Name = "btnInchidere";
            this.btnInchidere.Size = new System.Drawing.Size(174, 23);
            this.btnInchidere.TabIndex = 5;
            this.btnInchidere.Text = "Inchide Fereastra";
            this.btnInchidere.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaClientDataGridViewTextBoxColumn
            // 
            this.adresaClientDataGridViewTextBoxColumn.DataPropertyName = "AdresaClient";
            this.adresaClientDataGridViewTextBoxColumn.HeaderText = "AdresaClient";
            this.adresaClientDataGridViewTextBoxColumn.Name = "adresaClientDataGridViewTextBoxColumn";
            this.adresaClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresaClientDataGridViewTextBoxColumn.Width = 250;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(Proiect.Client);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInchidere);
            this.Controls.Add(this.btnVeziPizze);
            this.Controls.Add(this.btnStergereComanda);
            this.Controls.Add(this.btnEditareComanda);
            this.Controls.Add(this.dgvLogComenzi);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogComenzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLogComenzi;
        private System.Windows.Forms.Button btnEditareComanda;
        private System.Windows.Forms.Button btnStergereComanda;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Button btnVeziPizze;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnInchidere;
    }
}