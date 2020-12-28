using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicinCentre
{
    public partial class Medicin : Form
    {
        public Medicin()
        {
            InitializeComponent();
        }

        private void Medicin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.medicin". При необходимости она может быть перемещена или удалена.
            this.medicinTableAdapter.Fill(this.medicincentreDataSet.medicin);

        }

        private bool isFill()
        {
            if (textBox1.Text.Length < 1
                || textBox2.Text.Length < 1)
                return false;
            return true;
        }
        private void clearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            if (isFill())
                try
                {
                    DataRowView row = (DataRowView)medicinBindingSource.AddNew();

                    row[1] = textBox1.Text;
                    row[2] = textBox2.Text;

                    medicinBindingSource.EndEdit();
                    this.medicinTableAdapter.Update(medicincentreDataSet);
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            this.medicinTableAdapter.Fill(medicincentreDataSet.medicin);

        }
        //edit
        private void button2_Click(object sender, EventArgs e)
        {
            if (isFill())
                try
                {
                    dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
                    dataGridView1.CurrentRow.Cells[2].Value = textBox2.Text;
                    medicinBindingSource.EndEdit();
                    this.medicinTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);

                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            this.medicinTableAdapter.Fill(medicincentreDataSet.medicin);
        }

        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                try
                {
                    medicincentreDataSet.AcceptChanges();
                    medicinBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    medicinBindingSource.EndEdit();
                    medicinTableAdapter.Update(medicincentreDataSet.medicin);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.medicinTableAdapter.Fill(medicincentreDataSet.medicin);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null) {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void Medicin_FormClosing(object sender, FormClosingEventArgs e)
        {
            MedicinCentre.Menu.menu.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
