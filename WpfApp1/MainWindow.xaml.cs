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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        items lick = new items();
        //поля для левого вехрнего блока
        PasswordBox passing = new PasswordBox();//поле пароля
        TextBox Login = new TextBox();//поле логина
        Button validate = new Button();//кнопка входа
        Button regizan = new Button();//кнопка регистрации
        Button exit = new Button();//кнопка выхода
        TextBlock Names1 = new TextBlock();//имя персонажа

        //кнопки левых менюх
        Button siencemake = new Button();// научная деятельность
        Button studymake = new Button();// образовательная деятельность
        Button socialmake = new Button();// образовательная деятельность
        Button assessement = new Button();// оценочные средства

        //поле верхней менюхи
        ComboBox topcontent = new ComboBox();

        string mes = System.Reflection.Assembly.GetEntryAssembly().Location;

        public MainWindow()
        {


            InitializeComponent();

            ImageBrush myimage = new ImageBrush();
            //создаем путь 
            
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource =  new Uri(@"pack://application:,,,/Resources/noimages.jpg", UriKind.RelativeOrAbsolute);
            bitmapImage.DecodePixelWidth = 100; //влияет на качество картинки, она более плавная
            bitmapImage.EndInit();



            
            myimage.ImageSource = bitmapImage;



            buttonicon.Background = myimage;

            //инициализируем экземпляр а дальше пихаем в форму
            


            regizan = lick.Regiz(regizan);//кнопка регистрации
            validate = lick.Vxod(validate);//кнопка входа
            Login = lick.Login(Login);//поле логина
            passing = lick.pass(passing);//поле пароля


            lefttopitem.Children.Add(regizan);// кнопка авторизации
            lefttopitem.Children.Add(Login);// поле для ввода логина
            lefttopitem.Children.Add(passing);// поле для ввода пароля
            lefttopitem.Children.Add(validate);//кнопка вход



            //выкидываем кнопки менюх в класс для придания им нормальной формы

            siencemake = lick.menumake(siencemake);
            studymake = lick.menumake(studymake);
            socialmake = lick.menumake(socialmake);
            assessement = lick.menumake(assessement);




            validate.Click += new RoutedEventHandler(vxodclick);//создание обработчика входа

            exit.Click += new RoutedEventHandler(exitVix);//обработчик выхода
            siencemake.Click += new RoutedEventHandler(siencemakeClick);//обработчик кнопки научная деятельность
            regizan.Click += new RoutedEventHandler(regizanClick);// обработчик для формы регистрации

        }




        private void vxodclick(object sender,RoutedEventArgs e)//непосредственно обработчик входа
        {
            if (passing.Password=="1"&& Login.Text =="1")
            {
                lefttopitem.Children.Remove(regizan);
                lefttopitem.Children.Remove(passing);
                lefttopitem.Children.Remove(validate);
                lefttopitem.Children.Remove(Login);

                
                Names1 = lick.NameL(Names1);
                lefttopitem.Children.Add(Names1);

                exit = lick.Ex(exit);
                lefttopitem.Children.Add(exit);


                siencemake.Content = "Научная деятельность";
                studymake.Content = "Образовательная деятельность";
                socialmake.Content = "Общественная деятельность";
                assessement.Content = "Оценочные средства";
                // построение менюх
                leftmenu.Children.Add(siencemake);
                leftmenu.Children.Add(studymake);
                leftmenu.Children.Add(socialmake);
                leftmenu.Children.Add(assessement);

                //смена картинки
                ImageBrush myimage = new ImageBrush();
                //создаем путь 
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(@"pack://application:,,,/Resources/matty-lasuire.jpg",UriKind.RelativeOrAbsolute);
                bitmapImage.DecodePixelWidth = 100; //влияет на качество картинки, она более плавная
                bitmapImage.EndInit();
                myimage.ImageSource = bitmapImage;
                buttonicon.Background = myimage;

            }

        }


        private void exitVix(object sender, RoutedEventArgs e)
        {
            ImageBrush myimage = new ImageBrush();
            //создаем путь 
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"pack://application:,,,/Resources/noimages.jpg", UriKind.RelativeOrAbsolute);
            bitmapImage.DecodePixelWidth = 100; //влияет на качество картинки, она более плавная
            bitmapImage.EndInit();
            myimage.ImageSource = bitmapImage;
            buttonicon.Background = myimage;


            lefttopitem.Children.Remove(exit);
            lefttopitem.Children.Remove(Names1);

            lefttopitem.Children.Add(regizan);// кнопка авторизации
            lefttopitem.Children.Add(Login);// поле для ввода логина
            lefttopitem.Children.Add(passing);// поле для ввода пароля
            lefttopitem.Children.Add(validate);//кнопка вход

            leftmenu.Children.RemoveRange(0,4);//УДАЛЕНИЕ ВСЕХ ЭЛЕМЕНТОВ
            

        }


        private void siencemakeClick(object sender, RoutedEventArgs e)//нажатие на кнопку научная деятельность
        {
           

            
        }

        private void regizanClick(object sender, RoutedEventArgs e)
        {

            TaskWindow reg = new TaskWindow();
            reg.Show();
            reg.Owner = this;//теперь окно taskwindow  принадлежит mainwindow
        }


        private void buttonicon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(mes);
        }




        /*        validate.Click += new RoutedEventHandler(validateclick); //обработчик для кнопки вход



private void validateclick(object sender, RoutedEventArgs e)
{
if (password.Password== "admin")
{

 MessageBox.Show("да ладно");

}
else
{
 MessageBox.Show("Гдето накосячил");

}


}











private void buttonicon_Click(object sender, RoutedEventArgs e)
{
MessageBox.Show("Не жмякай пока не доработал");

}
//обработчик

*/


    }
    }
