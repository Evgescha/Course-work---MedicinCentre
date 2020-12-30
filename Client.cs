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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.FillByOnlyClient(this.medicincentreDataSet.users);

        }
        private bool isFill()
        {
            if (textBox1.Text.Length < 1
                || textBox2.Text.Length < 1
                || textBox3.Text.Length < 1
                //|| textBox4.Text.Length < 1
                //|| textBox5.Text.Length < 1
                )
                return false;
            return true;
        }
        private void clearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            //textBox4.Text = "";
            //textBox5.Text = "";
        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            if (isFill())
                try
                {
                    DataRowView row = (DataRowView)usersBindingSource.AddNew();

                    row[1] = textBox1.Text;
                    row[2] = textBox2.Text;
                    row[3] = textBox3.Text;
                    row[4] = textBox4.Text;
                    row[5] = textBox5.Text;
                    row[6] = 1;

                    usersBindingSource.EndEdit();
                    this.usersTableAdapter.Update(medicincentreDataSet);
                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            this.usersTableAdapter.FillByOnlyClient(medicincentreDataSet.users);

        }
        //edit
        private void button2_Click(object sender, EventArgs e)
        {
            if (isFill())
                try
                {
                    dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
                    dataGridView1.CurrentRow.Cells[2].Value = textBox2.Text;
                    dataGridView1.CurrentRow.Cells[3].Value = textBox3.Text;
                    dataGridView1.CurrentRow.Cells[4].Value = textBox4.Text;
                    dataGridView1.CurrentRow.Cells[5].Value = textBox5.Text;
                    usersBindingSource.EndEdit();
                    this.usersTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);

                    clearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            this.usersTableAdapter.FillByOnlyClient(medicincentreDataSet.users);
        }

        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                try
                {
                    medicincentreDataSet.AcceptChanges();
                    usersBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    usersBindingSource.EndEdit();
                    usersTableAdapter.Update(medicincentreDataSet.users);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.usersTableAdapter.FillByOnlyClient(medicincentreDataSet.users);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            MedicinCentre.Menu.menu.Show();
        }
    }
}
