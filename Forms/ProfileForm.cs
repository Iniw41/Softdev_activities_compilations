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
using MySql.Data.MySqlClient;


namespace Softdev_activities.Forms
{
    public partial class ProfileForm : Form
    {
        private string name;
        private int age;

        public ProfileForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

//       public void GetUserInfo(DatabaseHelper db)
//       {
//           int userId = db.GetNextUserId();
//           string formattedUserId = userId.ToString("D8");
//
//           name = textBox1.Text;
//           string Age = textBox2.Text;
//           Int32.TryParse(Age, out int ageInt);
//           age = ageInt;
//
//            db.InsertUser(userId, name, age);
//            SaveUserToFile(userId, name, age);
//        }

        //The enter button for the user to enter the dashboard
        private void button1_Click(object sender, EventArgs e)
        {
            //will this work?
            //DatabaseHelper db = new DatabaseHelper();
            //GetUserInfo(db);

            name = textBox1.Text;
            string Age = textBox2.Text;
            Int32.TryParse(Age, out int ageInt);
            age = ageInt;

            if (is_input_lenght_valid(name) && is_input_lenght_valid(age.ToString()))
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
        private void SaveUserToFile(int userId, string name, int age)
        {
            string userDirectory = @"C:\Users\User 103\source\repos\Softdev_activities-2\Softdev_activities-2\DB";
            if (!Directory.Exists(userDirectory))
            {
                Directory.CreateDirectory(userDirectory);
            }

            string filePath = Path.Combine(userDirectory, $"{userId:D8}.txt");
            string fileContent = $"User ID: {userId:D8}\nName: {name}\nAge: {age}\nCreated On: {DateTime.Now}";

            File.WriteAllText(filePath, fileContent);
            Console.WriteLine($"User details saved in: {filePath}");
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
