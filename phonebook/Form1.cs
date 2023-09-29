using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace phonebook
{
        public partial class Form1 : Form
    {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd1 = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            CurrencyManager cr;
            Region x = new Region();
            int beforedit;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename="+Application.StartupPath +@"\Telbook.mdf;Integrated Security=True";
            conn.Open();
            fillgrid();
        }
        void fillgrid(string s = "Select * from tbltell")
        {
            cmd1.CommandText = s;
            cmd1.Connection = conn;
            da.SelectCommand = cmd1;
            ds.Clear();
            da.Fill(ds, "T1");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "T1");
            txtname.DataBindings.Clear();
            txtname.DataBindings.Add("text", ds, "T1.Firstname");
            txtfamily.DataBindings.Clear();
            txtfamily.DataBindings.Add("text", ds, "T1.Lastname");
            txttell.DataBindings.Clear();
            txttell.DataBindings.Add("text", ds, "T1.phoneno");
            txtaddress.DataBindings.Clear();
            txtaddress.DataBindings.Add("text", ds, "T1.address");
            pic1.DataBindings.Clear();
            pic1.DataBindings.Add("imagelocation",ds,"T1.picurl");
            cr = (CurrencyManager)this.BindingContext[ds, "T1"];
        }

        private void tnnext_Click(object sender, EventArgs e)
        {
            setcurrentrec(cr.Position + 1);
        }

        private void tnfirst_Click(object sender, EventArgs e)
        {
            setcurrentrec(0);
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            setcurrentrec(cr.Position - 1);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            setcurrentrec(cr.Count - 1);
        }

        private void Bbtnnew_Click(object sender, EventArgs e)
        {
            txtname.ReadOnly = false;
            txtfamily.ReadOnly = false;
            txttell.ReadOnly = false;
            txtaddress.ReadOnly = false;
            txtname.Text = "";
            txtfamily.Text = "";
            txttell.Text = "";
            txtaddress.Text = "";
            Bbtnnew.Enabled = false;
            btnsave.Enabled = true;
            BtnBrowse.Enabled = true;
            txtname.Focus();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "insert into tbltell values (@p1,@p2,@p3,@p4,@p5)";
            c1.Parameters.AddWithValue("p1", txtname.Text);
            c1.Parameters.AddWithValue("p2", txtfamily.Text);
            c1.Parameters.AddWithValue("p3", txttell.Text);
            c1.Parameters.AddWithValue("p4", txtaddress.Text);
            c1.Parameters.AddWithValue("p5", copypic(pic1.ImageLocation,txttell.Text));
            c1.Connection = conn;
            c1.ExecuteNonQuery();
            btnsave.Enabled = false;
            BtnBrowse.Enabled = false;
            Bbtnnew.Enabled = true;
            txtname.ReadOnly = true;
            txtfamily.ReadOnly = true;
            txttell.ReadOnly = true;
            txtaddress.ReadOnly = true;
            fillgrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
            cr.Position = e.RowIndex;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Do you want to delete " + txtname.Text + " " + txtfamily.Text, "Delete...", MessageBoxButtons.YesNo);
            if (x == DialogResult.No)
                return;
            SqlCommand c2 = new SqlCommand();
            c2.CommandText = "delete from tbltell where phoneno=@p1";
            c2.Parameters.AddWithValue("p1", txttell.Text);
            c2.Connection = conn;
            c2.ExecuteNonQuery();
            fillgrid();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
           

            if (btnedit.Text == "Edit")
            {
                txtname.ReadOnly = false;
                txtfamily.ReadOnly = false;
                txttell.ReadOnly = true;
                txtaddress.ReadOnly = false;
                BtnBrowse.Enabled = true;
                btnedit.Text = "Apply";
                txtname.Focus();
                beforedit = cr.Position;
            }
            else
            {
                SqlCommand c3 = new SqlCommand();
                c3.CommandText = "update tbltell set firstname=@p1,lastname=@p2,address=@p3,picurl=@p5 where phoneno=@p4";
                c3.Parameters.AddWithValue("p1",txtname.Text);
                c3.Parameters.AddWithValue("p2", txtfamily.Text);
                c3.Parameters.AddWithValue("p3", txtaddress.Text);
                c3.Parameters.AddWithValue("p4", txttell.Text);
                c3.Parameters.AddWithValue("p5", copypic( pic1.ImageLocation,txttell.Text));
                c3.Connection = conn;
                c3.ExecuteNonQuery();
                fillgrid();
                setcurrentrec(beforedit);
                txtname.ReadOnly = true;
                txtfamily.ReadOnly = true;
                txttell.ReadOnly = true;
                txtaddress.ReadOnly = true;
                btnedit.Text = "Edit";
                BtnBrowse.Enabled = false;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string a;
            a = "select * from tbltell where " + cmbfeild.Text + " like '" + txtsearch.Text + "%'";
            fillgrid(a);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            btnsearch_Click(null, null);
        }
        void setcurrentrec(int currec) {
            if (currec < 0 || currec >= cr.Count)
                return;
            cr.Position = currec;
            dataGridView1.CurrentCell = dataGridView1.Rows[currec].Cells[dataGridView1.CurrentCell.ColumnIndex];
        
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            setcurrentrec(dataGridView1.CurrentCell.RowIndex);
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = openFileDialog1.ShowDialog();
            if (x == DialogResult.Cancel)
                return;
            pic1.ImageLocation = openFileDialog1.FileName;
        }
        string copypic(string sourcefile, string key) {
            if (sourcefile == "")
                return "";
            string curpath;
            string newpath;
            curpath = Application.StartupPath + @"\images\";
            if (Directory.Exists(curpath) == false)
                Directory.CreateDirectory(curpath);
            newpath = curpath + key + sourcefile.Substring(sourcefile.LastIndexOf("."));
            if (File.Exists(newpath) == true)
                File.Delete(newpath);
            File.Copy(sourcefile, newpath);
            return newpath;
        
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            if (pic1.SizeMode == PictureBoxSizeMode.StretchImage)
            {
                x = pic1.Region;
                pic1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else
            {
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                pic1.Region = x;
            }
        }

        private void pic1_MouseLeave(object sender, EventArgs e)
        {
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.Region = x;
        }
    }
}
