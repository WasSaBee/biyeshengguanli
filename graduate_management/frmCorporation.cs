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
    public partial class frmCorporation : Form
    {
        public string corID;
        DBOperate operate = new DBOperate();
        public frmCorporation()
        {
            InitializeComponent();
        }

        private void frmCorporation_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = operate.getTable("select * from corInfo where corID='"+corID+"'");
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
            corAuthValue.Text = ds.Tables[0].Rows[0][11].ToString();
            operate.getCorImage(corID, pictureBox1);
            if (corAuthValue.Text == "否")
            {
                reqContentKey.Text = "申请内容";
                reqIDValue.Visible = false;
                reqContentValue.Visible = true;
                reqTypeValue.Items.Add("认证申请");
            }
            else
            {
                reqIDValue.Visible = true;
                reqTypeValue.Items.Add("申请查看学生");
                reqContentKey.Text = "学号";
                reqContentValue.Visible = false;
                reqTypeValue.Items.Remove("认证申请");
            }
            string str = "select id as '编号',reqType as '申请类型',reqDate as '申请日期',reqResult as '申请结果'from requestInfo where reqPeople='"+corNameValue.Text+"'";
            operate.bindDataGridView(dataGridView1,str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReadPicture fm1 = new frmReadPicture();
            fm1.picture = pictureBox1.Image;
            fm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCorEdit fm1 = new frmCorEdit();
            fm1.corID = corID;
            fm1.Show();
        }

        private void frmCorporation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5) {
                frmCorporation_Load(sender,e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCorporation_Load(sender,e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (reqTypeValue.Text == "申请查看学生")
            {
                if (reqIDValue.Text.Trim() != "")
                {
                    string insertStr = "insert into requestInfo(reqType,reqContent,reqPeople,reqDate)values('";
                    insertStr += reqTypeValue.Text + "','学号为";
                    insertStr += reqIDValue.Text + "','";
                    insertStr += corNameValue.Text + "','";
                    insertStr += DateTime.Now.ToString() + "')";
                    int i = operate.sqlCmd(insertStr);
                    if (i == 1)
                    {
                        MessageBox.Show("提交成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reqIDValue.Clear();
                    }
                    else
                        MessageBox.Show("提交失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (reqTypeValue.Text == "认证申请")
            {
                if (reqContentValue.Text.Trim() != "")
                {
                    string insertStr = "insert into requestInfo(reqType,reqContent,reqPeople,reqDate)values('";
                    insertStr += reqTypeValue.Text + "','";
                    insertStr += reqContentValue.Text + "','";
                    insertStr += corNameValue.Text + "','";
                    insertStr += DateTime.Now.ToString() + "')";
                    int i = operate.sqlCmd(insertStr);
                    if (i == 1)
                    {
                        MessageBox.Show("提交成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reqContentValue.Clear();
                    }
                    else
                        MessageBox.Show("提交失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != -1) {
                frmRequestView fm1 = new frmRequestView();
                fm1.id = dataGridView1.SelectedCells[0].Value.ToString();
                fm1.Show();
            }
        }
    }
}
