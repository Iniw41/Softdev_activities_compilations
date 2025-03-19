using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Softdev_activities.Forms;
using Softdev_activities;

namespace Softdev_activities.Forms
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Create the SQL database
        private void createDatabase()
        {
            string path = "C:\\Users\\User\\Desktop\\Softdev activities\\Softdev activities\\Softdev activities";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string age = textBox2.Text;
            if (is_input_lenght_valid(name) && is_input_lenght_valid(age))
            {
                this.Hide();
                MainWindow dashboard = new MainWindow();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private bool is_input_lenght_valid(string input)
        {
            return input.Length > 0;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
