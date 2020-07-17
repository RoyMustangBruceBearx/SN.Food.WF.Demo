using SN.Food.WF.Demo.ComConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SN.Food.WF.Demo
{
    public partial class FormMain : Form
    {
       /// <summary>
        /// 窗体的初始化函数
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormComConfig formComConfig = new FormComConfig();
            formComConfig.Show();
        }
        

    }
}
