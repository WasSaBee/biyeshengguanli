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
    public partial class frmTeacher : Form
    {
        public string name;
        DBOperate operate = new DBOperate();
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {
            string str = "select stuID as '学号',stuName as '姓名',stuSex as '性别',stuNation as '民族',stuTel as '联系电话',stuAdd as '家庭住址' from stuInfo";
            operate.bindDataGridView(dataGridView1,str);
            str = "select id as '编号', reqType as '申请类型',reqDate as '提交日期',reqResult as '申核结果' from requestInfo where reqContent like '%"+name+"%'";
            operate.bindDataGridView(dataGridView2,str);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count!=-1) {
                frmStudentView fm1 = new frmStudentView();
                fm1.stuID = dataGridView1.SelectedCells[0].Value.ToString();
                fm1.isTeacher = true;
                fm1.teacherName = name;
                fm1.Show();
            }
        }

        private void frmTeacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F5) {
                button1_Click(sender,e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeacher_Load(sender,e);
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedCells.Count != -1) {
                frmRequestView fm1 = new frmRequestView();
                fm1.id = dataGridView2.SelectedCells[0].Value.ToString();
                fm1.Show();
            }
        }
    }
}
