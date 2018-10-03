namespace graduate_management
{
    partial class frmAccountAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountAdd));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.userAuthValue = new System.Windows.Forms.ComboBox();
            this.userPwdValue = new System.Windows.Forms.TextBox();
            this.IDValue = new System.Windows.Forms.TextBox();
            this.userNameValue = new System.Windows.Forms.TextBox();
            this.userIDValue = new System.Windows.Forms.TextBox();
            this.IDKey = new System.Windows.Forms.Label();
            this.userNameKey = new System.Windows.Forms.Label();
            this.userPwdKey = new System.Windows.Forms.Label();
            this.userAuthKey = new System.Windows.Forms.Label();
            this.userIDKey = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.startStuIDValue = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.startStuIDKey = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(230, 284);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.userAuthValue);
            this.tabPage1.Controls.Add(this.userPwdValue);
            this.tabPage1.Controls.Add(this.IDValue);
            this.tabPage1.Controls.Add(this.userNameValue);
            this.tabPage1.Controls.Add(this.userIDValue);
            this.tabPage1.Controls.Add(this.IDKey);
            this.tabPage1.Controls.Add(this.userNameKey);
            this.tabPage1.Controls.Add(this.userPwdKey);
            this.tabPage1.Controls.Add(this.userAuthKey);
            this.tabPage1.Controls.Add(this.userIDKey);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(222, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "单个帐号新增";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "提交";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userAuthValue
            // 
            this.userAuthValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userAuthValue.FormattingEnabled = true;
            this.userAuthValue.Items.AddRange(new object[] {
            "教师",
            "企业",
            "毕业生",
            "管理"});
            this.userAuthValue.Location = new System.Drawing.Point(80, 119);
            this.userAuthValue.Name = "userAuthValue";
            this.userAuthValue.Size = new System.Drawing.Size(100, 20);
            this.userAuthValue.TabIndex = 9;
            // 
            // userPwdValue
            // 
            this.userPwdValue.Location = new System.Drawing.Point(80, 81);
            this.userPwdValue.Name = "userPwdValue";
            this.userPwdValue.Size = new System.Drawing.Size(100, 21);
            this.userPwdValue.TabIndex = 8;
            // 
            // IDValue
            // 
            this.IDValue.Location = new System.Drawing.Point(80, 160);
            this.IDValue.Name = "IDValue";
            this.IDValue.Size = new System.Drawing.Size(100, 21);
            this.IDValue.TabIndex = 7;
            // 
            // userNameValue
            // 
            this.userNameValue.Location = new System.Drawing.Point(80, 46);
            this.userNameValue.Name = "userNameValue";
            this.userNameValue.Size = new System.Drawing.Size(100, 21);
            this.userNameValue.TabIndex = 6;
            this.userNameValue.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // userIDValue
            // 
            this.userIDValue.Location = new System.Drawing.Point(80, 4);
            this.userIDValue.Name = "userIDValue";
            this.userIDValue.Size = new System.Drawing.Size(100, 21);
            this.userIDValue.TabIndex = 5;
            this.userIDValue.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // IDKey
            // 
            this.IDKey.AutoSize = true;
            this.IDKey.Location = new System.Drawing.Point(7, 163);
            this.IDKey.Name = "IDKey";
            this.IDKey.Size = new System.Drawing.Size(29, 12);
            this.IDKey.TabIndex = 4;
            this.IDKey.Text = "编号";
            // 
            // userNameKey
            // 
            this.userNameKey.AutoSize = true;
            this.userNameKey.Location = new System.Drawing.Point(7, 49);
            this.userNameKey.Name = "userNameKey";
            this.userNameKey.Size = new System.Drawing.Size(41, 12);
            this.userNameKey.TabIndex = 3;
            this.userNameKey.Text = "用户名";
            // 
            // userPwdKey
            // 
            this.userPwdKey.AutoSize = true;
            this.userPwdKey.Location = new System.Drawing.Point(7, 84);
            this.userPwdKey.Name = "userPwdKey";
            this.userPwdKey.Size = new System.Drawing.Size(53, 12);
            this.userPwdKey.TabIndex = 2;
            this.userPwdKey.Text = "用户密码";
            // 
            // userAuthKey
            // 
            this.userAuthKey.AutoSize = true;
            this.userAuthKey.Location = new System.Drawing.Point(7, 122);
            this.userAuthKey.Name = "userAuthKey";
            this.userAuthKey.Size = new System.Drawing.Size(53, 12);
            this.userAuthKey.TabIndex = 1;
            this.userAuthKey.Text = "用户权限";
            // 
            // userIDKey
            // 
            this.userIDKey.AutoSize = true;
            this.userIDKey.Location = new System.Drawing.Point(7, 7);
            this.userIDKey.Name = "userIDKey";
            this.userIDKey.Size = new System.Drawing.Size(53, 12);
            this.userIDKey.TabIndex = 0;
            this.userIDKey.Text = "用户编号";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.startStuIDValue);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.startStuIDKey);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(222, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "批量新增帐号";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "批量新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startStuIDValue
            // 
            this.startStuIDValue.Location = new System.Drawing.Point(105, 174);
            this.startStuIDValue.Name = "startStuIDValue";
            this.startStuIDValue.Size = new System.Drawing.Size(100, 21);
            this.startStuIDValue.TabIndex = 9;
            this.startStuIDValue.Visible = false;
            this.startStuIDValue.TextChanged += new System.EventHandler(this.startStuIDValue_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "毕业生",
            "企业"});
            this.comboBox1.Location = new System.Drawing.Point(105, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // startStuIDKey
            // 
            this.startStuIDKey.AutoSize = true;
            this.startStuIDKey.Location = new System.Drawing.Point(22, 177);
            this.startStuIDKey.Name = "startStuIDKey";
            this.startStuIDKey.Size = new System.Drawing.Size(0, 12);
            this.startStuIDKey.TabIndex = 4;
            this.startStuIDKey.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "帐号初始密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "帐号结束编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "帐号起始编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "帐号权限";
            // 
            // frmAccountAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 301);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccountAdd";
            this.Text = "新增帐号";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox startStuIDValue;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label startStuIDKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDKey;
        private System.Windows.Forms.Label userNameKey;
        private System.Windows.Forms.Label userPwdKey;
        private System.Windows.Forms.Label userAuthKey;
        private System.Windows.Forms.Label userIDKey;
        private System.Windows.Forms.ComboBox userAuthValue;
        private System.Windows.Forms.TextBox userPwdValue;
        private System.Windows.Forms.TextBox IDValue;
        private System.Windows.Forms.TextBox userNameValue;
        private System.Windows.Forms.TextBox userIDValue;
        private System.Windows.Forms.Button button2;
    }
}