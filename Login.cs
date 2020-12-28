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
    public partial class Login : Form
    {
        int rowForUser=-1;
        public static Login login;
        public Login()
        {
            InitializeComponent();
            login = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medicincentreDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.medicincentreDataSet.users);
        }
        public void update() {
            this.usersTableAdapter.Fill(this.medicincentreDataSet.users);
        }
        //login
        private void button1_Click(object sender, EventArgs e)
        {
            tryLogin();
        }
        private void tryLogin() {
            if (!isFill()) {
                MessageBox.Show("Не заполнены поля для входа");
                return;
            }
            string login = textBox1.Text, pass = textBox2.Text;
            bool isHas = false;

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++) {
                if (dataGridView1[4, i].Value.ToString().Equals(login)
                    && dataGridView1[5, i].Value.ToString().Equals(pass)
                    && int.Parse(dataGridView1[6, i].Value.ToString()) == 2) {
                    rowForUser = i;
                    isHas = true;
                }
            }
            if (isHas)
            {
                MessageBox.Show("Вход успешен");
                new Menu().Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Такой пользователь не найден");
            }
        }
        private bool isFill() {
            if (textBox1.Text.Length < 1 || textBox2.Text.Length < 1)
                return false;
            return true;
        }
        //registration
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }
    }
}
