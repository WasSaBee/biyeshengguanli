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
    public partial class frmCorEdit : Form
    {
        public string corID;
        DBOperate operate = new DBOperate();
        public frmCorEdit()
        {
            InitializeComponent();
        }



        private void frmCorEdit_Load(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            DataSet ds = new DataSet();
            ds = operate.getTable("select * from corInfo where corID='" + corID + "'");
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
            operate.getCorImage(corID, pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operate.readImage(openFileDialog1, pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "openFileDialog1") { }
            else
            {
                operate.uploadImages(corID, openFileDialog1);
                MessageBox.Show("上传成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void corTelValue_TextChanged(object sender, EventArgs e)
        {
            long num;
            if (long.TryParse(corTelValue.Text.Trim(), out num) && corTelValue.Text.Length == 11)
            {
                corTelKey.BorderStyle = BorderStyle.None; corTelValue.ForeColor = Color.Black;
            }
            else
            {
                corTelValue.ForeColor = Color.Red; corTelKey.BorderStyle = BorderStyle.FixedSingle;
            }           
        }

        private void corPersonEmailValue_TextChanged(object sender, EventArgs e)
        {
            Nations n = new Nations();
            if (n.isEmail(corPersonEmailValue.Text))
            {
                corPersonEmailKey.BorderStyle = BorderStyle.None; corPersonEmailValue.ForeColor = Color.Black;
            }
            else {
                corPersonEmailKey.BorderStyle = BorderStyle.FixedSingle; corPersonEmailValue.ForeColor = Color.Red;
            }
        }

        private void corPersonTelValue_TextChanged(object sender, EventArgs e)
        {
            long num;
            if (long.TryParse(corPersonTelValue.Text.Trim(), out num) && corPersonTelValue.Text.Length == 11)
            {
                corPerSonTelKey.BorderStyle = BorderStyle.None; corPersonTelValue.ForeColor = Color.Black;
            }
            else
            {
                corPersonTelValue.ForeColor = Color.Red; corPerSonTelKey.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool crt = true;
            foreach (Control control in Controls) {
                if (control is TextBox) {
                    TextBox tb = (TextBox)control;
                    if (tb.Text.Trim() == "")
                        crt = false;
                }
                else if (control is Label) {
                    Label lb = (Label)control;
                    if (lb.BorderStyle == BorderStyle.FixedSingle) {
                        crt = false;
                    }
                }
            }
            if (crt == false)
            {
                MessageBox.Show("输入不正确或者还有未填项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                string updateStr = "update corInfo set ";
                updateStr += "corName='"+corNameValue.Text+"',";
                updateStr += "corResPerson='" + corResPersonValue.Text + "',";
                updateStr += "corRegAdd='" + corRegAddValue.Text + "',";
                updateStr += "corTel='" + corTelValue.Text + "',";
                updateStr += "corPerson='" + corPersonValue.Text + "',";
                updateStr += "corPersonTel='" + corPersonTelValue.Text + "',";
                updateStr += "corPersonEmail='" + corPersonEmailValue.Text + "',";
                updateStr += "corContinent='" + corConValue.Text + "',";
                updateStr += "corAdd='" + corAddValue.Text + "'where corID='"+corID+"'";
                int i=operate.sqlCmd(updateStr);
                if (i == 1)
                {
                    MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else {
                    MessageBox.Show("修改失败","失败",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
    }
}
