using ContactBookMVC.Controller;
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
            this.listBox1.Items.AddRange(contactController.GetContacts().ToArray());
        }
    }
}
