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
    public partial class frmStudentEdit : Form
    {
        public string stuID;
        DBOperate operate = new DBOperate();
        Nations n = new Nations();
        public frmStudentEdit()
        {
            InitializeComponent();
        }
        private void frmStudentEdit_FormClosed(object sender,EventArgs e) {
            this.DialogResult = DialogResult.OK;
        }
        private void frmStudentEdit_Load(object sender, EventArgs e)
        {
            stuIDValue.Text = stuID;
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
        }

        private void stuNationValue_TextChanged(object sender, EventArgs e)
        {
          
            if (n.isNations(stuNationValue.Text.Trim()) == false)
            {
                stuNationKey.BorderStyle = BorderStyle.FixedSingle; stuNationValue.ForeColor = Color.Red;
            }
            else {
                stuNationKey.BorderStyle = BorderStyle.None; stuNationValue.ForeColor = Color.Black;
            }
        }

        private void stuPoliValue_TextChanged(object sender, EventArgs e)
        {
            if (n.isPoliticians(stuPoliValue.Text.Trim()) == false)
            {
                stuPoliKey.BorderStyle = BorderStyle.FixedSingle; stuPoliValue.ForeColor = Color.Red;
            }
            else {
                stuPoliKey.BorderStyle = BorderStyle.None; stuPoliValue.ForeColor = Color.Black;
            }
        }

        private void stuIDCValue_TextChanged(object sender, EventArgs e)
        {
            long num;
            if (stuIDCValue.Text.Trim()!=""&&stuIDCValue.Text[stuIDCValue.Text.Length - 1].ToString() != "X")
                if (long.TryParse(stuIDCValue.Text.Trim(), out num) && stuIDCValue.Text.Length == 18)
                {
                    if (n.isIDCard(stuIDCValue.Text.Trim()) == true)
                    {
                        stuIDCKey.BorderStyle = BorderStyle.None; stuIDCValue.ForeColor = Color.Black;
                    }
                    else
                    {
                        stuIDCKey.BorderStyle = BorderStyle.FixedSingle; stuIDCValue.ForeColor = Color.Red;
                    }


                }
                else
                {
                    stuIDCKey.BorderStyle = BorderStyle.FixedSingle; stuIDCValue.ForeColor = Color.Red;
                }
            else if (stuIDCValue.Text.Length == 18)
            {
                if (n.isIDCard(stuIDCValue.Text.Trim()) == true)
                {
                    stuIDCKey.BorderStyle = BorderStyle.None; stuIDCValue.ForeColor = Color.Black;
                }
                else
                {
                    stuIDCKey.BorderStyle = BorderStyle.FixedSingle; stuIDCValue.ForeColor = Color.Red;
                }
            }
            else {
                stuIDCKey.BorderStyle = BorderStyle.FixedSingle; stuIDCValue.ForeColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operate.readImage(openFileDialog1,pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "openFileDialog1") { }
            else
            {
                operate.uploadImage(stuID, openFileDialog1);
                MessageBox.Show("上传成功","成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            bool crtT = true;
            foreach (Control control in Controls) {
                if (control is Label) {
                    Label lb = (Label)control;
                    if (lb.BorderStyle == BorderStyle.FixedSingle) crtT = false;
                }
            }
            if (crtT == true)
            {
                string updateStr = "update stuInfo set ";
                updateStr += "stuName='" + stuNameValue.Text + "',";
                updateStr += "stuFmrName='" + stuFmrNameValue.Text + "',";
                updateStr += "stuSex='" + stuSexValue.Text + "',";
                updateStr += "stuBirth='" + stuBirthValue.Text + "',";
                updateStr += "stuNation='" + stuNationValue.Text + "',";
                updateStr += "stuPoli='" + stuPoliValue.Text + "',";
                updateStr += "stuRes='" + stuResValue.Text + "',";
                updateStr += "stuIDNum='" + stuIDCValue.Text + "',";
                updateStr += "stuWorkPlace='" + stuWorkPlaceValue.Text + "',";
                updateStr += "workPC='" + stuPCValue.Text + "',";
                updateStr += "workTel='" + stuWorkTelValue.Text + "',";
                updateStr += "stuAdd='" + stuAddValue.Text + "',";
                updateStr += "stuTel='" + stuTelValue.Text + "',";
                updateStr += "stuExp='" + stuExpValue.Text + "',";
                updateStr += "stuPrzCrt='" + stuPrzCrtValue.Text + "' where stuID='" + stuID + "'";
                int i = operate.sqlCmd(updateStr);
                if (i == 1) { MessageBox.Show("上传成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    
                }
                else MessageBox.Show("上传失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("数据不正确","错误",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void stuBirthValue_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - stuBirthValue.Value;
            if (ts.Days > 0)          
                stuBirthKey.BorderStyle = BorderStyle.None;          
            else
                stuBirthKey.BorderStyle = BorderStyle.FixedSingle;
        }

        private void stuPCValue_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(stuPCValue.Text.Trim(), out num) && stuPCValue.Text.Length==6)
            {
                stuPCKey.BorderStyle = BorderStyle.None; stuPCValue.ForeColor = Color.Black;
            }
            else {
                stuPCValue.ForeColor = Color.Red;stuPCKey.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void stuWorkTelValue_TextChanged(object sender, EventArgs e)
        {
            long num;
            if (long.TryParse(stuWorkTelValue.Text.Trim(), out num)&&stuWorkTelValue.Text.Length==11)
            {
                stuWorkTelKey.BorderStyle = BorderStyle.None; stuWorkTelValue.ForeColor = Color.Black;
            }
            else
            {
                stuWorkTelValue.ForeColor = Color.Red; stuWorkTelKey.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void stuTelValue_TextChanged(object sender, EventArgs e)
        {
            long num;
            if (long.TryParse(stuTelValue.Text.Trim(), out num)&&stuTelValue.Text.Length==11)
            {
                stuTelKey.BorderStyle = BorderStyle.None; stuTelValue.ForeColor = Color.Black;
            }
            else
            {
                stuTelValue.ForeColor = Color.Red; stuTelKey.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void frmStudentEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
