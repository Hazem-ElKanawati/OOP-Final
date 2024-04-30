using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace OOP_Final
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        PhoneBook phoneBook = new PhoneBook();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create an instance of PhoneBook


            // Load contacts from file
            phoneBook.LoadContactsFromFile("contacts.txt");
            //loading favorites file
            phoneBook.LoadFavsfromfile("Favorites.txt");

            // Populate the ListView with contacts
        }

        private void listViewContacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] searchResults = null;
            int idx = comboBox1.SelectedIndex;
          
          


            
            switch(idx)
            {
                case 0 :
                    searchResults = phoneBook.SearchByName(textBox1.Text); break;
                case 1 :
                    searchResults =  phoneBook.SearchByPhone(textBox1.Text); break;
                case 2:
                    searchResults = phoneBook.SearchByEmail(textBox1.Text); break;
                default:
                    MessageBox.Show("Please select a type to search by.");
                    return;
                    break;
                    
            }
            // Clear existing rows in the DataGridView
            dataGridView1.Rows.Clear();

            // Add rows corresponding to the search results
            foreach (int index in searchResults)
            {
               
                    Contact contact = phoneBook.contacts[index];
                    dataGridView1.Rows.Add(contact.Name, contact.Phone, contact.Email);
               

               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { //delete
          //phoneBook.DeleteContact();
          // Get the selected row
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Pass the data of the selected row to another function for further processing
                string phone = selectedRow.Cells[1].Value.ToString();

                dataGridView1.Rows.Remove(selectedRow);
                // Call your function here, passing the data
                phoneBook.DeleteContact(phoneBook.GetIndex(phone));
                // Remove the selected row from the DataGridView

            } else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView1.FirstDisplayedScrollingRowIndex = 0;
            try
                {

                    for (int i = 0; i < phoneBook.contacts.Count; i++) // Start from 1 to skip header row
                    {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = phoneBook.contacts[i].Name;
                    dataGridView1.Rows[i].Cells[1].Value = phoneBook.contacts[i].Phone;
                    dataGridView1.Rows[i].Cells[2].Value = phoneBook.contacts[i].Email;
                    }
                
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data from file: " + ex.Message);
                }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Contact x = new Contact(textName.Text,textEmail.Text, textPhone.Text);
            phoneBook.AddContact(x);
            textName.Clear();
            textEmail.Clear();
            textPhone.Clear();
            button4_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            DataGridViewRow selectedRow1 = dataGridView1.SelectedRows[0];

            // Pass the data of the selected row to another function for further processing
            string phone = selectedRow1.Cells[1].Value.ToString();
            int id = phoneBook.GetIndex(phone);
            switch (index) 
            {
                case 0:
                    phoneBook.EditContact(id,0, editBox.Text); break;
                case 1:
                    phoneBook.EditContact(id,1, editBox.Text); break;
                case 2:
                    phoneBook.EditContact(id,2, editBox.Text); break;
            }
            button4_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.FirstDisplayedScrollingRowIndex = 0;
            try
            {

                for (int i = 0; i < phoneBook.contacts.Count; i++) // Start from 1 to skip header row
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = phoneBook.contacts[i].Name;
                    dataGridView1.Rows[i].Cells[1].Value = phoneBook.contacts[i].Phone;
                    dataGridView1.Rows[i].Cells[2].Value = phoneBook.contacts[i].Email;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from file: " + ex.Message);
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow1 = dataGridView1.SelectedRows[0];

            // Pass the data of the selected row to another function for further processing
            string phone = selectedRow1.Cells[1].Value.ToString();
            int id = phoneBook.GetIndex(phone);
            phoneBook.Addtofav(id);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.FirstDisplayedScrollingRowIndex = 0;
            try
            {

                for (int i = 0; i < phoneBook.favorites.Count; i++) // Start from 1 to skip header row
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = phoneBook.favorites[i].Name;
                    dataGridView1.Rows[i].Cells[1].Value = phoneBook.favorites[i].Phone;
                    dataGridView1.Rows[i].Cells[2].Value = phoneBook.favorites[i].Email;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from file: " + ex.Message);
            }
        }

        private void searchquery_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox2.SelectedIndex;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            phoneBook.SaveContactsToFile("Contacts.txt");
            phoneBook.SavetoFile("Favorites.txt");
        }
    }
    
}