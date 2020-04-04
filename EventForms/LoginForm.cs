using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventForms
{
    public partial class LoginForm : UserControl
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //登陆事件 
        public event Action<object, FormEvent> loginEvent;
        //注册事件
        public event Action<object, FormEvent> regEvent;
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormEvent formEvent = new FormEvent() { UserName = txtUserName.Text, Password = txtPwd.Text };
            loginEvent?.Invoke(this, formEvent);
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReg_Click(object sender, EventArgs e)
        {
            FormEvent formEvent = new FormEvent() { UserName = txtUserName.Text, Password = txtPwd.Text };
            regEvent?.Invoke(this, formEvent);
        }
    }
    public class FormEvent : EventArgs
    {
        public string UserName
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
    }
}
