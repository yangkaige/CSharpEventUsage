using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登陆窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginForm1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 主窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            loginForm1.loginEvent += Login;
            loginForm1.regEvent += Register;
        }
        /// <summary>
        /// 登陆事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Login(object sender, FormEvent e)
        {
            if (e.UserName == "admin"&& e.Password == "1234")
            {
                (sender as LoginForm).BackColor = Color.Green;
                MessageBox.Show("登陆成功!");
            }
            else
            {
                (sender as LoginForm).BackColor = Color.Red;
                MessageBox.Show("登陆失败!");
            }
        }
        /// <summary>
        /// 注册事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Register(object sender, FormEvent e)
        {
            MessageBox.Show("注册");
        }
    }
}
