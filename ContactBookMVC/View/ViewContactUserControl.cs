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
    public partial class ViewContactUserControl : UserControl
    {
        public ViewContactUserControl()
        {
            InitializeComponent();
        }
        public void SetNameSurname(string name)
        {
            this.name_surnameLB.Text = name;
        }
        public void SetAddress(string address)
        {
            this.textBox1.Text = address;
        }
        public void SetNumber(List<string> list)
        {
            this.listBox1.Items.AddRange(list.ToArray());
        }
    }
}
