namespace graduate_management
{
    partial class frmRequestVerify
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequestVerify));
            this.reqTypeKey = new System.Windows.Forms.Label();
            this.reqTypeValue = new System.Windows.Forms.Label();
            this.stuIDKey = new System.Windows.Forms.Label();
            this.stuIDValue = new System.Windows.Forms.Label();
            this.reqContentKey = new System.Windows.Forms.Label();
            this.reqContentValue = new System.Windows.Forms.TextBox();
            this.reqResultKey = new System.Windows.Forms.Label();
            this.reqResultValue = new System.Windows.Forms.ComboBox();
            this.reqPeopleKey = new System.Windows.Forms.Label();
            this.timeNowKey = new System.Windows.Forms.Label();
            this.reqTimeValue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reqPeopleValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reqTypeKey
            // 
            this.reqTypeKey.AutoSize = true;
            this.reqTypeKey.Location = new System.Drawing.Point(13, 13);
            this.reqTypeKey.Name = "reqTypeKey";
            this.reqTypeKey.Size = new System.Drawing.Size(53, 12);
            this.reqTypeKey.TabIndex = 0;
            this.reqTypeKey.Text = "申核类型";
            // 
            // reqTypeValue
            // 
            this.reqTypeValue.AutoSize = true;
            this.reqTypeValue.Location = new System.Drawing.Point(82, 13);
            this.reqTypeValue.Name = "reqTypeValue";
            this.reqTypeValue.Size = new System.Drawing.Size(77, 12);
            this.reqTypeValue.TabIndex = 1;
            this.reqTypeValue.Text = "学生信息申核";
            // 
            // stuIDKey
            // 
            this.stuIDKey.AutoSize = true;
            this.stuIDKey.Location = new System.Drawing.Point(12, 47);
            this.stuIDKey.Name = "stuIDKey";
            this.stuIDKey.Size = new System.Drawing.Size(53, 12);
            this.stuIDKey.TabIndex = 2;
            this.stuIDKey.Text = "学生学号";
            // 
            // stuIDValue
            // 
            this.stuIDValue.AutoSize = true;
            this.stuIDValue.Location = new System.Drawing.Point(82, 47);
            this.stuIDValue.Name = "stuIDValue";
            this.stuIDValue.Size = new System.Drawing.Size(11, 12);
            this.stuIDValue.TabIndex = 3;
            this.stuIDValue.Text = "1";
            // 
            // reqContentKey
            // 
            this.reqContentKey.AutoSize = true;
            this.reqContentKey.Location = new System.Drawing.Point(13, 90);
            this.reqContentKey.Name = "reqContentKey";
            this.reqContentKey.Size = new System.Drawing.Size(53, 12);
            this.reqContentKey.TabIndex = 4;
            this.reqContentKey.Text = "申核详细";
            // 
            // reqContentValue
            // 
            this.reqContentValue.Location = new System.Drawing.Point(84, 87);
            this.reqContentValue.Multiline = true;
            this.reqContentValue.Name = "reqContentValue";
            this.reqContentValue.Size = new System.Drawing.Size(318, 177);
            this.reqContentValue.TabIndex = 5;
            // 
            // reqResultKey
            // 
            this.reqResultKey.AutoSize = true;
            this.reqResultKey.Location = new System.Drawing.Point(15, 284);
            this.reqResultKey.Name = "reqResultKey";
            this.reqResultKey.Size = new System.Drawing.Size(53, 12);
            this.reqResultKey.TabIndex = 6;
            this.reqResultKey.Text = "申核结果";
            // 
            // reqResultValue
            // 
            this.reqResultValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reqResultValue.FormattingEnabled = true;
            this.reqResultValue.Items.AddRange(new object[] {
            "资料属实",
            "资料不全",
            "资料不实"});
            this.reqResultValue.Location = new System.Drawing.Point(84, 281);
            this.reqResultValue.Name = "reqResultValue";
            this.reqResultValue.Size = new System.Drawing.Size(147, 20);
            this.reqResultValue.TabIndex = 7;
            // 
            // reqPeopleKey
            // 
            this.reqPeopleKey.AutoSize = true;
            this.reqPeopleKey.Location = new System.Drawing.Point(299, 411);
            this.reqPeopleKey.Name = "reqPeopleKey";
            this.reqPeopleKey.Size = new System.Drawing.Size(77, 12);
            this.reqPeopleKey.TabIndex = 8;
            this.reqPeopleKey.Text = "当前教师名为";
            // 
            // timeNowKey
            // 
            this.timeNowKey.AutoSize = true;
            this.timeNowKey.Location = new System.Drawing.Point(12, 411);
            this.timeNowKey.Name = "timeNowKey";
            this.timeNowKey.Size = new System.Drawing.Size(65, 12);
            this.timeNowKey.TabIndex = 9;
            this.timeNowKey.Text = "当前时间为";
            // 
            // reqTimeValue
            // 
            this.reqTimeValue.AutoSize = true;
            this.reqTimeValue.Location = new System.Drawing.Point(83, 411);
            this.reqTimeValue.Name = "reqTimeValue";
            this.reqTimeValue.Size = new System.Drawing.Size(11, 12);
            this.reqTimeValue.TabIndex = 10;
            this.reqTimeValue.Text = "1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reqPeopleValue
            // 
            this.reqPeopleValue.AutoSize = true;
            this.reqPeopleValue.Location = new System.Drawing.Point(382, 411);
            this.reqPeopleValue.Name = "reqPeopleValue";
            this.reqPeopleValue.Size = new System.Drawing.Size(11, 12);
            this.reqPeopleValue.TabIndex = 11;
            this.reqPeopleValue.Text = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "提交申核";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRequestVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reqPeopleValue);
            this.Controls.Add(this.reqTimeValue);
            this.Controls.Add(this.timeNowKey);
            this.Controls.Add(this.reqPeopleKey);
            this.Controls.Add(this.reqResultValue);
            this.Controls.Add(this.reqResultKey);
            this.Controls.Add(this.reqContentValue);
            this.Controls.Add(this.reqContentKey);
            this.Controls.Add(this.stuIDValue);
            this.Controls.Add(this.stuIDKey);
            this.Controls.Add(this.reqTypeValue);
            this.Controls.Add(this.reqTypeKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(858, 209);
            this.Name = "frmRequestVerify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "申核详细";
            this.Load += new System.EventHandler(this.frmRequestVerify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reqTypeKey;
        private System.Windows.Forms.Label reqTypeValue;
        private System.Windows.Forms.Label stuIDKey;
        private System.Windows.Forms.Label stuIDValue;
        private System.Windows.Forms.Label reqContentKey;
        private System.Windows.Forms.TextBox reqContentValue;
        private System.Windows.Forms.Label reqResultKey;
        private System.Windows.Forms.ComboBox reqResultValue;
        private System.Windows.Forms.Label reqPeopleKey;
        private System.Windows.Forms.Label timeNowKey;
        private System.Windows.Forms.Label reqTimeValue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label reqPeopleValue;
        private System.Windows.Forms.Button button1;
    }
}