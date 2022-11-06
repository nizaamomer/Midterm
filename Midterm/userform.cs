using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Midterm
{
    public partial class userform : Form
    {
        public string username { get; set; }
        public userform()
        {
            InitializeComponent();
        }

        private void userform_Load(object sender, EventArgs e)
        {
            label1.Text = username ;
        }
    }
}
