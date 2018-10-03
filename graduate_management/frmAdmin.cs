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
    public partial class frmAdmin : Form
    {
        DBOperate operate = new DBOperate();
        public string name;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            string str = "select id as '编号',userID as '用户编号',userName as '用户名',userAuth as '用户权限',lastLogin as '上次登陆时间'from userInfo";
            operate.bindDataGridView(dataGridView1,str);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = "select id as '编号',userID as '用户编号',userName as '用户名',userAuth as '用户权限',lastLogin as '上次登陆时间'from userInfo where userID like '%"+textBox1.Text+"%'";
            operate.bindDataGridView(dataGridView1, str);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string str = "select id as '编号',userID as '用户编号',userName as '用户名',userAuth as '用户权限',lastLogin as '上次登陆时间'from userInfo where userName like '%" + textBox2.Text + "%'";
            operate.bindDataGridView(dataGridView1, str);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string usrType;
            switch (comboBox1.Text) {
                case "毕业生":usrType = "student";break;
                case "教师":usrType = "teacher";break;
                case "企业":usrType = "corporation";break;
                case "管理员":usrType = "admin";break;
                default:return;
            }
            string str = "select id as '编号',userID as '用户编号',userName as '用户名',userAuth as '用户权限',lastLogin as '上次登陆时间'from userInfo where userAuth= '" +usrType+ "'";
            operate.bindDataGridView(dataGridView1, str);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != -1) {
                frmAccountEdit fm1 = new frmAccountEdit();
                fm1.userID = dataGridView1.SelectedCells[1].Value.ToString();
                fm1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAccountAdd fm1 = new frmAccountAdd();
            fm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != -1)
            {
                frmAccountEdit fm1 = new frmAccountEdit();
                fm1.userID = dataGridView1.SelectedCells[1].Value.ToString();
                fm1.Show();
            }
        }
    }
}
