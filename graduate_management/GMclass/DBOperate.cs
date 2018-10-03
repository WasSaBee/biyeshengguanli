using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graduate_management.GMclass
{
    class DBOperate
    {
        SqlConnection conn = DBConnections.conn();
        public int sqlCmd(string sqlStr) {
            int i;
            SqlCommand cmd = new SqlCommand(sqlStr,conn);
            conn.Open();
            try
            {
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i;
            }
            catch(SqlException) {
                i = 0;
                conn.Close();
                return i;
            }
        }
        public DataSet getTable(string str) {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(str, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                ds.Dispose();
                return ds;
            }
        
            catch
            {
                DataSet ds = new DataSet();
                ds = null;
                return ds;
            }
        }
        public DataTable getTables(string str)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(str, conn);
                DataTable ds = new DataTable();
                sda.Fill(ds);
                ds.Dispose();
                return ds;
            }

            catch
            {
                DataTable ds = new DataTable();
                ds = null;
                return ds;
            }
        }
        public void getImage(string id,PictureBox p) {
            byte[] image = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM stuInfo where stuID='" + id + "'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read()) {
                if (sdr.GetValue(2).ToString() != "") 
                    image = (byte[])sdr.GetValue(2);
            }
            sdr.Close();conn.Close();
            if (image != null)
            {
                MemoryStream ms = new MemoryStream(image);
                Bitmap bm = new Bitmap(ms);
                p.Image = bm;
            }
            else
                p.Image = null;
        }
        public void bindDataGridView(DataGridView dgv1,string s) {
            SqlDataAdapter sda = new SqlDataAdapter(s, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv1.DataSource = ds.Tables[0];
            ds.Dispose();
            sda.Dispose();
        }
        public void readImage(OpenFileDialog ofd,PictureBox p) {
            ofd.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK) {
                try {
                    p.Image = Image.FromFile(ofd.FileName);
                } catch {
                    MessageBox.Show("图片读取失败","失败",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
        public void uploadImage(string id,OpenFileDialog ofd) {
            string str = ofd.FileName;
            FileStream fs = new FileStream(str,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imgBytesIn = br.ReadBytes((int)fs.Length);
            conn.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("update stuInfo Set stuImg= @Photo where stuID = '" + id + "'");
            SqlCommand cmd = new SqlCommand(sb.ToString(),conn);
            cmd.Parameters.Add("@Photo",SqlDbType.Binary).Value=imgBytesIn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void uploadImages(string id, OpenFileDialog ofd)
        {
            string str = ofd.FileName;
            FileStream fs = new FileStream(str, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imgBytesIn = br.ReadBytes((int)fs.Length);
            conn.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("update corInfo Set corQuality= @Photo where corID = '" + id + "'");
            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            cmd.Parameters.Add("@Photo", SqlDbType.Binary).Value = imgBytesIn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void imageView(string pic, PictureBox p) {
            byte[] image = null;
            for(int i=0;i<pic.Length;i++)
            byte.TryParse(pic[i].ToString(),out image[i]);
            if (image != null)
            {
                MemoryStream ms = new MemoryStream(image);
                Bitmap bm = new Bitmap(ms);
                p.Image = bm;
            }
            else
                p.Image = null;
        }
        public void getCorImage(string id, PictureBox p)
        {
            byte[] image = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM corInfo where corID='" + id + "'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                if (sdr.GetValue(10).ToString() != "")
                    image = (byte[])sdr.GetValue(10);
            }
            sdr.Close(); conn.Close();
            if (image != null)
            {
                MemoryStream ms = new MemoryStream(image);
                Bitmap bm = new Bitmap(ms);
                p.Image = bm;
            }
            else
                p.Image = null;
        }
    }
}
