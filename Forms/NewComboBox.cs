using System.Collections.Generic;
using Softdev_activities.Forms;

namespace Softdev_activities.Forms
{
    public partial class Act7 : Form
    {
        public Act7()
        {
            InitializeComponent();
        }

        private List<string> shoppingItems = new List<string>(); // Store all items

        private void Form1_Load_1(object sender, EventArgs e)

        {
            // Add categories to the ComboBox
            comboboxcategory.Items.Add("Electronics");
            comboboxcategory.Items.Add("Groceries");
            comboboxcategory.Items.Add("Clothing");
            comboboxcategory.Items.Add("Books");

            listBoxshopping.ContextMenuStrip = contextMenuListBox;

        }

        private Dictionary<string, List<string>> categoryItems = new Dictionary<String, List<string>>()
        {
            {"Electronics", new List<string>()},
            {"Groceries", new List<string>()},
            {"Clothing", new List<string>()},
            {"Books", new List<string>()}

        };
        private void UpdateCounter()
        {
            labelCounter.Text = $"Total Items: {listBoxshopping.Items.Count}";
        }

        private void comboboxcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxcategory.SelectedItem == null) return;

            string selectedCategory = comboboxcategory.SelectedItem.ToString();

            // Clear and load saved items for the selected category
            listBoxshopping.Items.Clear();
            if (categoryItems.ContainsKey(selectedCategory))
            {
                foreach (var item in categoryItems[selectedCategory])
                {
                    listBoxshopping.Items.Add(item);
                }
            }

            UpdateCounter();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxitem.Text) || comboboxcategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category and enter an item.", "Error");
                return;
            }

            string category = comboboxcategory.SelectedItem.ToString();
            string item = textBoxitem.Text;

            if (!categoryItems.ContainsKey(category))
            {
                categoryItems[category] = new List<string>();
            }

            if (categoryItems[category].Contains(item))
            {
                MessageBox.Show("This item is already in the list.", "Duplicate Item");
                return;
            }

            // Add item to the correct category list
            categoryItems[category].Add(item);

            // Update the ListBox to show only the current category's items
            listBoxshopping.Items.Clear();
            listBoxshopping.Items.AddRange(categoryItems[category].ToArray());

            textBoxitem.Clear(); // Clear input box after adding
            UpdateCounter(); // Update item count
        }
        private void buttonremove_Click(object sender, EventArgs e)
        {
            if (comboboxcategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first.", "Error");
                return;
            }

            if (listBoxshopping.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to remove.", "Error");
                return;
            }

            string category = comboboxcategory.SelectedItem.ToString();
            string selectedItem = listBoxshopping.SelectedItem.ToString();

            // Ensure the category exists and remove the item from the list
            if (categoryItems.ContainsKey(category) && categoryItems[category].Contains(selectedItem))
            {
                categoryItems[category].Remove(selectedItem);

                // Refresh ListBox
                listBoxshopping.Items.Clear();
                listBoxshopping.Items.AddRange(categoryItems[category].ToArray());

                UpdateCounter(); // Update item count
            }
            else
            {
                MessageBox.Show("Item not found in the selected category.", "Error");
            }
        }

 
        private void buttonclear_Click(object sender, EventArgs e)
        {
            if (comboboxcategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first.", "Error");
                return;
            }

            string category = comboboxcategory.SelectedItem.ToString();

            // Confirm the action before clearing
            DialogResult result = MessageBox.Show($"Are you sure you want to clear all items in {category}?",
                                                  "Confirm Clear",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Clear only the items for the selected category
                categoryItems[category].Clear();

                // Clear ListBox only for the selected category
                listBoxshopping.Items.Clear();
                UpdateCounter();
            }

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("ShoppingList.txt"))
            {
                foreach (var category in categoryItems.Keys)
                {
                    writer.WriteLine($"[{category}]"); // Write category header
                    foreach (var item in categoryItems[category])
                    {
                        writer.WriteLine(item); // Write items under category
                    }
                    writer.WriteLine(); // Add spacing for readability
                }
            }

            MessageBox.Show("Shopping list saved successfully!", "Save Complete");
        }

        private void textBoxitem_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuListBox_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        // 
        private void editToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listBoxshopping.SelectedItem != null)
            {
                listBoxshopping.Items.Remove(listBoxshopping.SelectedItem);
                UpdateCounter(); // Update item count
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Error");
            }

        }


        // How to the fuck my edit turn to  editToolStripMenuItemToolStripMenuItem1_Click

        private void editToolStripMenuItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (listBoxshopping.SelectedItem != null)
            {
                // Prompt user to enter a new name
                string newItem = Microsoft.VisualBasic.Interaction.InputBox(
                    "Edit item:", "Edit Item", listBoxshopping.SelectedItem.ToString());

                // Ensure the user didn't leave it empty
                if (!string.IsNullOrWhiteSpace(newItem))
                {
                    int selectedIndex = listBoxshopping.SelectedIndex;
                    listBoxshopping.Items[selectedIndex] = newItem;

                }
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Error");
            }


        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (comboboxcategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category first.", "Error");
                return;
            }

            string searchText = textBox1.Text.ToLower();
            string category = comboboxcategory.SelectedItem.ToString();

            // Ensure the selected category has items stored
            if (!categoryItems.ContainsKey(category)) return;

            // Filter items that start with the search text
            var filteredItems = categoryItems[category]
                .Where(item => item.ToLower().StartsWith(searchText)) // Search only at the beginning
                .ToList();

            // Update ListBox with filtered results
            listBoxshopping.Items.Clear();
            listBoxshopping.Items.AddRange(filteredItems.ToArray());

            UpdateCounter(); // Update item count after filtering

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                         "Exit Confirmation",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
