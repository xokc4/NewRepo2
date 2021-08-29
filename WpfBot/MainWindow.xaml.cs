using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBot
{
    /// <summary>
    /// тут присуствует авторизация пользователя и 2 кнопки первая переносит к форме регистрации и 2 кнопка переносит к  форме отправки сообщения 
    /// </summary>
    public partial class MainWindow : Window
    {

       
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void entrance_Click(object sender, RoutedEventArgs e)//кнопка для входа в окно регистрации
        {
            List<UsersBot> users = Form.RegistrForm.users;
            
            

            string login = Login.Text;// переменная для логина
            string password = Password.Password.ToString();//переменная для пароля

            foreach (var i in users)
            {
                if (login == i.login && password ==i.Password )//условие логина и пароля 
                {
                    Form.MessageForm messageForm = new Form.MessageForm();//создание формы
                    messageForm.Show();//открытие окна RegistrForm
                    Close();//закрытие окна MainWindow 
                }
                else
                {
                    MessageBox.Show("вы ввели не правильный логин или пароль");//вывод сообщения если логин или проль не правильный
                }
            }
                
        }

        private void Registr_Click(object sender, RoutedEventArgs e)//кнопка для входа в сообщения
        {
            Form.RegistrForm registrForm = new Form.RegistrForm();//создание формы
            registrForm.Show();//открытие окна RegistrForm
            Close();//закрытие окна MainWindow 
        }
    }
}
