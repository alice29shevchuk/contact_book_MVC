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
    public partial class ViewContactForm : Form
    {
        public ViewContactForm(string name,string address,List<string> numb)
        {
            InitializeComponent();
            this.userControl.SetNameSurname(name);
            this.userControl.SetAddress(address);
            this.userControl.SetNumber(numb);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
