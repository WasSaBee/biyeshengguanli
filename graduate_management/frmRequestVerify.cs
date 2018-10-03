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
    public partial class frmRequestVerify : Form
    {
        public string stuID;
        public string VerName;
        DBOperate operate = new DBOperate();
        public frmRequestVerify()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reqTimeValue.Text = DateTime.Now.ToString();
        }

        private void frmRequestVerify_Load(object sender, EventArgs e)
        {
            timer1.Start();
            reqPeopleValue.Text = VerName;
            stuIDValue.Text = stuID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reqContentValue.Text.Trim() != "" && reqResultValue.Text != "")
            {
                string insertStr = "insert into requestInfo(reqType,reqContent,reqPeople,reqDate)values('";
                insertStr += reqTypeValue.Text + "','";
                insertStr += "申核教师为" + VerName + ",申核学生的学号为" + stuIDValue.Text + ",申核内容为:" + reqContentValue.Text + ",申核结果为:" + reqResultValue.Text + "','";
                insertStr += reqPeopleValue.Text + "','";
                insertStr += reqTimeValue.Text + "')";
                int i = operate.sqlCmd(insertStr);
                if (i == 1)
                {
                    MessageBox.Show("申核提交成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                    MessageBox.Show("申核提交失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                MessageBox.Show("消息不全", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
