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
    public partial class frmReadPicture : Form
    {
        public Image picture;
        DBOperate operate = new DBOperate();
        public frmReadPicture()
        {
            InitializeComponent();
        }

        private void frmReadPicture_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = picture;
        }
    }
}
