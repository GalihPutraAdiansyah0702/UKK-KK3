namespace KK3_Betamart
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
            this.panel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtJumlahBarang = new System.Windows.Forms.TextBox();
            this.txtHargaBeli = new System.Windows.Forms.TextBox();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.txtSatuan = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataBarang = new KK3_Betamart.DataBarang();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter = new KK3_Betamart.DataBarangTableAdapters.BarangTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaJualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtSatuan);
            this.panel.Controls.Add(this.txtHargaJual);
            this.panel.Controls.Add(this.txtHargaBeli);
            this.panel.Controls.Add(this.txtJumlahBarang);
            this.panel.Controls.Add(this.txtNamaBarang);
            this.panel.Controls.Add(this.txtKodeBarang);
            this.panel.Controls.Add(this.label1);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1010, 219);
            this.panel.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.kodeBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.jumlahBarangDataGridViewTextBoxColumn,
            this.hargaBeliDataGridViewTextBoxColumn,
            this.hargaJualDataGridViewTextBoxColumn,
            this.satuanDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.barangBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 273);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1010, 220);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang :";
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "KodeBarang", true));
            this.txtKodeBarang.Location = new System.Drawing.Point(187, 24);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(301, 22);
            this.txtKodeBarang.TabIndex = 0;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "NamaBarang", true));
            this.txtNamaBarang.Location = new System.Drawing.Point(187, 94);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(301, 22);
            this.txtNamaBarang.TabIndex = 1;
            // 
            // txtJumlahBarang
            // 
            this.txtJumlahBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "JumlahBarang", true));
            this.txtJumlahBarang.Location = new System.Drawing.Point(187, 169);
            this.txtJumlahBarang.Name = "txtJumlahBarang";
            this.txtJumlahBarang.Size = new System.Drawing.Size(301, 22);
            this.txtJumlahBarang.TabIndex = 2;
            // 
            // txtHargaBeli
            // 
            this.txtHargaBeli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "HargaBeli", true));
            this.txtHargaBeli.Location = new System.Drawing.Point(674, 24);
            this.txtHargaBeli.Name = "txtHargaBeli";
            this.txtHargaBeli.Size = new System.Drawing.Size(310, 22);
            this.txtHargaBeli.TabIndex = 3;
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "HargaJual", true));
            this.txtHargaJual.Location = new System.Drawing.Point(674, 94);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(310, 22);
            this.txtHargaJual.TabIndex = 4;
            // 
            // txtSatuan
            // 
            this.txtSatuan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Satuan", true));
            this.txtSatuan.Location = new System.Drawing.Point(674, 169);
            this.txtSatuan.Name = "txtSatuan";
            this.txtSatuan.Size = new System.Drawing.Size(310, 22);
            this.txtSatuan.TabIndex = 5;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(112, 241);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(910, 22);
            this.txtCari.TabIndex = 0;
            this.txtCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCari_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama Barang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jumlah Barang :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Harga Beli :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Harga Jual :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Satuan :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cari :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(947, 499);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(866, 499);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(785, 499);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(704, 499);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(623, 499);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataBarang
            // 
            this.dataBarang.DataSetName = "DataBarang";
            this.dataBarang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.dataBarang;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // kodeBarangDataGridViewTextBoxColumn
            // 
            this.kodeBarangDataGridViewTextBoxColumn.DataPropertyName = "KodeBarang";
            this.kodeBarangDataGridViewTextBoxColumn.HeaderText = "KodeBarang";
            this.kodeBarangDataGridViewTextBoxColumn.Name = "kodeBarangDataGridViewTextBoxColumn";
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            // 
            // jumlahBarangDataGridViewTextBoxColumn
            // 
            this.jumlahBarangDataGridViewTextBoxColumn.DataPropertyName = "JumlahBarang";
            this.jumlahBarangDataGridViewTextBoxColumn.HeaderText = "JumlahBarang";
            this.jumlahBarangDataGridViewTextBoxColumn.Name = "jumlahBarangDataGridViewTextBoxColumn";
            // 
            // hargaBeliDataGridViewTextBoxColumn
            // 
            this.hargaBeliDataGridViewTextBoxColumn.DataPropertyName = "HargaBeli";
            this.hargaBeliDataGridViewTextBoxColumn.HeaderText = "HargaBeli";
            this.hargaBeliDataGridViewTextBoxColumn.Name = "hargaBeliDataGridViewTextBoxColumn";
            // 
            // hargaJualDataGridViewTextBoxColumn
            // 
            this.hargaJualDataGridViewTextBoxColumn.DataPropertyName = "HargaJual";
            this.hargaJualDataGridViewTextBoxColumn.HeaderText = "HargaJual";
            this.hargaJualDataGridViewTextBoxColumn.Name = "hargaJualDataGridViewTextBoxColumn";
            // 
            // satuanDataGridViewTextBoxColumn
            // 
            this.satuanDataGridViewTextBoxColumn.DataPropertyName = "Satuan";
            this.satuanDataGridViewTextBoxColumn.HeaderText = "Satuan";
            this.satuanDataGridViewTextBoxColumn.Name = "satuanDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 532);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beta-Mart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatuan;
        private System.Windows.Forms.TextBox txtHargaJual;
        private System.Windows.Forms.TextBox txtHargaBeli;
        private System.Windows.Forms.TextBox txtJumlahBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private DataBarang dataBarang;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private DataBarangTableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaJualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuanDataGridViewTextBoxColumn;
    }
}

