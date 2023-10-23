using OOOtkaniDemo.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOOtkaniDemo.forms
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (modelDB model = new modelDB())
                {
                    users userObj = model.users.Where(i => i.login.Equals(loginTextBox.Text) && i.password.Equals(passwordTextBox.Text)).FirstOrDefault();
                    if (userObj != null)
                    {
                        MessageBox.Show("Вы вошли как " + userObj.roles.name);
                        FormGoods goods = new FormGoods(userObj.roles.name);
                        goods.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет соединения с базой данных");
            }
        }

        private void noAuthButton_Click(object sender, EventArgs e)
        {
            FormGoods goods = new FormGoods("Клиент");
            goods.Show();
            Hide();
        }
    }
}
