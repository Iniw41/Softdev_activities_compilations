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
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TestLabelComboBox.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
