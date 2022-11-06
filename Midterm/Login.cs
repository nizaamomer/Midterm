using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {

           
            string username ;
            int loginType;
            connection conn = new connection();
            conn.dbconnect();
            SqlCommand cmd = new SqlCommand("select * from users where username=@user and passwordd=@pass ", connection.conn);
            cmd.Parameters.AddWithValue("@user", txtusername.Text);
            cmd.Parameters.AddWithValue("@pass", txtpassword.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                username = rd["username"].ToString();
                    loginType =  Convert.ToInt16(rd["loginType"]);
                    if (loginType == 1)
                {
                    adminform admf = new adminform();
                    admf.username = username;   
                    admf.Show();
                }
                else 
                {
                    userform userf = new userform();
                    userf.username = username;
                    userf.Show();
                }

            }
            else
            {
                MessageBox.Show("username and password was wrong...");
            }
            conn.dbClose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic dynm = new dynamic();
            dynm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crud cr = new crud();
            cr.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            crud crud2 = new crud();
            crud2.Show();
        }
    }
}
