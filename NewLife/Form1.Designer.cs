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
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(314, 114);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "button1";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // txt_test
            // 
            this.txt_test.Location = new System.Drawing.Point(188, 190);
            this.txt_test.Multiline = true;
            this.txt_test.Name = "txt_test";
            this.txt_test.Size = new System.Drawing.Size(343, 96);
            this.txt_test.TabIndex = 1;
            this.txt_test.TextChanged += new System.EventHandler(this.txt_test_TextChanged);
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(219, 299);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(100, 21);
            this.txt_2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

