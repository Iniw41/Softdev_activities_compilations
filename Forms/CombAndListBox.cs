using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softdev_activities.Forms
{
    public partial class CombAndListBox : Form
    {
        public CombAndListBox()
        {
            InitializeComponent();
            AddItemByUser.KeyDown += new KeyEventHandler(AddItemByUser_KeyDown);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TestLabelComboBox.Text = comboBox1.SelectedItem.ToString();
        }

        private void AddItemByUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItemByUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Items.Add(AddItemByUser.Text);
                AddItemByUser.Clear();
                e.SuppressKeyPress = true; // To prevent the 'ding' sound
            }
        }
    }
}
