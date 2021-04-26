using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KK3_Betamart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtCari.Text))
                {
                    this.barangTableAdapter.Fill(this.dataBarang.Barang);
                    barangBindingSource.DataSource = this.dataBarang.Barang;
                    // dataGridView.DataSource = barangBindingSource;
                }
                else
                {
                    var query = from o in this.dataBarang.Barang
                                where o.NamaBarang.Contains(txtCari.Text) || o.KodeBarang.Contains(txtCari.Text) || o.Satuan.Contains(txtCari.Text)
                                select o;
                    barangBindingSource.DataSource = query.ToList();
                    // dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                barangBindingSource.RemoveCurrent();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtKodeBarang.Focus();
                this.dataBarang.Barang.AddBarangRow(this.dataBarang.Barang.NewBarangRow());
                barangBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barangBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtKodeBarang.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            barangBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                barangBindingSource.EndEdit();
                barangTableAdapter.Update(this.dataBarang.Barang);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barangBindingSource.ResetBindings(false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBarang.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.dataBarang.Barang);
            barangBindingSource.DataSource = this.dataBarang.Barang;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            barangBindingSource.RemoveCurrent();
        }
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete all record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            // barangBindingSource.Remove(barangBindingSource.DataSource);
            this.dataBarang.Clear();
        }
    }
}
