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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.medicin". При необходимости она может быть перемещена или удалена.
            this.medicinTableAdapter.Fill(this.medicincentreDataSet.medicin);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.warehouse". При необходимости она может быть перемещена или удалена.
            this.warehouseTableAdapter.Fill(this.medicincentreDataSet.warehouse);
            fixName();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private bool isFill()
        {
            if (comboBox1.Items.Count < 1
                || textBox2.Text.Length < 1)
                return false;
            return true;
        }
        private void clearFields()
        {
            textBox2.Text = "";
        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            if (isFill())
                try
                {
                    DataRowView row = (DataRowView)warehouseBindingSource.AddNew();

                    row[1] = comboBox1.SelectedValue;
                    row[2] = textBox2.Text;

                    warehouseBindingSource.EndEdit();
                    this.warehouseTableAdapter.Update(medicincentreDataSet);
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            this.warehouseTableAdapter.Fill(medicincentreDataSet.warehouse);
            fixName();
        }
        //edit
        private void button2_Click(object sender, EventArgs e)
        {
            if (isFill())
                try
                {
                    dataGridView1.CurrentRow.Cells[1].Value = comboBox1.SelectedValue;
                    dataGridView1.CurrentRow.Cells[2].Value = textBox2.Text;
                    warehouseBindingSource.EndEdit();
                    this.warehouseTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);

                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            this.warehouseTableAdapter.Fill(medicincentreDataSet.warehouse);
            fixName();
        }

        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                try
                {
                    medicincentreDataSet.AcceptChanges();
                    warehouseBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    warehouseBindingSource.EndEdit();
                    warehouseTableAdapter.Update(medicincentreDataSet.warehouse);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.warehouseTableAdapter.Fill(medicincentreDataSet.warehouse);
                fixName();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                comboBox1.SelectedItem = comboBox1.Items[
                                                           medicinBindingSource.Find(
                                                                       "id",
                                                                       int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())
                                                                       )
                                                           ];
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void Medicin_FormClosing(object sender, FormClosingEventArgs e)
        {
            MedicinCentre.Menu.menu.Show();
        }

        private void Warehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            MedicinCentre.Menu.menu.Show();
        }

        private void fixName()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                comboBox1.SelectedItem = comboBox1.Items[
                                                           medicinBindingSource.Find(
                                                                       "id",
                                                                       int.Parse(dataGridView1[1, i].Value.ToString())
                                                                       )
                                                           ];
                dataGridView1[3, i].Value = comboBox1.Text;
            }
        }
    }
}
