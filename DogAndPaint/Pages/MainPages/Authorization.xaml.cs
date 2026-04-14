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
            TextAuthorizationL.FontSize = Logic.TextSize.TextSizeLogic(10);
            LoginText.FontSize = Logic.TextSize.TextSizeLogic(30);
            PasswordText.FontSize = Logic.TextSize.TextSizeLogic(30);
        }
    }
}
