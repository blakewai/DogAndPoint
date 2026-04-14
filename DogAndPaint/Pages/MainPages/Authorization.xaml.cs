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

namespace DogAndPower.Pages.MainPages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Page_LayoutUpdated(object sender, EventArgs e)
        {
            var info = Application.Current.MainWindow as MainWindow;
            if (info != null)
            {
                info.InformationTextBlock.Text = $"{Convert.ToInt32(LoginTB.ActualHeight)}/{Convert.ToInt32(LoginTB.ActualWidth)} - Данные по TextBox \n" +
                                                 $"{info.ActualHeight}/{info.ActualWidth} Данные по MainWindows";
            }
            TextAuthorizationL.FontSize = Logic.Size.TextSizeLogic(10);
            LoginText.FontSize = Logic.Size.TextSizeLogic(30);
            PasswordText.FontSize = Logic.Size.TextSizeLogic(30);
            Logic.Size.TextBoxLogic(30, LoginTB, 40, 20);
            Logic.Size.TextPasswordLogic(30, PasswordPB, 40, 20);
        }
    }
}
