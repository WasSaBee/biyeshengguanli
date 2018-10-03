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
    public partial class frmStudentView : Form
    {
        public string stuID;
        public bool isTeacher = false;
        public string teacherName;
        DBOperate operate = new DBOperate();
        public frmStudentView()
        {
            InitializeComponent();
        }
        private void frmStudentView_Load(object sender, EventArgs e)
        {
            operate.getImage(stuID, pictureBox1);
            stuIDValue.Text = stuID;
            DataSet ds = operate.getTable("select * from stuInfo where stuID='" + stuID + "'");
            ds.Dispose();
            stuNameValue.Text = ds.Tables[0].Rows[0][1].ToString();
            stuFmrNameValue.Text = ds.Tables[0].Rows[0][3].ToString();
            stuSexValue.Text = ds.Tables[0].Rows[0][4].ToString();
            stuBirthValue.Text = ds.Tables[0].Rows[0][5].ToString();
            stuNationValue.Text = ds.Tables[0].Rows[0][6].ToString();
            stuPoliValue.Text = ds.Tables[0].Rows[0][7].ToString();
            stuResValue.Text = ds.Tables[0].Rows[0][8].ToString();
            stuIDCValue.Text = ds.Tables[0].Rows[0][9].ToString();
            stuWorkPlaceValue.Text = ds.Tables[0].Rows[0][10].ToString();
            stuPCValue.Text = ds.Tables[0].Rows[0][11].ToString();
            stuWorkTelValue.Text = ds.Tables[0].Rows[0][12].ToString();
            stuAddValue.Text = ds.Tables[0].Rows[0][13].ToString();
            stuTelValue.Text = ds.Tables[0].Rows[0][14].ToString();
            stuExpValue.Text = ds.Tables[0].Rows[0][15].ToString();
            stuPrzCrtValue.Text = ds.Tables[0].Rows[0][16].ToString();
            if (isTeacher == true)
            {
                button1.Visible = true;
            }
            else
                button1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmReadPicture fm1 = new frmReadPicture();
            fm1.picture = pictureBox1.Image;
            fm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRequestVerify fm1 = new frmRequestVerify();
            fm1.VerName = teacherName;
            fm1.stuID = stuIDValue.Text;
            fm1.Show();
        }
    }
}
