using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp1
{
    class items
    {

        public Button Regiz(Button regiz)
        {

            regiz.Height = 20;
            regiz.Width = 85;
            regiz.Content = "Регистрация";
            Canvas.SetLeft(regiz, 175);
            Canvas.SetTop(regiz, 75);

            return regiz;
        }
        public Button Vxod(Button validate)
        {

            validate.Height = 20;
            validate.Width = 70;
            validate.Content = "Войти";
            Canvas.SetLeft(validate, 100);
            Canvas.SetTop(validate, 75);
            return validate;
        }

        public TextBox Login(TextBox login)
        {
            login.Width = 160;
            login.Height = 20;
            Canvas.SetLeft(login, 100);
            Canvas.SetTop(login, 20);

            return login;
        }

        public PasswordBox pass(PasswordBox pasl)
        {

            pasl.Width = 160;
            pasl.Height = 20;
            Canvas.SetLeft(pasl, 100);
            Canvas.SetTop(pasl, 50);

            return pasl;
        }

        public TextBlock NameL(TextBlock name )
        {
            name.Background = new SolidColorBrush(Colors.Aqua);
           
            name.Text = "Админыч";
            Canvas.SetLeft(name, 100);
            Canvas.SetTop(name, 20);
            return name;
        }

        public Button Ex(Button exit)
        {
            exit.Width = 80;
            exit.Height = 20;
            Canvas.SetTop(exit,110);
            Canvas.SetLeft(exit,10);
            exit.Content = "Выйти";
            return exit; 
        }


        public Button menumake (Button maker)
        {
            maker.MinHeight = 40;
            maker.Opacity = 0.8;
            maker.Margin = new Thickness(5);
            maker.Background = new SolidColorBrush(Colors.LightBlue);


            return maker;
        }

        //компоновка элементов при нажатии на научная деятельность
        public ComboBoxItem science(ComboBoxItem ler)
        {


            return ler;
        }



    } 
       

    }