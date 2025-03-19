namespace Softdev_activities.Forms;

partial class Act7
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
        sidepanel = new Panel();
        label2 = new Label();
        textBox1 = new TextBox();
        label1 = new Label();
        label4 = new Label();
        labelcombobox = new Label();
        savebutton = new Button();
        textBoxitem = new TextBox();
        comboboxcategory = new ComboBox();
        buttonclear = new Button();
        buttonadd = new Button();
        buttonremove = new Button();
        listBoxshopping = new ListBox();
        labellistbox = new Label();
        contextMenuListBox = new ContextMenuStrip(components);
        toolStripMenuItem1 = new ToolStripMenuItem();
        editToolStripMenuItemToolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem2 = new ToolStripMenuItem();
        editToolStripMenuItemToolStripMenuItem2 = new ToolStripMenuItem();
        labelCounter = new Label();
        sidepanel.SuspendLayout();
        contextMenuListBox.SuspendLayout();
        SuspendLayout();
        // 
        // sidepanel
        // 
        sidepanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        sidepanel.BackColor = Color.FromArgb(55, 118, 161);
        sidepanel.Controls.Add(label2);
        sidepanel.Controls.Add(textBox1);
        sidepanel.Controls.Add(label1);
        sidepanel.Controls.Add(label4);
        sidepanel.Controls.Add(labelcombobox);
        sidepanel.Controls.Add(savebutton);
        sidepanel.Controls.Add(textBoxitem);
        sidepanel.Controls.Add(comboboxcategory);
        sidepanel.Controls.Add(buttonclear);
        sidepanel.Controls.Add(buttonadd);
        sidepanel.Controls.Add(buttonremove);
        sidepanel.Location = new Point(0, 0);
        sidepanel.Margin = new Padding(3, 2, 3, 2);
        sidepanel.Name = "sidepanel";
        sidepanel.Size = new Size(286, 413);
        sidepanel.TabIndex = 0;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.ForeColor = Color.White;
        label2.Location = new Point(12, 326);
        label2.Name = "label2";
        label2.Size = new Size(92, 21);
        label2.TabIndex = 18;
        label2.Text = "Search Item";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(12, 353);
        textBox1.Margin = new Padding(3, 2, 3, 2);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(258, 23);
        textBox1.TabIndex = 14;
        textBox1.TextChanged += textBox1_TextChanged_1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.White;
        label1.Location = new Point(12, 187);
        label1.Name = "label1";
        label1.Size = new Size(81, 21);
        label1.TabIndex = 14;
        label1.Text = "Enter Item";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.BackColor = Color.Transparent;
        label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.ForeColor = Color.White;
        label4.Location = new Point(12, 117);
        label4.Name = "label4";
        label4.Size = new Size(118, 21);
        label4.TabIndex = 13;
        label4.Text = "Select Category";
        // 
        // labelcombobox
        // 
        labelcombobox.AutoSize = true;
        labelcombobox.BackColor = Color.Transparent;
        labelcombobox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelcombobox.ForeColor = Color.White;
        labelcombobox.Location = new Point(51, 22);
        labelcombobox.Name = "labelcombobox";
        labelcombobox.Size = new Size(186, 45);
        labelcombobox.TabIndex = 4;
        labelcombobox.Text = "Combo Box";
        labelcombobox.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // savebutton
        // 
        savebutton.BackColor = Color.SkyBlue;
        savebutton.BackgroundImageLayout = ImageLayout.Zoom;
        savebutton.FlatStyle = FlatStyle.Flat;
        savebutton.Image = Properties.Resources.SaveIcon1;
        savebutton.Location = new Point(151, 250);
        savebutton.Margin = new Padding(3, 2, 3, 2);
        savebutton.Name = "savebutton";
        savebutton.Size = new Size(56, 56);
        savebutton.TabIndex = 7;
        savebutton.UseVisualStyleBackColor = false;
        savebutton.Click += savebutton_Click;
        // 
        // textBoxitem
        // 
        textBoxitem.BackColor = Color.FromArgb(255, 248, 242);
        textBoxitem.ForeColor = Color.FromArgb(78, 78, 78);
        textBoxitem.Location = new Point(12, 210);
        textBoxitem.Margin = new Padding(3, 2, 3, 2);
        textBoxitem.Name = "textBoxitem";
        textBoxitem.Size = new Size(258, 23);
        textBoxitem.TabIndex = 6;
        textBoxitem.TextChanged += textBoxitem_TextChanged;
        // 
        // comboboxcategory
        // 
        comboboxcategory.BackColor = Color.FromArgb(255, 248, 242);
        comboboxcategory.ForeColor = Color.FromArgb(78, 78, 78);
        comboboxcategory.FormattingEnabled = true;
        comboboxcategory.Location = new Point(12, 140);
        comboboxcategory.Margin = new Padding(3, 2, 3, 2);
        comboboxcategory.Name = "comboboxcategory";
        comboboxcategory.Size = new Size(258, 23);
        comboboxcategory.TabIndex = 3;
        comboboxcategory.SelectedIndexChanged += comboboxcategory_SelectedIndexChanged;
        // 
        // buttonclear
        // 
        buttonclear.BackColor = Color.FromArgb(192, 192, 255);
        buttonclear.BackgroundImageLayout = ImageLayout.Zoom;
        buttonclear.FlatStyle = FlatStyle.Popup;
        buttonclear.ImageAlign = ContentAlignment.TopCenter;
        buttonclear.Location = new Point(213, 250);
        buttonclear.Margin = new Padding(3, 2, 3, 2);
        buttonclear.Name = "buttonclear";
        buttonclear.Size = new Size(57, 56);
        buttonclear.TabIndex = 3;
        buttonclear.Text = "-";
        buttonclear.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonclear.UseVisualStyleBackColor = false;
        buttonclear.Click += buttonclear_Click;
        // 
        // buttonadd
        // 
        buttonadd.BackColor = Color.SkyBlue;
        buttonadd.BackgroundImageLayout = ImageLayout.Zoom;
        buttonadd.FlatStyle = FlatStyle.Popup;
        buttonadd.ImageAlign = ContentAlignment.TopCenter;
        buttonadd.Location = new Point(12, 250);
        buttonadd.Margin = new Padding(3, 2, 3, 2);
        buttonadd.Name = "buttonadd";
        buttonadd.Size = new Size(61, 56);
        buttonadd.TabIndex = 2;
        buttonadd.Text = "+";
        buttonadd.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonadd.UseVisualStyleBackColor = false;
        buttonadd.Click += buttonadd_Click;
        // 
        // buttonremove
        // 
        buttonremove.BackColor = Color.FromArgb(192, 192, 255);
        buttonremove.BackgroundImageLayout = ImageLayout.Zoom;
        buttonremove.FlatStyle = FlatStyle.Popup;
        buttonremove.ImageAlign = ContentAlignment.TopCenter;
        buttonremove.Location = new Point(79, 250);
        buttonremove.Margin = new Padding(3, 2, 3, 2);
        buttonremove.Name = "buttonremove";
        buttonremove.Size = new Size(66, 56);
        buttonremove.TabIndex = 4;
        buttonremove.Text = "-";
        buttonremove.TextImageRelation = TextImageRelation.ImageBeforeText;
        buttonremove.UseVisualStyleBackColor = false;
        buttonremove.Click += buttonremove_Click;
        // 
        // listBoxshopping
        // 
        listBoxshopping.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        listBoxshopping.BackColor = Color.FromArgb(224, 224, 224);
        listBoxshopping.BorderStyle = BorderStyle.FixedSingle;
        listBoxshopping.Cursor = Cursors.Cross;
        listBoxshopping.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        listBoxshopping.ForeColor = Color.FromArgb(78, 78, 78);
        listBoxshopping.FormattingEnabled = true;
        listBoxshopping.ItemHeight = 21;
        listBoxshopping.Location = new Point(434, 71);
        listBoxshopping.Margin = new Padding(3, 2, 3, 2);
        listBoxshopping.Name = "listBoxshopping";
        listBoxshopping.Size = new Size(296, 233);
        listBoxshopping.TabIndex = 2;
        // 
        // labellistbox
        // 
        labellistbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        labellistbox.AutoSize = true;
        labellistbox.FlatStyle = FlatStyle.Flat;
        labellistbox.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        labellistbox.ForeColor = Color.FromArgb(78, 78, 78);
        labellistbox.Location = new Point(523, 19);
        labellistbox.Name = "labellistbox";
        labellistbox.Size = new Size(138, 45);
        labellistbox.TabIndex = 5;
        labellistbox.Text = "List Box";
        // 
        // contextMenuListBox
        // 
        contextMenuListBox.ImageScalingSize = new Size(20, 20);
        contextMenuListBox.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
        contextMenuListBox.Name = "contextMenuListBox";
        contextMenuListBox.Size = new Size(118, 48);
        contextMenuListBox.Opening += contextMenuListBox_Opening;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItemToolStripMenuItem });
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(117, 22);
        toolStripMenuItem1.Text = "Remove";
        // 
        // editToolStripMenuItemToolStripMenuItem
        // 
        editToolStripMenuItemToolStripMenuItem.Name = "editToolStripMenuItemToolStripMenuItem";
        editToolStripMenuItemToolStripMenuItem.Size = new Size(166, 22);
        editToolStripMenuItemToolStripMenuItem.Text = "Remove this item";
        editToolStripMenuItemToolStripMenuItem.Click += editToolStripMenuItemToolStripMenuItem_Click;
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItemToolStripMenuItem2 });
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new Size(117, 22);
        toolStripMenuItem2.Text = "Edit";
        // 
        // editToolStripMenuItemToolStripMenuItem2
        // 
        editToolStripMenuItemToolStripMenuItem2.Name = "editToolStripMenuItemToolStripMenuItem2";
        editToolStripMenuItemToolStripMenuItem2.Size = new Size(143, 22);
        editToolStripMenuItemToolStripMenuItem2.Text = "Edit this Item";
        editToolStripMenuItemToolStripMenuItem2.Click += editToolStripMenuItemToolStripMenuItem1_Click;
        // 
        // labelCounter
        // 
        labelCounter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        labelCounter.AutoSize = true;
        labelCounter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        labelCounter.ForeColor = Color.FromArgb(78, 78, 78);
        labelCounter.Location = new Point(688, 328);
        labelCounter.Name = "labelCounter";
        labelCounter.Size = new Size(93, 19);
        labelCounter.TabIndex = 12;
        labelCounter.Text = "Total Items: 0";
        // 
        // Act7
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(892, 413);
        Controls.Add(listBoxshopping);
        Controls.Add(sidepanel);
        Controls.Add(labelCounter);
        Controls.Add(labellistbox);
        ForeColor = Color.FromArgb(78, 78, 78);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 2, 3, 2);
        Name = "Act7";
        Text = "Form1";
        Load += Form1_Load_1;
        sidepanel.ResumeLayout(false);
        sidepanel.PerformLayout();
        contextMenuListBox.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel sidepanel;
    private Button buttonadd;
    private Button buttonclear;
    private Button buttonremove;
    private ListBox listBoxshopping;
    private ComboBox comboboxcategory;
    private Label labellistbox;
    private TextBox textBoxitem;
    private Button savebutton;
    private ContextMenuStrip contextMenuListBox;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem editToolStripMenuItemToolStripMenuItem;
    private ToolStripMenuItem toolStripMenuItem2;
    private ToolStripMenuItem editToolStripMenuItemToolStripMenuItem2;
    private Label labelCounter;
    private Label label4;
    private Label label1;
    private TextBox textBox1;
    private Label label2;
    private Label labelcombobox;
}
