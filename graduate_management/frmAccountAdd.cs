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
    public partial class frmAccountAdd : Form
    {
        DBOperate operate = new DBOperate();
        public frmAccountAdd()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "毕业生")
            {
                startStuIDKey.Text = "起始学号";
                startStuIDValue.Visible = true;
            }
            else if (comboBox1.Text == "企业")
            {
                startStuIDKey.Text = "起始企业编号";
                startStuIDValue.Visible = true;
            }
            else {
                startStuIDKey.Text = " ";
                startStuIDValue.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { bool crt = true;
            int count = 0;
            int fail = 0;
            foreach (Control control in Controls) {
                if (control is Label) {
                    Label lb = (Label)control;
                    if (lb.BorderStyle == BorderStyle.FixedSingle) crt = false;
                }
            }
            if (crt == true) {
                int num1=0, num2=0;
                int.TryParse(textBox1.Text, out num1);
                int.TryParse(textBox2.Text,out num2);
                for (int i = num1; i< num2; ++i) {
                    if (comboBox1.Text == "毕业生") {
                        int num3;
                        int.TryParse(startStuIDValue.Text, out num3);
                        string str = "insert into stuInfo(stuID)values('" + (num3 + i - num1).ToString() + "')";
                        int n = operate.sqlCmd(str);
                        if (n == 1)
                        {
                            str = "insert into userInfo(userID,userName,userPwd,userAuth,stuID)values('";
                            str += i.ToString() + "','";
                            str += (num3 + i - num1).ToString() + "','";
                            str += textBox3.Text + "','";
                            str += "student','";
                            str += (num3 + i - num1).ToString() + "')";
                            n = operate.sqlCmd(str);
                            if (n == 1) ++count;
                            else ++fail;
                        }
                        else {
                            ++fail;
                        }
                    }
                    else if (comboBox1.Text=="企业") {
                        int num3;
                        int.TryParse(startStuIDValue.Text, out num3);
                        string str = "insert into corInfo(corID)values('" + (num3 + i - num1).ToString() + "')";
                        int n = operate.sqlCmd(str);
                        if (n == 1)
                        {
                            str = "insert into userInfo(userID,userName,userPwd,userAuth,corID)values('";
                            str += i.ToString() + "','";
                            str += (num3 + i - num1).ToString() + "','";
                            str += textBox3.Text + "','";
                            str += "corporation','";
                            str += (num3 + i - num1).ToString() + "')";
                            n = operate.sqlCmd(str);
                            if (n == 1) ++count;
                            else ++fail;
                        }
                        else
                        {
                            ++fail;
                        }
                    }
                }
                MessageBox.Show("共插入" + count.ToString() + "条记录,失败" + fail.ToString() + "条", "插入完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(textBox1.Text, out num))
            {
                DataTable dt = new DataTable();
                string str = "select * from userInfo where userID ='" + textBox1.Text + "'";
                dt = operate.getTables(str);
                int i = dt.Rows.Count;
                dt.Dispose();
                if (i > 0)
                {
                    textBox1.ForeColor = Color.Red;
                    label2.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    textBox1.ForeColor = Color.Black;
                    label2.BorderStyle = BorderStyle.None;
                }
            }
            else {
                textBox1.ForeColor = Color.Red;
                label2.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int num1, num2,num;
            if (int.TryParse(textBox2.Text, out num))
            {
                DataTable dt = new DataTable();
                string str = "select * from userInfo where userID ='" + textBox2.Text + "'";
                dt = operate.getTables(str);
                int i = dt.Rows.Count;
                dt.Dispose();
                if (i > 0)
                {
                    textBox2.ForeColor = Color.Red;
                    label3.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    textBox2.ForeColor = Color.Black;
                    label3.BorderStyle = BorderStyle.None;
                }
                if (int.TryParse(textBox1.Text, out num1))
                {
                    int.TryParse(textBox2.Text, out num2);
                    if (num2 <= num1)
                    {
                        textBox2.ForeColor = Color.Red;
                        label3.BorderStyle = BorderStyle.FixedSingle;
                    }
                    else
                    {
                        textBox2.ForeColor = Color.Black;
                        label3.BorderStyle = BorderStyle.None;
                    }
                }
            }
            else {
                textBox2.ForeColor = Color.Red;
                label3.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void startStuIDValue_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(startStuIDValue.Text, out num)) {
                DataTable dt = new DataTable();
                string str = "select * from userInfo where stuID ='" + startStuIDValue.Text + "'";
                dt = operate.getTables(str);
                int i = dt.Rows.Count;
                dt.Dispose();
                if (i > 0)
                {
                    startStuIDValue.ForeColor = Color.Red;
                    startStuIDKey.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    startStuIDValue.ForeColor = Color.Black;
                    startStuIDKey.BorderStyle = BorderStyle.None;
                }
            }
            else {
                startStuIDValue.ForeColor = Color.Red;
                startStuIDKey.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string str = "select * from userInfo where userID='"+userIDValue.Text+"'";
            DataTable dt = operate.getTables(str);
            if (dt.Rows.Count > 0)
            {
                userIDKey.BorderStyle = BorderStyle.FixedSingle;
                userIDValue.ForeColor = Color.Red;
            }
            else {
                userIDKey.BorderStyle = BorderStyle.None;
                userIDValue.ForeColor = Color.Black;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string str = "select * from userInfo where userName='" + userNameValue.Text + "'";
            DataTable dt = operate.getTables(str);
            if (dt.Rows.Count > 0)
            {
                userNameKey.BorderStyle = BorderStyle.FixedSingle;
                userNameValue.ForeColor = Color.Red;
            }
            else
            {
                userNameKey.BorderStyle = BorderStyle.None;
                userNameValue.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool crt = true;
            if (userIDValue.Text.Trim()!=""&&userNameValue.Text.Trim()!=""&&userPwdValue.Text.Trim()!=""&&userAuthValue.Text.Trim()!=""&&IDValue.Text.Trim()!="") {
                {
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
                        string insertStr = "insert into userInfo(userID,userName,userPwd,userAuth,";
                        switch (userAuthValue.Text) {
                            case "毕业生":insertStr += "stuID)values('"; break;
                            case "企业": insertStr += "corID)values('"; break;
                            case "教师": insertStr += "teaName)values('"; break;
                            case "管理": insertStr += "admName)values('"; break;
                        }
                        insertStr += userIDValue.Text + "','";
                        insertStr += userNameValue.Text + "','";
                        insertStr += userPwdValue.Text + "','";
                        switch (userAuthValue.Text)
                        {
                            case "毕业生": insertStr += "student','"; break;
                            case "企业": insertStr += "corporation','"; break;
                            case "教师": insertStr += "teacher','"; break;
                            case "管理": insertStr += "admin','"; break;
                        }
                        insertStr += IDValue.Text + "')";
                        int i = operate.sqlCmd(insertStr);
                        if (i == 1) {
                            MessageBox.Show("新建成功","成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            foreach (Control control in Controls)
                            {
                                if (control is TextBox)
                                {
                                    control.Text = "";
                                }
                            }
                        }
                        else
                            MessageBox.Show("新建失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("数据不正确或者不完整", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
