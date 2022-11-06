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
    public partial class crud : Form
    {
        public crud()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void crud2_Load(object sender, EventArgs e)
        {
            showdata();
        }
        public void showdata()
        {
            connection conn = new connection();
            conn.dbconnect();
            SqlCommand cmd = new SqlCommand("select * from crud",
            connection.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "crud");
            dataGridView1.DataSource = ds.Tables["crud"];
            conn.dbClose();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            connection conn = new connection();
            conn.dbconnect();
            SqlCommand cmd = new SqlCommand("insert into crud  (id , username , gender , fav , birth , lang)  values(@id , @username, @gender , @fav , @birth , @language) ", connection.conn);
            cmd.Parameters.AddWithValue("@id" , txtid.Text);
            cmd.Parameters.AddWithValue("@username" , txtusername.Text);
            String gender = "";
            if (rmale.Checked)
            {
                gender = rmale.Text;
            }
            else 
            {
                gender = rfemale.Text;
            }
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@fav", comboBox1.Text);
            cmd.Parameters.AddWithValue("@birth", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            String lan = "";
            foreach (Control cc in this.Controls)
            {
                if (cc is CheckBox)
                {
                    CheckBox b = (CheckBox)cc;
                    if (b.Checked)

                    {
                        lan = b.Text + " - " + lan;
                    }
                }
            }
            cmd.Parameters.AddWithValue("@language", lan);
            cmd.ExecuteNonQuery();
            conn.dbClose();
            showdata();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            connection conn = new connection();
            conn.dbconnect();
            SqlCommand cmd = new SqlCommand("update crud set username=@username ,gender =@gender , fav=@fav , birth=@birth , lang=@lang where id=@id", connection.conn);
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            String gender = "";
            if (rmale.Checked)
            {
                gender = rmale.Text;
            }
            else
            {
                gender = rfemale.Text;
            }
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@fav", comboBox1.Text);
            cmd.Parameters.AddWithValue("@birth", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            String lan = "";
            foreach (Control cc in this.Controls)
            {
                if(cc is CheckBox)
                {
                    CheckBox d  = (CheckBox)cc;
                    if (d.Checked)
                    {
                        lan = d.Text + " " + lan;
                    }
                }
            }
            cmd.Parameters.AddWithValue("@lang", lan);
            cmd.ExecuteNonQuery();
            conn.dbClose();
            showdata();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            connection conn = new connection();
            conn.dbconnect();
            SqlCommand cmd = new SqlCommand("delete from crud where id=@id", connection.conn);
            cmd.Parameters.AddWithValue("@id" , Convert.ToInt16(txtfind.Text));
            cmd.ExecuteNonQuery();
            conn.dbClose();
            showdata();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            connection conn = new connection();
            conn.dbconnect();
            SqlCommand cmd = new SqlCommand("select * from crud where id=@id", connection.conn);
            cmd.Parameters.AddWithValue("@id", txtfind.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "crud");
            dataGridView1.DataSource = ds.Tables["crud"];
            conn.dbClose();
        }
    }
}
