using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMAIL_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
           
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                LINQCLASSDataContext db = new LINQCLASSDataContext();
                var item = SQLLogin.LOGIN(LoginBox.Text, PasswordBox.Text);
                if (item.Count() == 0)
                    MessageBox.Show("Bad login or password");
                else
                    MessageBox.Show("Successfull login "+item.FirstOrDefault().FirstName.ToString());
                           
            }
            catch (Exception)
            {
                throw;
               
            }
        }
    }
}
