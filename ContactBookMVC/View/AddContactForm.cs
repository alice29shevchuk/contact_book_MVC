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
    public partial class AddContactForm : Form
    {
        public Contact contact { get; set; }
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contact = new Contact(this.nameTB.Text,this.surnameTB.Text,this.addressTB.Text, new List<string> { this.numberTB.Text });
            this.Close();
        }
    }
}
