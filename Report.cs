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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            MedicinCentre.Menu.menu.Show();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.medicin". При необходимости она может быть перемещена или удалена.
            this.medicinTableAdapter.Fill(this.medicincentreDataSet.medicin);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.medicincentreDataSet.users);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = comboBox2.Text;
            this.sellTableAdapter.FillByIdWhoSell(medicincentreDataSet.sell, int.Parse(comboBox2.SelectedValue.ToString()));
            fixName();
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
    
        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = comboBox3.Text;
            this.sellTableAdapter.FillByWhatBUY(medicincentreDataSet.sell, int.Parse(comboBox3.SelectedValue.ToString()));
            fixName();
        }
    }
}
