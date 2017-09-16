using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BlueMax.DAL;
using BlueMax.Classes;
using System.Runtime.InteropServices;

namespace BlueMax
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        //private string _UserName { get; set; }
        //private string _Password { get; set; }
        private int _login = 0;

        public LoginForm()
        {
            InitializeComponent();

            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //_UserName = txtUserName.Text.Trim();
            //_Password = txtPassword.Text.Trim();

            LoggedInUser();

            //DbContext data = new DbContext();
            // _login = data.LookupUser(_UserName, _Password);
            
            //if (_login > 0)
            //{
            //    DialogResult = System.Windows.Forms.DialogResult.OK;
            //}
            //else
            //{
            //    XtraMessageBox.Show("Bilgiler Doğrulanamadı !\nLütfen Tekrar Deneyiniz.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private string NameIsNull(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "NULL";
            }
            else
            {
                return value;
            }
        }

        private void LoggedInUser()
        {
            string _UserName = NameIsNull(txtUserName.Text.TrimStart().TrimEnd());
            string _Password = NameIsNull(txtPassword.Text.TrimStart().TrimEnd());

            DbContext data = new DbContext();
            _login = data.LookupUser(_UserName, _Password);

            if (_login > 0)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show("Bilgiler Doğrulanamadı !\nLütfen Tekrar Deneyiniz.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter key pressed
                LoggedInUser();
            }
        }

        
    }
}