using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChongZhi.李俊__权限
{
    public partial class DengLu : Form
    {
        public DengLu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_qingkong_Click(object sender, EventArgs e)
        {
            tb_mima.Clear();
            tb_zhanghao.Clear();
            cbb_shenfen.Text = "请选择登录者身份";
        }
    }
}
