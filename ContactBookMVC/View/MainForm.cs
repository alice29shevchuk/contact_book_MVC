using ContactBookMVC.Controller;
using ContactBookMVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBookMVC.View
{
    public partial class MainForm : Form
    {
        ContactController contactController = new ContactController();

        public MainForm()
        {
            InitializeComponent();
            UpdateList();
        }

        private void addContactLB_Click(object sender, EventArgs e)
        {
            
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();
            this.contactController.AddContact(addContactForm.contact);
            UpdateList();
        }
        private void UpdateList()
        {
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(contactController.GetContacts().ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = (sender as ListBox).SelectedItem.ToString();
            string[] masStr = str.Split( '|');
            List<Contact> list = contactController.GetContacts();
            foreach (var item in list)
            {
                if (int.Parse(masStr[0]) == item.Id)
                {
                    ViewContactForm viewContactForm = new ViewContactForm(item.Name+" "+item.Surname,item.Address,item.numbers);
                    viewContactForm.ShowDialog();
                }
            }
        }
    }
}
