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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.medicincentreDataSet.users);

        }

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
                    row[6] = 2;

                    usersBindingSource.EndEdit();
                    this.usersTableAdapter.Update(medicincentreDataSet);
                    MessageBox.Show("Регистрация прошла успешна");
                    Login.login.update();
                    Login.login.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            this.usersTableAdapter.Fill(medicincentreDataSet.users);

        }
        private bool isFill()
        {
            if (textBox1.Text.Length < 1
                || textBox2.Text.Length < 1
                || textBox3.Text.Length < 1
                || textBox4.Text.Length < 1
                || textBox5.Text.Length < 1
                )
                return false;
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            back();
        }
        private void back() {
                Login.login.Show();
            this.Close();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.login.Show();
        }
    }
}
