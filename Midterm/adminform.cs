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
    public partial class adminform : Form
    {
        public string username { get; set; }
        public adminform()
        {
            InitializeComponent();
        }

        private void adminform_Load(object sender, EventArgs e)
        {
            label1.Text = username ;
        }
    }
}
