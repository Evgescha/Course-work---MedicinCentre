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
    public partial class Menu : Form
    {
        public static Menu menu;
        public Menu()
        {
            InitializeComponent();
            menu = this;
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }
        //close window
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.login.Show();
        }
        //medicin
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Medicin().Show();
        }

        //warehouse
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Warehouse().Show();
        }
        //delivery
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Delivery().Show();
        }
        //client
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Client().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Продажа().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        //reports
        private void button7_Click(object sender, EventArgs e)
        {
            new Report().Show();
            this.Hide();
        }
    }
}
