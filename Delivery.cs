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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.warehouse". При необходимости она может быть перемещена или удалена.
            this.warehouseTableAdapter.Fill(this.medicincentreDataSet.warehouse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet1.warehouse". При необходимости она может быть перемещена или удалена.
            this.medicinTableAdapter.Fill(this.medicincentreDataSet.medicin);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.medicincentreDataSet.delivery);
            fixName();
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //калькулятор
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
                    DataRowView row = (DataRowView)deliveryBindingSource.AddNew();

                    row[1] = comboBox1.SelectedValue;
                    row[2] = dateTimePicker1.Value;
                    row[3] = int.Parse(textBox2.Text);

                    deliveryBindingSource.EndEdit();
                    this.deliveryTableAdapter.Update(medicincentreDataSet);
                    
                    tryToAddProductInWarehouse(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(textBox2.Text));

                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            this.deliveryTableAdapter.Fill(medicincentreDataSet.delivery);
            fixName();
        }

        private void tryToAddProductInWarehouse(int product, int count) {
            try
            {
                medicincentreDataSet.AcceptChanges();
                DataRowView row = (DataRowView)warehouseBindingSource.AddNew();
                row[1] = product;
                row[2] = count;
                
                warehouseBindingSource.EndEdit();
                this.warehouseTableAdapter.Update(medicincentreDataSet);
                this.warehouseTableAdapter.Fill(medicincentreDataSet.warehouse);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    if (int.Parse(dataGridView2[1, i].Value.ToString()) == product)
                    {
                        medicincentreDataSet.AcceptChanges();
                        dataGridView2[2, i].Value = int.Parse(dataGridView2[2, i].Value.ToString()) + count;
                        this.warehouseTableAdapter.Update(((DataRowView)dataGridView2.Rows[i].DataBoundItem).Row);
                        warehouseBindingSource.EndEdit();
                        this.warehouseTableAdapter.Fill(medicincentreDataSet.warehouse);
                        return;
                    }
                }

            }


        }
        //edit
        private void button2_Click(object sender, EventArgs e)
        {

            if (isFill())
                try
                {
                    int currentCount = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    int currentId = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());

                    int newCount= int.Parse(textBox2.Text);
                    int newId = int.Parse(comboBox1.SelectedValue.ToString());

                    dataGridView1.CurrentRow.Cells[1].Value = comboBox1.SelectedValue;
                    dataGridView1.CurrentRow.Cells[2].Value = dateTimePicker1.Value;
                    dataGridView1.CurrentRow.Cells[3].Value = comboBox1.Text;
                    dataGridView1.CurrentRow.Cells[4].Value = int.Parse(textBox2.Text);
                    deliveryBindingSource.EndEdit();
                    this.deliveryTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);

                    tryToAddProductInWarehouse(currentId, -currentCount);
                    tryToAddProductInWarehouse(newId,newCount);
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            this.deliveryTableAdapter.Fill(medicincentreDataSet.delivery);
            fixName();
        }

        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                try
                {
                    int count = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    int product = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    medicincentreDataSet.AcceptChanges();
                    deliveryBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    deliveryBindingSource.EndEdit();
                    deliveryTableAdapter.Update(medicincentreDataSet.delivery);
                    tryToAddProductInWarehouse( product, -count);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.deliveryTableAdapter.Fill(medicincentreDataSet.delivery);
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
                textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            }
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

        private void Delivery_FormClosing(object sender, FormClosingEventArgs e)
        {
            MedicinCentre.Menu.menu.Show();
        }
    }
}
