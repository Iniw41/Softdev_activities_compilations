using Softdev_activities.Forms;

namespace Softdev_activities

{
    public partial class MainWindow : Form
    {
        //Fields
        public Point mouseLocation;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private Panel panelContainer;


        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            
           
        }

        public Color SelectThemeCOlor()
        {

            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(27, 88, 134);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(27, 88, 134);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            //needed to be fixed chritst
            //this opens a child form very self explanatory
            //It opens a form on the dashboard rather than creating a new windowed form
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelDesktop.Controls.Add(childForm);
            this.PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            DashboardLabel.Text = childForm.Text;

        }



        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PaneLogo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Exit_Click_2(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {

        }

        private void Maximize_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ColorChanger_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Themes(), sender);
        }
        private void CalculatorButton_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.Calculator(), sender);
        }
        private void Act7Buttron_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void DashboardLabel_Click(object sender, EventArgs e)
        {

        }

        private void PanelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
