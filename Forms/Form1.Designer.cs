namespace Softdev_activities
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            Act7Buttron = new Button();
            CalculatorButton = new Button();
            ColorChanger = new Button();
            PaneLogo = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            UserName = new Label();
            panel1 = new Panel();
            DashboardLabel = new Label();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            PanelDesktop = new Panel();
            panelMenu.SuspendLayout();
            PaneLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(27, 88, 134);
            panelMenu.Controls.Add(Act7Buttron);
            panelMenu.Controls.Add(CalculatorButton);
            panelMenu.Controls.Add(ColorChanger);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 132);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 619);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // Act7Buttron
            // 
            Act7Buttron.Dock = DockStyle.Top;
            Act7Buttron.FlatAppearance.BorderSize = 0;
            Act7Buttron.FlatStyle = FlatStyle.Flat;
            Act7Buttron.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Act7Buttron.ForeColor = Color.FromArgb(224, 224, 224);
            Act7Buttron.Image = Properties.Resources.chekboxIcon1;
            Act7Buttron.ImageAlign = ContentAlignment.MiddleLeft;
            Act7Buttron.Location = new Point(0, 150);
            Act7Buttron.Name = "Act7Buttron";
            Act7Buttron.Padding = new Padding(12, 0, 0, 0);
            Act7Buttron.Size = new Size(250, 75);
            Act7Buttron.TabIndex = 2;
            Act7Buttron.Text = "Activity 7";
            Act7Buttron.TextImageRelation = TextImageRelation.ImageBeforeText;
            Act7Buttron.UseVisualStyleBackColor = true;
            Act7Buttron.Click += Act7Buttron_Click;
            // 
            // CalculatorButton
            // 
            CalculatorButton.Dock = DockStyle.Top;
            CalculatorButton.FlatAppearance.BorderSize = 0;
            CalculatorButton.FlatStyle = FlatStyle.Flat;
            CalculatorButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CalculatorButton.ForeColor = Color.FromArgb(224, 224, 224);
            CalculatorButton.Image = Properties.Resources.CalcIcon;
            CalculatorButton.ImageAlign = ContentAlignment.MiddleLeft;
            CalculatorButton.Location = new Point(0, 75);
            CalculatorButton.Name = "CalculatorButton";
            CalculatorButton.Padding = new Padding(12, 0, 0, 0);
            CalculatorButton.Size = new Size(250, 75);
            CalculatorButton.TabIndex = 1;
            CalculatorButton.Text = "Calculator";
            CalculatorButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CalculatorButton.UseVisualStyleBackColor = true;
            CalculatorButton.Click += CalculatorButton_Click;
            // 
            // ColorChanger
            // 
            ColorChanger.Dock = DockStyle.Top;
            ColorChanger.FlatAppearance.BorderSize = 0;
            ColorChanger.FlatStyle = FlatStyle.Flat;
            ColorChanger.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ColorChanger.ForeColor = Color.FromArgb(224, 224, 224);
            ColorChanger.Image = Properties.Resources.BgChangerIconIcon;
            ColorChanger.ImageAlign = ContentAlignment.MiddleLeft;
            ColorChanger.Location = new Point(0, 0);
            ColorChanger.Name = "ColorChanger";
            ColorChanger.Padding = new Padding(12, 0, 0, 0);
            ColorChanger.Size = new Size(250, 75);
            ColorChanger.TabIndex = 0;
            ColorChanger.Text = "Themes";
            ColorChanger.TextImageRelation = TextImageRelation.ImageBeforeText;
            ColorChanger.UseVisualStyleBackColor = true;
            ColorChanger.Click += ColorChanger_Click;
            // 
            // PaneLogo
            // 
            PaneLogo.BackColor = Color.FromArgb(0, 58, 107);
            PaneLogo.Controls.Add(pictureBox2);
            PaneLogo.Dock = DockStyle.Left;
            PaneLogo.Location = new Point(0, 0);
            PaneLogo.Name = "PaneLogo";
            PaneLogo.Size = new Size(250, 132);
            PaneLogo.TabIndex = 0;
            PaneLogo.Paint += PaneLogo_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 58, 107);
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.Logo;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.Profile;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(1295, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 132);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Dock = DockStyle.Right;
            UserName.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold);
            UserName.ForeColor = SystemColors.ButtonHighlight;
            UserName.Location = new Point(1224, 0);
            UserName.Name = "UserName";
            UserName.Size = new Size(71, 26);
            UserName.TabIndex = 1;
            UserName.Text = "Profile";
            UserName.TextAlign = ContentAlignment.MiddleCenter;
            UserName.Click += UserName_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 118, 161);
            panel1.Controls.Add(DashboardLabel);
            panel1.Controls.Add(PaneLogo);
            panel1.Controls.Add(UserName);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1359, 132);
            panel1.TabIndex = 1;
            // 
            // DashboardLabel
            // 
            DashboardLabel.Anchor = AnchorStyles.Left;
            DashboardLabel.AutoSize = true;
            DashboardLabel.Font = new Font("Swis721 Blk BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DashboardLabel.ForeColor = SystemColors.ButtonFace;
            DashboardLabel.Location = new Point(250, 75);
            DashboardLabel.Name = "DashboardLabel";
            DashboardLabel.Size = new Size(309, 57);
            DashboardLabel.TabIndex = 2;
            DashboardLabel.Text = "Dashboard";
            DashboardLabel.Click += DashboardLabel_Click;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // PanelDesktop
            // 
            PanelDesktop.BackColor = Color.White;
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(250, 132);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(1109, 619);
            PanelDesktop.TabIndex = 2;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(110, 177, 214);
            ClientSize = new Size(1359, 751);
            Controls.Add(PanelDesktop);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Activities";
            Load += MainWindow_Load;
            panelMenu.ResumeLayout(false);
            PaneLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Button ColorChanger;
        private Panel PaneLogo;
        private PictureBox pictureBox1;
        private Label UserName;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button Act7Buttron;
        private Button CalculatorButton;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Label DashboardLabel;
        private Panel PanelDesktop;
    }
}
