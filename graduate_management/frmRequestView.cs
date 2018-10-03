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
    public partial class frmRequestView : Form
    {
        public string id,stuID;
        DBOperate operate=new DBOperate();
        public frmRequestView()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                string insertStr = "insert into requestInfo(reqType,reqPeople,reqContent,reqDate)";
                insertStr += "values('申请复核（学生）','";
                insertStr += stuID + "','";
                insertStr += textBox1.Text + "','";
                insertStr += DateTime.Now.ToString() + "')";
                int i = operate.sqlCmd(insertStr);
                if (i == 1)
                {
                    MessageBox.Show("申请复核成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    groupBox2.Enabled = false;
                }
                else MessageBox.Show("申请复核失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                MessageBox.Show("未填写申请内容", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmRequestView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = reqContentValue.Text.Remove(0,3);
            frmStudentView fm1 = new frmStudentView();
            fm1.stuID = str;
            fm1.Show();
        }

        private void frmRequestView_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds=operate.getTable("select * from requestInfo where id='"+id+"'");
            ds.Dispose();
            reqIDValue.Text = id;
            reqTypeValue.Text = ds.Tables[0].Rows[0][1].ToString();
            reqContentValue.Text = ds.Tables[0].Rows[0][2].ToString();
            reqPeopleValue.Text = ds.Tables[0].Rows[0][3].ToString();
            reqDateValue.Text = ds.Tables[0].Rows[0][4].ToString();
            reqResultValue.Text = ds.Tables[0].Rows[0][5].ToString();
            reqAdminValue.Text = ds.Tables[0].Rows[0][6].ToString();
            conDateValue.Text = ds.Tables[0].Rows[0][7].ToString();
            if (reqTypeValue.Text.Contains("复核申请")) {
                groupBox2.Enabled = false;
                button2.Visible = false;
            }
            else if (reqTypeValue.Text == "申请查看学生") {
                groupBox2.Visible = false;
                if (reqResultValue.Text == "批准")
                    button2.Visible = true;
                else {
                    button2.Visible = false;
                }
            }
            else if(reqTypeValue.Text=="学生信息申核"){
                groupBox2.Visible = false;
                button2.Visible = false;
            }
        }
    }
}
