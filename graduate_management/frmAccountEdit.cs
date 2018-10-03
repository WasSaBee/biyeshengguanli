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
    public partial class frmAccountEdit : Form
    {
        public string userID;
        DBOperate operate = new DBOperate();
        public frmAccountEdit()
        {
            InitializeComponent();
        }

        private void frmAccountEdit_Load(object sender, EventArgs e)
        {
            string str = "select * from userInfo where userID='"+userID+"'";
            DataSet ds = operate.getTable(str);
            ds.Dispose();
            userIDValue.Text = userID;
            IDValue.Text = ds.Tables[0].Rows[0][0].ToString();
            userNameValue.Text = ds.Tables[0].Rows[0][2].ToString();
            userPwdValue.Text = ds.Tables[0].Rows[0][3].ToString();
            switch (ds.Tables[0].Rows[0][4].ToString()) {
                case "student":userAuthValue.Text = "毕业生"; break;
                case "teacher": userAuthValue.Text = "教师"; break;
                case "corporation": userAuthValue.Text = "企业"; break;
                case "admin": userAuthValue.Text = "管理"; break;
                default:break;
            }
            stuIDValue.Text = ds.Tables[0].Rows[0][5].ToString();
            corIDValue.Text = ds.Tables[0].Rows[0][6].ToString();
            adNameValue.Text = ds.Tables[0].Rows[0][7].ToString();
            teaNameValue.Text = ds.Tables[0].Rows[0][8].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool crt = true;
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    Label lb = (Label)control;
                    if (lb.BorderStyle == BorderStyle.FixedSingle)
                    {
                        crt = false; break;
                    }
                }
            }
            if (crt == true)
            {
                if (userPwdValue.Text.Trim() != "")
                {
                    string updateStr = "update userInfo set ";
                    updateStr += "userPwd='" + userPwdValue.Text + "',";
                    switch (userAuthValue.Text)
                    {
                        case "毕业生": updateStr += "userAuth='student',"; break;
                        case "教师": updateStr += "userAuth='teacher',"; break;
                        case "企业": updateStr += "userAuth='corporation',"; break;
                        case "管理": updateStr += "userAuth='admin',"; break;
                        default: break;
                    }
                    switch (userAuthValue.Text)
                    {
                        case "毕业生": updateStr += "stuID='" + stuIDValue.Text + "'"; break;
                        case "教师": updateStr += "teaName='" + teaNameValue.Text + "'"; break;
                        case "企业": updateStr += "corID='" + corIDValue.Text + "'"; break;
                        case "管理": updateStr += "admName='" + adNameValue.Text + "'"; break;
                        default: break;
                    }
                    updateStr += "where userID='"+userID+"'";
                    int i=operate.sqlCmd(updateStr);
                    if (i == 1)
                    {
                        MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        MessageBox.Show("修改失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("信息不完整或不正确", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void userAuthValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (userAuthValue.Text)
            {
                case "毕业生": {
                        if (stuIDValue.Text.Trim() == "")
                        {
                            stuIDKey.BorderStyle = BorderStyle.FixedSingle;
                            stuIDValue.ForeColor = Color.Red;
                        }
                        else {
                            string str = "select * from stuInfo where stuID ='" + stuIDValue.Text + "'";
                            DataTable dt = operate.getTables(str);
                            int i = dt.Rows.Count;
                            dt.Dispose();
                            if (i <= 0)
                            {
                                stuIDValue.ForeColor = Color.Red;
                                stuIDKey.BorderStyle = BorderStyle.FixedSingle;
                            }
                            else
                            {
                                stuIDValue.ForeColor = Color.Black;
                                stuIDKey.BorderStyle = BorderStyle.None;
                            }
                        }
                        break; }
                case "教师": {
                        if (teaNameValue.Text.Trim() == "")
                        {
                            teaNameKey.BorderStyle = BorderStyle.FixedSingle;
                            teaNameValue.ForeColor = Color.Red;
                        }
                        else {
                            teaNameKey.BorderStyle = BorderStyle.None;
                            teaNameValue.ForeColor = Color.Black;
                        }
                        break; }
                case "企业":
                    {
                        if (corIDValue.Text.Trim() == "")
                        {
                            corIDKey.BorderStyle = BorderStyle.FixedSingle;
                            corIDValue.ForeColor = Color.Red;
                        }
                        else
                        {
                            string str = "select * from corInfo where corID ='" + corIDValue.Text + "'";
                            DataTable dt = operate.getTables(str);
                            int i = dt.Rows.Count;
                            dt.Dispose();
                            if (i <= 0)
                            {
                                corIDValue.ForeColor = Color.Red;
                                corIDKey.BorderStyle = BorderStyle.FixedSingle;
                            }
                            else
                            {
                                corIDValue.ForeColor = Color.Black;
                                corIDKey.BorderStyle = BorderStyle.None;
                            }
                        }
                        break;
                    }
                case "管理":
                    {
                        if (adNameValue.Text.Trim() == "")
                        {
                            adNameKey.BorderStyle = BorderStyle.FixedSingle;
                            adNameValue.ForeColor = Color.Red;
                        }
                        else
                        {
                            adNameKey.BorderStyle = BorderStyle.None;
                            adNameValue.ForeColor = Color.Black;
                        }
                        break;
                    }
                default: break;
            }
        }

        private void stuIDValue_TextChanged(object sender, EventArgs e)
        {if(userAuthValue.Text=="毕业生")
            if (stuIDValue.Text.Trim() == "")
            {
                stuIDKey.BorderStyle = BorderStyle.FixedSingle;
                stuIDValue.ForeColor = Color.Red;
            }
            else
            {
                string str = "select * from stuInfo where stuID ='" + stuIDValue.Text + "'";
                DataTable dt = operate.getTables(str);
                int i = dt.Rows.Count;
                dt.Dispose();
                if (i <= 0)
                {
                    stuIDValue.ForeColor = Color.Red;
                    stuIDKey.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    stuIDValue.ForeColor = Color.Black;
                    stuIDKey.BorderStyle = BorderStyle.None;
                }
            }
        }

        private void corIDValue_TextChanged(object sender, EventArgs e)
        {
            if(userAuthValue.Text=="企业")
            if (corIDValue.Text.Trim() == "")
            {
                corIDKey.BorderStyle = BorderStyle.FixedSingle;
                corIDValue.ForeColor = Color.Red;
            }
            else
            {
                string str = "select * from corInfo where corID ='" + corIDValue.Text + "'";
                DataTable dt = operate.getTables(str);
                int i = dt.Rows.Count;
                dt.Dispose();
                if (i <= 0)
                {
                    corIDValue.ForeColor = Color.Red;
                    corIDKey.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    corIDValue.ForeColor = Color.Black;
                    corIDKey.BorderStyle = BorderStyle.None;
                }
            }
        }

        private void adNameValue_TextChanged(object sender, EventArgs e)
        {
            if(userAuthValue.Text=="管理")
            if (adNameValue.Text.Trim() == "")
            {
                adNameKey.BorderStyle = BorderStyle.FixedSingle;
                adNameValue.ForeColor = Color.Red;
            }
            else
            {
                adNameKey.BorderStyle = BorderStyle.None;
                adNameValue.ForeColor = Color.Black;
            }
        }

        private void teaNameValue_TextChanged(object sender, EventArgs e)
        {
            if(userAuthValue.Text=="教师")
            if (teaNameValue.Text.Trim() == "")
            {
                teaNameKey.BorderStyle = BorderStyle.FixedSingle;
                teaNameValue.ForeColor = Color.Red;
            }
            else
            {
                teaNameKey.BorderStyle = BorderStyle.None;
                teaNameValue.ForeColor = Color.Black;
            }
        }
    }
}
