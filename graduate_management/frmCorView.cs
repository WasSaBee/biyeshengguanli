using graduate_management.GMclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graduate_management
{
    public partial class frmCorView : Form
    {
        DBOperate operate = new DBOperate();
        public string corID;
        public frmCorView()
        {
            InitializeComponent();
        }

        private void frmCorView_Load(object sender, EventArgs e)
        {           
            string str = "select * from corInfo where corID='"+corID+"'";
            DataSet ds= operate.getTable(str);
            ds.Dispose();
            corIDValue.Text = corID;
            corNameValue.Text = ds.Tables[0].Rows[0][1].ToString();
            corResPersonValue.Text = ds.Tables[0].Rows[0][2].ToString();
            corRegAddValue.Text = ds.Tables[0].Rows[0][3].ToString();
            corTelValue.Text = ds.Tables[0].Rows[0][4].ToString();
            corPersonValue.Text = ds.Tables[0].Rows[0][5].ToString();
            corPersonTelValue.Text = ds.Tables[0].Rows[0][6].ToString();
            corPersonEmailValue.Text = ds.Tables[0].Rows[0][7].ToString();
            corConValue.Text = ds.Tables[0].Rows[0][8].ToString();
            corAddValue.Text = ds.Tables[0].Rows[0][9].ToString();
            label1.Text= ds.Tables[0].Rows[0][10].ToString();
            operate.getCorImage(corID,pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReadPicture fm1 = new frmReadPicture();
            fm1.picture = pictureBox1.Image;
            fm1.Show();
        }
    }
}
