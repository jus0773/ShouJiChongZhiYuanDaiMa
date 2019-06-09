namespace ChongZhi.李俊__权限
{
    partial class DengLu
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
            this.bt_denglu = new System.Windows.Forms.Button();
            this.bt_qingkong = new System.Windows.Forms.Button();
            this.bt_quxiao = new System.Windows.Forms.Button();
            this.cbb_shenfen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_zhanghao = new System.Windows.Forms.TextBox();
            this.tb_mima = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_denglu
            // 
            this.bt_denglu.Location = new System.Drawing.Point(37, 241);
            this.bt_denglu.Name = "bt_denglu";
            this.bt_denglu.Size = new System.Drawing.Size(59, 23);
            this.bt_denglu.TabIndex = 0;
            this.bt_denglu.Text = "登录";
            this.bt_denglu.UseVisualStyleBackColor = true;
            // 
            // bt_qingkong
            // 
            this.bt_qingkong.Location = new System.Drawing.Point(141, 241);
            this.bt_qingkong.Name = "bt_qingkong";
            this.bt_qingkong.Size = new System.Drawing.Size(59, 23);
            this.bt_qingkong.TabIndex = 1;
            this.bt_qingkong.Text = "清空";
            this.bt_qingkong.UseVisualStyleBackColor = true;
            this.bt_qingkong.Click += new System.EventHandler(this.bt_qingkong_Click);
            // 
            // bt_quxiao
            // 
            this.bt_quxiao.Location = new System.Drawing.Point(245, 241);
            this.bt_quxiao.Name = "bt_quxiao";
            this.bt_quxiao.Size = new System.Drawing.Size(59, 23);
            this.bt_quxiao.TabIndex = 2;
            this.bt_quxiao.Text = "取消";
            this.bt_quxiao.UseVisualStyleBackColor = true;
            this.bt_quxiao.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbb_shenfen
            // 
            this.cbb_shenfen.FormattingEnabled = true;
            this.cbb_shenfen.Items.AddRange(new object[] {
            "营销人员"});
            this.cbb_shenfen.Location = new System.Drawing.Point(108, 117);
            this.cbb_shenfen.Name = "cbb_shenfen";
            this.cbb_shenfen.Size = new System.Drawing.Size(185, 20);
            this.cbb_shenfen.TabIndex = 3;
            this.cbb_shenfen.Text = "请选择登录者身份";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "账号：";
            // 
            // tb_zhanghao
            // 
            this.tb_zhanghao.Location = new System.Drawing.Point(104, 42);
            this.tb_zhanghao.Name = "tb_zhanghao";
            this.tb_zhanghao.Size = new System.Drawing.Size(189, 21);
            this.tb_zhanghao.TabIndex = 5;
            // 
            // tb_mima
            // 
            this.tb_mima.Location = new System.Drawing.Point(108, 192);
            this.tb_mima.Name = "tb_mima";
            this.tb_mima.Size = new System.Drawing.Size(185, 21);
            this.tb_mima.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "身份：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "密码：";
            // 
            // DengLu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 285);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_mima);
            this.Controls.Add(this.tb_zhanghao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_shenfen);
            this.Controls.Add(this.bt_quxiao);
            this.Controls.Add(this.bt_qingkong);
            this.Controls.Add(this.bt_denglu);
            this.Name = "DengLu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                     请登录……";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_denglu;
        private System.Windows.Forms.Button bt_qingkong;
        private System.Windows.Forms.Button bt_quxiao;
        private System.Windows.Forms.ComboBox cbb_shenfen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_zhanghao;
        private System.Windows.Forms.TextBox tb_mima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}