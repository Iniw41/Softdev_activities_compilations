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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Item 1", "Item  2", "Item 3", "Item4" });
            comboBox1.Location = new Point(96, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(281, 40);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // TestLabelComboBox
            // 
            TestLabelComboBox.AutoSize = true;
            TestLabelComboBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TestLabelComboBox.Location = new Point(572, 50);
            TestLabelComboBox.Name = "TestLabelComboBox";
            TestLabelComboBox.Size = new Size(112, 32);
            TestLabelComboBox.TabIndex = 1;
            TestLabelComboBox.Text = "TestLabel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(457, 50);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 2;
            label1.Text = "Output:  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 50);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 3;
            label2.Text = "Input:";
            // 
            // CombAndListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
    }
}