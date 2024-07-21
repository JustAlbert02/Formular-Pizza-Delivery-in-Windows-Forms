namespace Proiect
{
    partial class Form1
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
            this.Titlu = new System.Windows.Forms.Label();
            this.lbNume = new System.Windows.Forms.Label();
            this.lbPrenume = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStrada = new System.Windows.Forms.TextBox();
            this.tbNr = new System.Windows.Forms.TextBox();
            this.tbBloc = new System.Windows.Forms.TextBox();
            this.tbApartament = new System.Windows.Forms.TextBox();
            this.tbEtaj = new System.Windows.Forms.TextBox();
            this.tbScara = new System.Windows.Forms.TextBox();
            this.btnAdaugarePizza = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbOptiuniPizza = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMarimiPizza = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnComenziAnterioare = new System.Windows.Forms.Button();
            this.btnFinalizare = new System.Windows.Forms.Button();
            this.dgvPizzeAlese = new System.Windows.Forms.DataGridView();
            this.numePizzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizzeAlese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlu
            // 
            this.Titlu.AutoSize = true;
            this.Titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Titlu.Location = new System.Drawing.Point(332, 9);
            this.Titlu.Name = "Titlu";
            this.Titlu.Size = new System.Drawing.Size(176, 24);
            this.Titlu.TabIndex = 0;
            this.Titlu.Text = "Introduce Comanda";
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(19, 85);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(35, 13);
            this.lbNume.TabIndex = 1;
            this.lbNume.Text = "Nume";
            // 
            // lbPrenume
            // 
            this.lbPrenume.AutoSize = true;
            this.lbPrenume.Location = new System.Drawing.Point(219, 88);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Size = new System.Drawing.Size(49, 13);
            this.lbPrenume.TabIndex = 2;
            this.lbPrenume.Text = "Prenume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(92, 84);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 20);
            this.tbNume.TabIndex = 3;
            this.tbNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stringTB_KeyPress);
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(285, 85);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(100, 20);
            this.tbPrenume.TabIndex = 4;
            this.tbPrenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stringTB_KeyPress);
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(16, 127);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(71, 13);
            this.lbTelefon.TabIndex = 5;
            this.lbTelefon.Text = "Telefon Mobil";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(92, 124);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(192, 20);
            this.tbTelefon.TabIndex = 6;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTB_KeyPress);
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbAdresa.Location = new System.Drawing.Point(16, 185);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(53, 17);
            this.lbAdresa.TabIndex = 7;
            this.lbAdresa.Text = "Adresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bloc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Etaj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Apartament";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Scara";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Strada";
            // 
            // tbStrada
            // 
            this.tbStrada.Location = new System.Drawing.Point(74, 217);
            this.tbStrada.Name = "tbStrada";
            this.tbStrada.Size = new System.Drawing.Size(323, 20);
            this.tbStrada.TabIndex = 14;
            this.tbStrada.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmpty_Validating);
            // 
            // tbNr
            // 
            this.tbNr.Location = new System.Drawing.Point(74, 248);
            this.tbNr.Name = "tbNr";
            this.tbNr.Size = new System.Drawing.Size(100, 20);
            this.tbNr.TabIndex = 15;
            this.tbNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTB_KeyPress);
            this.tbNr.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmpty_Validating);
            // 
            // tbBloc
            // 
            this.tbBloc.Location = new System.Drawing.Point(74, 287);
            this.tbBloc.Name = "tbBloc";
            this.tbBloc.Size = new System.Drawing.Size(101, 20);
            this.tbBloc.TabIndex = 16;
            this.tbBloc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTB_KeyPress);
            this.tbBloc.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmpty_Validating);
            // 
            // tbApartament
            // 
            this.tbApartament.Location = new System.Drawing.Point(297, 248);
            this.tbApartament.Name = "tbApartament";
            this.tbApartament.Size = new System.Drawing.Size(100, 20);
            this.tbApartament.TabIndex = 17;
            this.tbApartament.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTB_KeyPress);
            this.tbApartament.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmpty_Validating);
            // 
            // tbEtaj
            // 
            this.tbEtaj.Location = new System.Drawing.Point(297, 290);
            this.tbEtaj.Name = "tbEtaj";
            this.tbEtaj.Size = new System.Drawing.Size(100, 20);
            this.tbEtaj.TabIndex = 18;
            this.tbEtaj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTB_KeyPress);
            this.tbEtaj.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmpty_Validating);
            // 
            // tbScara
            // 
            this.tbScara.Location = new System.Drawing.Point(73, 321);
            this.tbScara.Name = "tbScara";
            this.tbScara.Size = new System.Drawing.Size(101, 20);
            this.tbScara.TabIndex = 19;
            this.tbScara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stringTB_KeyPress);
            this.tbScara.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmpty_Validating);
            // 
            // btnAdaugarePizza
            // 
            this.btnAdaugarePizza.Location = new System.Drawing.Point(491, 434);
            this.btnAdaugarePizza.Name = "btnAdaugarePizza";
            this.btnAdaugarePizza.Size = new System.Drawing.Size(330, 25);
            this.btnAdaugarePizza.TabIndex = 20;
            this.btnAdaugarePizza.Text = "Adauga Pizza";
            this.btnAdaugarePizza.UseVisualStyleBackColor = true;
            this.btnAdaugarePizza.Click += new System.EventHandler(this.btnAdaugarePizza_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(465, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Pizza";
            // 
            // cbOptiuniPizza
            // 
            this.cbOptiuniPizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOptiuniPizza.FormattingEnabled = true;
            this.cbOptiuniPizza.Items.AddRange(new object[] {
            "Margherita",
            "Quattro Stagioni",
            "Diavola",
            "Pepperoni",
            "Quatro Formaggi"});
            this.cbOptiuniPizza.Location = new System.Drawing.Point(511, 88);
            this.cbOptiuniPizza.Name = "cbOptiuniPizza";
            this.cbOptiuniPizza.Size = new System.Drawing.Size(91, 21);
            this.cbOptiuniPizza.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Optiuni";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(9, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Date Contact";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(632, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Marime";
            // 
            // cbMarimiPizza
            // 
            this.cbMarimiPizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarimiPizza.FormattingEnabled = true;
            this.cbMarimiPizza.Items.AddRange(new object[] {
            "Mica",
            "Medie",
            "Mare"});
            this.cbMarimiPizza.Location = new System.Drawing.Point(693, 88);
            this.cbMarimiPizza.Name = "cbMarimiPizza";
            this.cbMarimiPizza.Size = new System.Drawing.Size(91, 21);
            this.cbMarimiPizza.TabIndex = 27;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnComenziAnterioare
            // 
            this.btnComenziAnterioare.Location = new System.Drawing.Point(12, 434);
            this.btnComenziAnterioare.Name = "btnComenziAnterioare";
            this.btnComenziAnterioare.Size = new System.Drawing.Size(311, 59);
            this.btnComenziAnterioare.TabIndex = 29;
            this.btnComenziAnterioare.Text = "Comenzi Anterioare";
            this.btnComenziAnterioare.UseVisualStyleBackColor = true;
            this.btnComenziAnterioare.Click += new System.EventHandler(this.btnComenziAnterioare_Click);
            // 
            // btnFinalizare
            // 
            this.btnFinalizare.Location = new System.Drawing.Point(491, 468);
            this.btnFinalizare.Name = "btnFinalizare";
            this.btnFinalizare.Size = new System.Drawing.Size(330, 25);
            this.btnFinalizare.TabIndex = 31;
            this.btnFinalizare.Text = "Finalizare Comanda";
            this.btnFinalizare.UseVisualStyleBackColor = true;
            this.btnFinalizare.Click += new System.EventHandler(this.btnFinalizare_Click);
            // 
            // dgvPizzeAlese
            // 
            this.dgvPizzeAlese.AllowUserToAddRows = false;
            this.dgvPizzeAlese.AutoGenerateColumns = false;
            this.dgvPizzeAlese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPizzeAlese.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numePizzaDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.marimeDataGridViewTextBoxColumn});
            this.dgvPizzeAlese.DataSource = this.pizzaBindingSource1;
            this.dgvPizzeAlese.Location = new System.Drawing.Point(468, 185);
            this.dgvPizzeAlese.Name = "dgvPizzeAlese";
            this.dgvPizzeAlese.ReadOnly = true;
            this.dgvPizzeAlese.Size = new System.Drawing.Size(360, 199);
            this.dgvPizzeAlese.TabIndex = 32;
            // 
            // numePizzaDataGridViewTextBoxColumn
            // 
            this.numePizzaDataGridViewTextBoxColumn.DataPropertyName = "NumePizza";
            this.numePizzaDataGridViewTextBoxColumn.HeaderText = "NumePizza";
            this.numePizzaDataGridViewTextBoxColumn.Name = "numePizzaDataGridViewTextBoxColumn";
            this.numePizzaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numePizzaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marimeDataGridViewTextBoxColumn
            // 
            this.marimeDataGridViewTextBoxColumn.DataPropertyName = "Marime";
            this.marimeDataGridViewTextBoxColumn.HeaderText = "Marime";
            this.marimeDataGridViewTextBoxColumn.Name = "marimeDataGridViewTextBoxColumn";
            this.marimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.marimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pizzaBindingSource1
            // 
            this.pizzaBindingSource1.DataSource = typeof(Proiect.Pizza);
            // 
            // pizzaBindingSource
            // 
            this.pizzaBindingSource.DataSource = typeof(Proiect.Pizza);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(847, 505);
            this.Controls.Add(this.dgvPizzeAlese);
            this.Controls.Add(this.btnFinalizare);
            this.Controls.Add(this.btnComenziAnterioare);
            this.Controls.Add(this.cbMarimiPizza);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbOptiuniPizza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdaugarePizza);
            this.Controls.Add(this.tbScara);
            this.Controls.Add(this.tbEtaj);
            this.Controls.Add(this.tbApartament);
            this.Controls.Add(this.tbBloc);
            this.Controls.Add(this.tbNr);
            this.Controls.Add(this.tbStrada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAdresa);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.lbTelefon);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lbPrenume);
            this.Controls.Add(this.lbNume);
            this.Controls.Add(this.Titlu);
            this.Name = "Form1";
            this.Text = "Inregistrare Delivery";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizzeAlese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.Label lbPrenume;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource pizzaBindingSource;
        private System.Windows.Forms.BindingSource pizzaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePizzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marimeDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label Titlu;
        public System.Windows.Forms.TextBox tbNume;
        public System.Windows.Forms.TextBox tbPrenume;
        public System.Windows.Forms.TextBox tbTelefon;
        public System.Windows.Forms.TextBox tbStrada;
        public System.Windows.Forms.TextBox tbNr;
        public System.Windows.Forms.ComboBox cbOptiuniPizza;
        public System.Windows.Forms.ComboBox cbMarimiPizza;
        public System.Windows.Forms.TextBox tbBloc;
        public System.Windows.Forms.TextBox tbApartament;
        public System.Windows.Forms.TextBox tbEtaj;
        public System.Windows.Forms.TextBox tbScara;
        public System.Windows.Forms.Button btnAdaugarePizza;
        public System.Windows.Forms.Button btnFinalizare;
        public System.Windows.Forms.DataGridView dgvPizzeAlese;
        public System.Windows.Forms.Button btnComenziAnterioare;
    }
}

