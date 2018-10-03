using graduate_management.GMclass;
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

namespace graduate_management
{
    public partial class frmLogin : Form
    {
        DBOperate operate = new DBOperate();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (userName.Text.Trim() == "" || userPwd.Text.Trim() == "")
                {
                    MessageBox.Show("用户名或密码不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    return;
                }
                else
                {
                    SqlConnection conn = DBConnections.conn();
                    conn.Open();
                    string sqlStr = "select * from userInfo where userName='" + userName.Text.Trim() + "' and userPwd='" + userPwd.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    if (sdr.HasRows)
                    {
                        DataSet ds =operate.getTable(sqlStr);
                        ds.Dispose();
                        string auth = ds.Tables[0].Rows[0][4].ToString();
                        string time = DateTime.Now.ToString();
                        sqlStr = "update userInfo set LastLogin='" + time + "' where UserName='" + userName.Text + "'";
                        operate.sqlCmd(sqlStr);
                        conn.Close();
                        switch (auth) {
                            case "admin":
                                MessageBox.Show("登陆成功，您是系统管理", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmAdmin fm1 = new frmAdmin();
                                fm1.name = ds.Tables[0].Rows[0][7].ToString();
                                fm1.Show();
                                break;
                            case "student":
                                MessageBox.Show("登陆成功，您是学生用户", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmStudent fm2 = new frmStudent();
                                fm2.stuID = ds.Tables[0].Rows[0][5].ToString();
                                fm2.Show();
                                break;
                            case "teacher":
                                MessageBox.Show("登陆成功，您是教师用户", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmTeacher fm3 = new frmTeacher();
                                fm3.name = ds.Tables[0].Rows[0][8].ToString();
                                fm3.Show();
                                break;
                            case "corporation":
                                MessageBox.Show("登陆成功，您是企业用户","成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                frmCorporation fm4 = new frmCorporation();
                                fm4.corID = ds.Tables[0].Rows[0][6].ToString();
                                fm4.Show();
                                break;
                        }
                        this.Hide();
                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("登陆失败,请检查帐号或密码是否正确","登录失败",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        userPwd.Clear();
                    }
                }
            }
            catch {
                MessageBox.Show("错误","错误",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            }
    }
}
