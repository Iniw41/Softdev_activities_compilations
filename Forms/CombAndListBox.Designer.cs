namespace Softdev_activities.Forms
{
    partial class CombAndListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            TestLabelComboBox = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Item 1", "Item  2", "Item 3", "Item4" });
            comboBox1.Location = new Point(121, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(281, 40);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // TestLabelComboBox
            // 
            TestLabelComboBox.AutoSize = true;
            TestLabelComboBox.Location = new Point(59, 121);
            TestLabelComboBox.Name = "TestLabelComboBox";
            TestLabelComboBox.Size = new Size(56, 15);
            TestLabelComboBox.TabIndex = 1;
            TestLabelComboBox.Text = "TestLabel";
            // 
            // CombAndListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TestLabelComboBox);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CombAndListBox";
            Text = "Combo and List Box";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label TestLabelComboBox;
    }
}