﻿using System;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.warehouse". При необходимости она может быть перемещена или удалена.
            this.warehouseTableAdapter.Fill(this.medicincentreDataSet.warehouse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.medicin". При необходимости она может быть перемещена или удалена.
            this.medicinTableAdapter.FillBy(this.medicincentreDataSet.medicin);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.FillByOnlyClient(this.medicincentreDataSet.users);
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
                    tryToAddProductInWarehouse(int.Parse(comboBox3.SelectedValue.ToString()), int.Parse("-"+textBox2.Text));

                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            this.sellTableAdapter.Fill(medicincentreDataSet.sell);
            fixName();
        }

        private void tryToAddProductInWarehouse(int product, int count)
        {
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
                    int currentCount = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    int currentId = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

                    int newCount = int.Parse(textBox2.Text);
                    int newId = int.Parse(comboBox3.SelectedValue.ToString());

                    dataGridView1.CurrentRow.Cells[1].Value = int.Parse(textBox1.Text);
                    dataGridView1.CurrentRow.Cells[2].Value = comboBox2.SelectedValue;
                    dataGridView1.CurrentRow.Cells[3].Value = comboBox3.SelectedValue;
                    dataGridView1.CurrentRow.Cells[4].Value = dateTimePicker1.Value;
                    dataGridView1.CurrentRow.Cells[5].Value = int.Parse(textBox2.Text);
                    sellBindingSource.EndEdit();
                    this.sellTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                    tryToAddProductInWarehouse(currentId, currentCount);
                    tryToAddProductInWarehouse(newId, -newCount);
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
                    int currentCount = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    int currentId = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

                    tryToAddProductInWarehouse(currentId, currentCount);
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
            this.medicinTableAdapter.Fill(this.medicincentreDataSet.medicin);
            this.usersTableAdapter.Fill(this.medicincentreDataSet.users);
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
            this.medicinTableAdapter.FillBy(this.medicincentreDataSet.medicin);
            this.usersTableAdapter.FillByOnlyClient(this.medicincentreDataSet.users);
        }


        private void fixName()
        {
            this.medicinTableAdapter.Fill(this.medicincentreDataSet.medicin);
            this.usersTableAdapter.Fill(this.medicincentreDataSet.users);
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
            this.medicinTableAdapter.FillBy(this.medicincentreDataSet.medicin);
            this.usersTableAdapter.FillByOnlyClient(this.medicincentreDataSet.users);
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
