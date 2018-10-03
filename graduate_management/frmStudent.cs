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
    public partial class frmStudent : Form
    {
        DBOperate operate = new DBOperate();
        public string stuID;
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            
            operate.getImage(stuID,pictureBox1);
            stuIDValue.Text = stuID;
            DataSet ds = operate.getTable("select * from stuInfo where stuID='"+stuID+"'");
            ds.Dispose();
            stuNameValue.Text = ds.Tables[0].Rows[0][1].ToString();
            stuFmrNameValue.Text= ds.Tables[0].Rows[0][3].ToString();
            stuSexValue.Text = ds.Tables[0].Rows[0][4].ToString();
            stuBirthValue.Text= ds.Tables[0].Rows[0][5].ToString();
            stuNationValue.Text= ds.Tables[0].Rows[0][6].ToString();
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
            string dgvs = "select id as '编号',reqType as '申请类型',reqDate as '申请日期',reqResult as '申请结果',conDate as '申核日期' from requestInfo where reqPeople='" + stuNameValue.Text + "'";
            operate.bindDataGridView(dataGridView1,dgvs);
            dgvs = "select corID as '企业编号',corName as '企业名',corTel as '企业电话',corAdd as '企业地址' from corInfo";
            operate.bindDataGridView(dataGridView2,dgvs);
            label3.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStudentEdit fm1 = new frmStudentEdit();
            fm1.stuID = stuID;
            if (fm1.ShowDialog() == DialogResult.OK) frmStudent_Load(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(stuReqValue.Text.Trim()!=""&&stuReqConValue.Text.Trim()!=""&&stuNameValue.Text.Trim()!="")
            {
                string insertStr = "insert into requestInfo(reqType,reqPeople,reqContent,reqDate)";
                insertStr += "values('" + stuReqValue.Text + "（学生）','";
                insertStr += stuNameValue.Text + "','";
                insertStr += stuReqConValue.Text + "','";
                insertStr += DateTime.Now.ToString() + "')";
                int i = operate.sqlCmd(insertStr);
                if (i == 1)
                {
                    MessageBox.Show("提交申请成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stuReqConValue.Clear();
                }
                else MessageBox.Show("提交申请失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.frmStudent_Load(sender,e);
                
            }
            else
                MessageBox.Show("信息不完整", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != -1)
            {
                frmRequestView fm1 = new frmRequestView();
                try
                {
                    fm1.id = dataGridView1.SelectedCells[0].Value.ToString();
                    fm1.stuID = stuNameValue.Text;
                    if (fm1.ShowDialog() == DialogResult.OK) this.frmStudent_Load(sender,e);
                }
                catch { MessageBox.Show("你尚未选择相应条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            }
            else
            {
                MessageBox.Show("你尚未选择相应条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != -1)
            {
                frmRequestView fm1 = new frmRequestView();
                try
                {
                    fm1.id = dataGridView1.SelectedCells[0].Value.ToString();
                    fm1.stuID=stuNameValue.Text;
                    if (fm1.ShowDialog() == DialogResult.OK) this.frmStudent_Load(sender, e);
                }
                catch { MessageBox.Show("你尚未选择相应条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            }
            else {
                MessageBox.Show("你尚未选择相应条目","错误",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCorView fm1 = new frmCorView();
            fm1.corID = dataGridView2.SelectedCells[0].Value.ToString();
            fm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count != -1)
            {
                frmCorView fm1 = new frmCorView();
                try
                {
                    fm1.corID = dataGridView2.SelectedCells[0].Value.ToString();
                    fm1.Show();
                }
                catch { MessageBox.Show("你尚未选择相应条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            }
            else
            {
                MessageBox.Show("你尚未选择相应条目", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmReadPicture fm1 = new frmReadPicture();
            fm1.picture = pictureBox1.Image;
            fm1.Show();
        }
    }
}
