using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class dynamic : Form
    {
        public dynamic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userform usr = new userform();
            usr.TopLevel = false;
            usr.AutoScroll = true;
            panel2.Controls.Add(usr);
            usr.Show();
        }
    }
}
