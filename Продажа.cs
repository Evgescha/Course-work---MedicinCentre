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
    public partial class Продажа : Form
    {
        public Продажа()
        {
            InitializeComponent();
        }

        private void Продажа_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.medicin". При необходимости она может быть перемещена или удалена.
            this.medicinTableAdapter.Fill(this.medicincentreDataSet.medicin);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.medicincentreDataSet.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.sell". При необходимости она может быть перемещена или удалена.
            this.sellTableAdapter.Fill(this.medicincentreDataSet.sell);
            textBox1.Text = Login.idUser+"";
            fixName();
            this.Text = "Вы вошли как: " + Login.fio;
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
            if (textBox2.Text.Length < 1)
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
                    DataRowView row = (DataRowView)sellBindingSource.AddNew();

                    row[1] = int.Parse(textBox1.Text);
                    row[2] = comboBox2.SelectedValue;
                    row[3] = comboBox3.SelectedValue;
                    row[4] = dateTimePicker1.Value;
                    row[5] = int.Parse(textBox2.Text);

                    sellBindingSource.EndEdit();
                    this.sellTableAdapter.Update(medicincentreDataSet);
                                        

                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            this.sellTableAdapter.Fill(medicincentreDataSet.sell);
            fixName();
        }

        //edit
        private void button2_Click(object sender, EventArgs e)
        {

            if (isFill())
                try
                {
                    dataGridView1.CurrentRow.Cells[1].Value = int.Parse(textBox1.Text);
                    dataGridView1.CurrentRow.Cells[2].Value = comboBox2.SelectedValue;
                    dataGridView1.CurrentRow.Cells[3].Value = comboBox3.SelectedValue;
                    dataGridView1.CurrentRow.Cells[4].Value = dateTimePicker1.Value;
                    dataGridView1.CurrentRow.Cells[5].Value = int.Parse(textBox2.Text);
                    sellBindingSource.EndEdit();
                    this.sellTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);

                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            this.sellTableAdapter.Fill(medicincentreDataSet.sell);
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
                    sellBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    sellBindingSource.EndEdit();
                    sellTableAdapter.Update(medicincentreDataSet.sell);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.sellTableAdapter.Fill(medicincentreDataSet.sell);
                fixName();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
              

                comboBox2.SelectedItem = comboBox2.Items[
                                                           medicinBindingSource.Find(
                                                                       "id",
                                                                        int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString())
                                                                       )
                                                           ];
                comboBox3.SelectedItem = comboBox3.Items[
                                                           medicinBindingSource.Find(
                                                                       "id",
                                                                        int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString())
                                                                       )
                                                           ];
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                textBox2.Text =dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }


        private void fixName()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
               

                comboBox2.SelectedItem = comboBox2.Items[
                                                           usersBindingSource.Find(
                                                                       "id",
                                                                       int.Parse(dataGridView1[1, i].Value.ToString())
                                                                       )
                                                           ];
                dataGridView1[6, i].Value = comboBox2.Text;

                comboBox2.SelectedItem = comboBox2.Items[
                                                         usersBindingSource.Find(
                                                                     "id",
                                                                     int.Parse(dataGridView1[2, i].Value.ToString())
                                                                     )
                                                         ];
                dataGridView1[7, i].Value = comboBox2.Text;

                comboBox3.SelectedItem = comboBox3.Items[
                                                           medicinBindingSource.Find(
                                                                       "id",
                                                                       int.Parse(dataGridView1[3, i].Value.ToString())
                                                                       )
                                                           ];
                dataGridView1[8, i].Value = comboBox3.Text;

            }
        }

        private void Продажа_FormClosing(object sender, FormClosingEventArgs e)
        {
            MedicinCentre.Menu.menu.Show();
        }
        //мои продажи
        private void button4_Click(object sender, EventArgs e)
        {

            this.sellTableAdapter.FillByIdWhoSell(medicincentreDataSet.sell, Login.idUser);
            fixName();
        }
        //выбранный сотрудник
        private void button5_Click(object sender, EventArgs e)
        {
            this.sellTableAdapter.FillByIdWhoSell(medicincentreDataSet.sell, int.Parse(comboBox2.SelectedValue.ToString()));
            fixName();
        }
        //сброс
        private void button6_Click(object sender, EventArgs e)
        {
            this.sellTableAdapter.Fill(medicincentreDataSet.sell);
            fixName();
        }
    }
}
