namespace graduate_management
{
    partial class frmCorporation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorporation));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.corAuthValue = new System.Windows.Forms.Label();
            this.corAuthKey = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.corAddValue = new System.Windows.Forms.Label();
            this.corConValue = new System.Windows.Forms.Label();
            this.corTelValue = new System.Windows.Forms.Label();
            this.corRegAddValue = new System.Windows.Forms.Label();
            this.corResPersonValue = new System.Windows.Forms.Label();
            this.corNameValue = new System.Windows.Forms.Label();
            this.corIDValue = new System.Windows.Forms.Label();
            this.corAddKey = new System.Windows.Forms.Label();
            this.corConKey = new System.Windows.Forms.Label();
            this.corTelKey = new System.Windows.Forms.Label();
            this.corRegAddKey = new System.Windows.Forms.Label();
            this.corResPersonKey = new System.Windows.Forms.Label();
            this.corNameKey = new System.Windows.Forms.Label();
            this.corIDKey = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.corPersonValue = new System.Windows.Forms.Label();
            this.corPersonTelValue = new System.Windows.Forms.Label();
            this.corPersonEmailValue = new System.Windows.Forms.Label();
            this.corPersonEmailKey = new System.Windows.Forms.Label();
            this.corPerSonTelKey = new System.Windows.Forms.Label();
            this.corPersonKey = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reqTypeValue = new System.Windows.Forms.ComboBox();
            this.reqContentValue = new System.Windows.Forms.TextBox();
            this.reqContentKey = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.reqTypeKey = new System.Windows.Forms.Label();
            this.reqIDValue = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.corAuthValue);
            this.tabPage1.Controls.Add(this.corAuthKey);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(564, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "企业信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(378, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "刷新(F5)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "修改企业信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // corAuthValue
            // 
            this.corAuthValue.AutoSize = true;
            this.corAuthValue.Location = new System.Drawing.Point(93, 269);
            this.corAuthValue.Name = "corAuthValue";
            this.corAuthValue.Size = new System.Drawing.Size(0, 12);
            this.corAuthValue.TabIndex = 7;
            // 
            // corAuthKey
            // 
            this.corAuthKey.AutoSize = true;
            this.corAuthKey.Location = new System.Drawing.Point(7, 269);
            this.corAuthKey.Name = "corAuthKey";
            this.corAuthKey.Size = new System.Drawing.Size(77, 12);
            this.corAuthKey.TabIndex = 6;
            this.corAuthKey.Text = "是否认证企业";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.corAddValue);
            this.groupBox1.Controls.Add(this.corConValue);
            this.groupBox1.Controls.Add(this.corTelValue);
            this.groupBox1.Controls.Add(this.corRegAddValue);
            this.groupBox1.Controls.Add(this.corResPersonValue);
            this.groupBox1.Controls.Add(this.corNameValue);
            this.groupBox1.Controls.Add(this.corIDValue);
            this.groupBox1.Controls.Add(this.corAddKey);
            this.groupBox1.Controls.Add(this.corConKey);
            this.groupBox1.Controls.Add(this.corTelKey);
            this.groupBox1.Controls.Add(this.corRegAddKey);
            this.groupBox1.Controls.Add(this.corResPersonKey);
            this.groupBox1.Controls.Add(this.corNameKey);
            this.groupBox1.Controls.Add(this.corIDKey);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(449, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // corAddValue
            // 
            this.corAddValue.AutoSize = true;
            this.corAddValue.Location = new System.Drawing.Point(323, 76);
            this.corAddValue.Name = "corAddValue";
            this.corAddValue.Size = new System.Drawing.Size(11, 12);
            this.corAddValue.TabIndex = 15;
            this.corAddValue.Text = "1";
            // 
            // corConValue
            // 
            this.corConValue.AutoSize = true;
            this.corConValue.Location = new System.Drawing.Point(323, 48);
            this.corConValue.Name = "corConValue";
            this.corConValue.Size = new System.Drawing.Size(11, 12);
            this.corConValue.TabIndex = 14;
            this.corConValue.Text = "1";
            // 
            // corTelValue
            // 
            this.corTelValue.AutoSize = true;
            this.corTelValue.Location = new System.Drawing.Point(323, 21);
            this.corTelValue.Name = "corTelValue";
            this.corTelValue.Size = new System.Drawing.Size(11, 12);
            this.corTelValue.TabIndex = 13;
            this.corTelValue.Text = "1";
            // 
            // corRegAddValue
            // 
            this.corRegAddValue.AutoSize = true;
            this.corRegAddValue.Location = new System.Drawing.Point(87, 105);
            this.corRegAddValue.Name = "corRegAddValue";
            this.corRegAddValue.Size = new System.Drawing.Size(11, 12);
            this.corRegAddValue.TabIndex = 12;
            this.corRegAddValue.Text = "1";
            // 
            // corResPersonValue
            // 
            this.corResPersonValue.AutoSize = true;
            this.corResPersonValue.Location = new System.Drawing.Point(87, 76);
            this.corResPersonValue.Name = "corResPersonValue";
            this.corResPersonValue.Size = new System.Drawing.Size(11, 12);
            this.corResPersonValue.TabIndex = 11;
            this.corResPersonValue.Text = "1";
            // 
            // corNameValue
            // 
            this.corNameValue.AutoSize = true;
            this.corNameValue.Location = new System.Drawing.Point(87, 48);
            this.corNameValue.Name = "corNameValue";
            this.corNameValue.Size = new System.Drawing.Size(11, 12);
            this.corNameValue.TabIndex = 10;
            this.corNameValue.Text = "1";
            // 
            // corIDValue
            // 
            this.corIDValue.AutoSize = true;
            this.corIDValue.Location = new System.Drawing.Point(87, 21);
            this.corIDValue.Name = "corIDValue";
            this.corIDValue.Size = new System.Drawing.Size(11, 12);
            this.corIDValue.TabIndex = 9;
            this.corIDValue.Text = "1";
            // 
            // corAddKey
            // 
            this.corAddKey.AutoSize = true;
            this.corAddKey.Location = new System.Drawing.Point(217, 76);
            this.corAddKey.Name = "corAddKey";
            this.corAddKey.Size = new System.Drawing.Size(53, 12);
            this.corAddKey.TabIndex = 8;
            this.corAddKey.Text = "企业地址";
            // 
            // corConKey
            // 
            this.corConKey.AutoSize = true;
            this.corConKey.Location = new System.Drawing.Point(217, 48);
            this.corConKey.Name = "corConKey";
            this.corConKey.Size = new System.Drawing.Size(65, 12);
            this.corConKey.TabIndex = 7;
            this.corConKey.Text = "企业所在地";
            // 
            // corTelKey
            // 
            this.corTelKey.AutoSize = true;
            this.corTelKey.Location = new System.Drawing.Point(217, 21);
            this.corTelKey.Name = "corTelKey";
            this.corTelKey.Size = new System.Drawing.Size(53, 12);
            this.corTelKey.TabIndex = 6;
            this.corTelKey.Text = "企业电话";
            // 
            // corRegAddKey
            // 
            this.corRegAddKey.AutoSize = true;
            this.corRegAddKey.Location = new System.Drawing.Point(7, 105);
            this.corRegAddKey.Name = "corRegAddKey";
            this.corRegAddKey.Size = new System.Drawing.Size(53, 12);
            this.corRegAddKey.TabIndex = 5;
            this.corRegAddKey.Text = "注册地址";
            // 
            // corResPersonKey
            // 
            this.corResPersonKey.AutoSize = true;
            this.corResPersonKey.Location = new System.Drawing.Point(7, 76);
            this.corResPersonKey.Name = "corResPersonKey";
            this.corResPersonKey.Size = new System.Drawing.Size(65, 12);
            this.corResPersonKey.TabIndex = 4;
            this.corResPersonKey.Text = "企业注册人";
            // 
            // corNameKey
            // 
            this.corNameKey.AutoSize = true;
            this.corNameKey.Location = new System.Drawing.Point(7, 48);
            this.corNameKey.Name = "corNameKey";
            this.corNameKey.Size = new System.Drawing.Size(41, 12);
            this.corNameKey.TabIndex = 3;
            this.corNameKey.Text = "企业名";
            // 
            // corIDKey
            // 
            this.corIDKey.AutoSize = true;
            this.corIDKey.Location = new System.Drawing.Point(7, 21);
            this.corIDKey.Name = "corIDKey";
            this.corIDKey.Size = new System.Drawing.Size(53, 12);
            this.corIDKey.TabIndex = 2;
            this.corIDKey.Text = "企业编号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "查看营业执照";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.corPersonValue);
            this.groupBox2.Controls.Add(this.corPersonTelValue);
            this.groupBox2.Controls.Add(this.corPersonEmailValue);
            this.groupBox2.Controls.Add(this.corPersonEmailKey);
            this.groupBox2.Controls.Add(this.corPerSonTelKey);
            this.groupBox2.Controls.Add(this.corPersonKey);
            this.groupBox2.Location = new System.Drawing.Point(6, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 114);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "法人信息";
            // 
            // corPersonValue
            // 
            this.corPersonValue.AutoSize = true;
            this.corPersonValue.Location = new System.Drawing.Point(87, 30);
            this.corPersonValue.Name = "corPersonValue";
            this.corPersonValue.Size = new System.Drawing.Size(11, 12);
            this.corPersonValue.TabIndex = 12;
            this.corPersonValue.Text = "1";
            // 
            // corPersonTelValue
            // 
            this.corPersonTelValue.AutoSize = true;
            this.corPersonTelValue.Location = new System.Drawing.Point(87, 72);
            this.corPersonTelValue.Name = "corPersonTelValue";
            this.corPersonTelValue.Size = new System.Drawing.Size(11, 12);
            this.corPersonTelValue.TabIndex = 11;
            this.corPersonTelValue.Text = "1";
            // 
            // corPersonEmailValue
            // 
            this.corPersonEmailValue.AutoSize = true;
            this.corPersonEmailValue.Location = new System.Drawing.Point(381, 30);
            this.corPersonEmailValue.Name = "corPersonEmailValue";
            this.corPersonEmailValue.Size = new System.Drawing.Size(11, 12);
            this.corPersonEmailValue.TabIndex = 10;
            this.corPersonEmailValue.Text = "1";
            // 
            // corPersonEmailKey
            // 
            this.corPersonEmailKey.AutoSize = true;
            this.corPersonEmailKey.Location = new System.Drawing.Point(275, 30);
            this.corPersonEmailKey.Name = "corPersonEmailKey";
            this.corPersonEmailKey.Size = new System.Drawing.Size(53, 12);
            this.corPersonEmailKey.TabIndex = 8;
            this.corPersonEmailKey.Text = "电子邮箱";
            // 
            // corPerSonTelKey
            // 
            this.corPerSonTelKey.AutoSize = true;
            this.corPerSonTelKey.Location = new System.Drawing.Point(7, 72);
            this.corPerSonTelKey.Name = "corPerSonTelKey";
            this.corPerSonTelKey.Size = new System.Drawing.Size(53, 12);
            this.corPerSonTelKey.TabIndex = 7;
            this.corPerSonTelKey.Text = "联系电话";
            // 
            // corPersonKey
            // 
            this.corPersonKey.AutoSize = true;
            this.corPersonKey.Location = new System.Drawing.Point(7, 30);
            this.corPersonKey.Name = "corPersonKey";
            this.corPersonKey.Size = new System.Drawing.Size(53, 12);
            this.corPersonKey.TabIndex = 6;
            this.corPersonKey.Text = "法人姓名";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reqIDValue);
            this.tabPage2.Controls.Add(this.reqTypeKey);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.reqContentKey);
            this.tabPage2.Controls.Add(this.reqContentValue);
            this.tabPage2.Controls.Add(this.reqTypeValue);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(564, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "申请";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(564, 446);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "查看";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reqTypeValue
            // 
            this.reqTypeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reqTypeValue.FormattingEnabled = true;
            this.reqTypeValue.Location = new System.Drawing.Point(88, 6);
            this.reqTypeValue.Name = "reqTypeValue";
            this.reqTypeValue.Size = new System.Drawing.Size(121, 20);
            this.reqTypeValue.TabIndex = 0;
            // 
            // reqContentValue
            // 
            this.reqContentValue.Location = new System.Drawing.Point(6, 71);
            this.reqContentValue.Multiline = true;
            this.reqContentValue.Name = "reqContentValue";
            this.reqContentValue.Size = new System.Drawing.Size(552, 226);
            this.reqContentValue.TabIndex = 1;
            // 
            // reqContentKey
            // 
            this.reqContentKey.AutoSize = true;
            this.reqContentKey.Location = new System.Drawing.Point(6, 42);
            this.reqContentKey.Name = "reqContentKey";
            this.reqContentKey.Size = new System.Drawing.Size(53, 12);
            this.reqContentKey.TabIndex = 2;
            this.reqContentKey.Text = "申请内容";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "提交申请";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // reqTypeKey
            // 
            this.reqTypeKey.AutoSize = true;
            this.reqTypeKey.Location = new System.Drawing.Point(6, 9);
            this.reqTypeKey.Name = "reqTypeKey";
            this.reqTypeKey.Size = new System.Drawing.Size(53, 12);
            this.reqTypeKey.TabIndex = 4;
            this.reqTypeKey.Text = "申请类型";
            // 
            // reqIDValue
            // 
            this.reqIDValue.Location = new System.Drawing.Point(88, 39);
            this.reqIDValue.Name = "reqIDValue";
            this.reqIDValue.Size = new System.Drawing.Size(121, 21);
            this.reqIDValue.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(552, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // frmCorporation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 487);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCorporation";
            this.Text = "欢迎使用毕业生管理系统";
            this.Load += new System.EventHandler(this.frmCorporation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCorporation_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label corAuthValue;
        private System.Windows.Forms.Label corAuthKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label corAddValue;
        private System.Windows.Forms.Label corConValue;
        private System.Windows.Forms.Label corTelValue;
        private System.Windows.Forms.Label corRegAddValue;
        private System.Windows.Forms.Label corResPersonValue;
        private System.Windows.Forms.Label corNameValue;
        private System.Windows.Forms.Label corIDValue;
        private System.Windows.Forms.Label corAddKey;
        private System.Windows.Forms.Label corConKey;
        private System.Windows.Forms.Label corTelKey;
        private System.Windows.Forms.Label corRegAddKey;
        private System.Windows.Forms.Label corResPersonKey;
        private System.Windows.Forms.Label corNameKey;
        private System.Windows.Forms.Label corIDKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label corPersonValue;
        private System.Windows.Forms.Label corPersonTelValue;
        private System.Windows.Forms.Label corPersonEmailValue;
        private System.Windows.Forms.Label corPersonEmailKey;
        private System.Windows.Forms.Label corPerSonTelKey;
        private System.Windows.Forms.Label corPersonKey;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox reqTypeValue;
        private System.Windows.Forms.Label reqTypeKey;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label reqContentKey;
        private System.Windows.Forms.TextBox reqContentValue;
        private System.Windows.Forms.TextBox reqIDValue;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}