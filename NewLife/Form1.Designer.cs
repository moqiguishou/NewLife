namespace NewLife {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.btn_test = new System.Windows.Forms.Button();
            this.txt_test = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.lab_year = new System.Windows.Forms.Label();
            this.lab_month = new System.Windows.Forms.Label();
            this.lab_day = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_test2 = new System.Windows.Forms.Button();
            this.lab_life = new System.Windows.Forms.Label();
            this.lab_enjoy = new System.Windows.Forms.Label();
            this.lab_up = new System.Windows.Forms.Label();
            this.comboBox_life = new System.Windows.Forms.ComboBox();
            this.txt_life = new System.Windows.Forms.TextBox();
            this.comboBox_enjoy = new System.Windows.Forms.ComboBox();
            this.comboBox_up = new System.Windows.Forms.ComboBox();
            this.txt_enjoy = new System.Windows.Forms.TextBox();
            this.txt_up = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(621, 55);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "button1";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // txt_test
            // 
            this.txt_test.Location = new System.Drawing.Point(432, 84);
            this.txt_test.Multiline = true;
            this.txt_test.Name = "txt_test";
            this.txt_test.Size = new System.Drawing.Size(343, 96);
            this.txt_test.TabIndex = 1;
            this.txt_test.TextChanged += new System.EventHandler(this.txt_test_TextChanged);
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(638, 204);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(100, 21);
            this.txt_2.TabIndex = 2;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(35, 401);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(100, 21);
            this.txt_year.TabIndex = 3;
            // 
            // txt_month
            // 
            this.txt_month.Location = new System.Drawing.Point(184, 401);
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(100, 21);
            this.txt_month.TabIndex = 4;
            // 
            // txt_day
            // 
            this.txt_day.Location = new System.Drawing.Point(353, 401);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(100, 21);
            this.txt_day.TabIndex = 5;
            // 
            // lab_year
            // 
            this.lab_year.AutoSize = true;
            this.lab_year.Location = new System.Drawing.Point(12, 404);
            this.lab_year.Name = "lab_year";
            this.lab_year.Size = new System.Drawing.Size(17, 12);
            this.lab_year.TabIndex = 6;
            this.lab_year.Text = "年";
            // 
            // lab_month
            // 
            this.lab_month.AutoSize = true;
            this.lab_month.Location = new System.Drawing.Point(161, 404);
            this.lab_month.Name = "lab_month";
            this.lab_month.Size = new System.Drawing.Size(17, 12);
            this.lab_month.TabIndex = 7;
            this.lab_month.Text = "月";
            // 
            // lab_day
            // 
            this.lab_day.AutoSize = true;
            this.lab_day.Location = new System.Drawing.Point(330, 404);
            this.lab_day.Name = "lab_day";
            this.lab_day.Size = new System.Drawing.Size(17, 12);
            this.lab_day.TabIndex = 8;
            this.lab_day.Text = "日";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // btn_test2
            // 
            this.btn_test2.Location = new System.Drawing.Point(382, 305);
            this.btn_test2.Name = "btn_test2";
            this.btn_test2.Size = new System.Drawing.Size(75, 23);
            this.btn_test2.TabIndex = 9;
            this.btn_test2.Text = "btn_test2";
            this.btn_test2.UseVisualStyleBackColor = true;
            this.btn_test2.Click += new System.EventHandler(this.btn_test2_Click);
            // 
            // lab_life
            // 
            this.lab_life.AutoSize = true;
            this.lab_life.Location = new System.Drawing.Point(25, 55);
            this.lab_life.Name = "lab_life";
            this.lab_life.Size = new System.Drawing.Size(53, 12);
            this.lab_life.TabIndex = 10;
            this.lab_life.Text = "生活必须";
            // 
            // lab_enjoy
            // 
            this.lab_enjoy.AutoSize = true;
            this.lab_enjoy.Location = new System.Drawing.Point(25, 159);
            this.lab_enjoy.Name = "lab_enjoy";
            this.lab_enjoy.Size = new System.Drawing.Size(53, 12);
            this.lab_enjoy.TabIndex = 11;
            this.lab_enjoy.Text = "享受生活";
            // 
            // lab_up
            // 
            this.lab_up.AutoSize = true;
            this.lab_up.Location = new System.Drawing.Point(25, 265);
            this.lab_up.Name = "lab_up";
            this.lab_up.Size = new System.Drawing.Size(53, 12);
            this.lab_up.TabIndex = 12;
            this.lab_up.Text = "阿祖进阶";
            // 
            // comboBox_life
            // 
            this.comboBox_life.FormattingEnabled = true;
            this.comboBox_life.Items.AddRange(new object[] {
            "早餐",
            "午餐",
            "晚餐",
            "每月固定消费"});
            this.comboBox_life.Location = new System.Drawing.Point(93, 55);
            this.comboBox_life.Name = "comboBox_life";
            this.comboBox_life.Size = new System.Drawing.Size(121, 20);
            this.comboBox_life.TabIndex = 13;
            this.comboBox_life.SelectedIndex = 0;
            // 
            // txt_life
            // 
            this.txt_life.Location = new System.Drawing.Point(236, 55);
            this.txt_life.Name = "txt_life";
            this.txt_life.Size = new System.Drawing.Size(100, 21);
            this.txt_life.TabIndex = 14;
            // 
            // comboBox_enjoy
            // 
            this.comboBox_enjoy.FormattingEnabled = true;
            this.comboBox_enjoy.Location = new System.Drawing.Point(93, 159);
            this.comboBox_enjoy.Name = "comboBox_enjoy";
            this.comboBox_enjoy.Size = new System.Drawing.Size(121, 20);
            this.comboBox_enjoy.TabIndex = 15;
            this.comboBox_enjoy.Items.AddRange(new object[] {
            "夜宵",
            "运动",
            "游戏",
            "服装",
            "其他"});
            this.comboBox_enjoy.SelectedIndex = 0;
            // 
            // comboBox_up
            // 
            this.comboBox_up.FormattingEnabled = true;
            this.comboBox_up.Location = new System.Drawing.Point(93, 265);
            this.comboBox_up.Name = "comboBox_up";
            this.comboBox_up.Size = new System.Drawing.Size(121, 20);
            this.comboBox_up.TabIndex = 16;
            this.comboBox_up.Items.AddRange(new object[] {
            "大厨",
            "手工",
            "其他"});
            this.comboBox_up.SelectedIndex = 0;
            // 
            // txt_enjoy
            // 
            this.txt_enjoy.Location = new System.Drawing.Point(236, 157);
            this.txt_enjoy.Name = "txt_enjoy";
            this.txt_enjoy.Size = new System.Drawing.Size(100, 21);
            this.txt_enjoy.TabIndex = 17;
            // 
            // txt_up
            // 
            this.txt_up.Location = new System.Drawing.Point(236, 263);
            this.txt_up.Name = "txt_up";
            this.txt_up.Size = new System.Drawing.Size(100, 21);
            this.txt_up.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_up);
            this.Controls.Add(this.txt_enjoy);
            this.Controls.Add(this.comboBox_up);
            this.Controls.Add(this.comboBox_enjoy);
            this.Controls.Add(this.txt_life);
            this.Controls.Add(this.comboBox_life);
            this.Controls.Add(this.lab_up);
            this.Controls.Add(this.lab_enjoy);
            this.Controls.Add(this.lab_life);
            this.Controls.Add(this.btn_test2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_day);
            this.Controls.Add(this.lab_month);
            this.Controls.Add(this.lab_year);
            this.Controls.Add(this.txt_day);
            this.Controls.Add(this.txt_month);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_test);
            this.Controls.Add(this.btn_test);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.TextBox txt_test;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_month;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.Label lab_year;
        private System.Windows.Forms.Label lab_month;
        private System.Windows.Forms.Label lab_day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_test2;
        private System.Windows.Forms.Label lab_life;
        private System.Windows.Forms.Label lab_enjoy;
        private System.Windows.Forms.Label lab_up;
        private System.Windows.Forms.ComboBox comboBox_life;
        private System.Windows.Forms.TextBox txt_life;
        private System.Windows.Forms.ComboBox comboBox_enjoy;
        private System.Windows.Forms.ComboBox comboBox_up;
        private System.Windows.Forms.TextBox txt_enjoy;
        private System.Windows.Forms.TextBox txt_up;
    }
}

