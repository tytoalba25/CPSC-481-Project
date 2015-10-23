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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GroupBox[] gB;
        private int currentScreen;
        private int previousScreen;

        public MainWindow()
        {
            InitializeComponent();
            currentScreen = 5;

            gB = new GroupBox[8];
            gB[0] = DrinkMenu;
            gB[1] = AppetizerMenu;
            gB[2] = EntreeMenu;
            gB[3] = MainMenu;
            gB[4] = DessertMenu;
            gB[5] = ViewOrder;
            gB[6] = ViewBill;
            gB[7] = MainHelpMenu;
        }

        private void displayHelp()
        {
            switch (currentScreen)
            {
                case(6) :
                    HelpText1.Content = "";
                    HelpText2.Content = "View order help";
                    break;
                case(7) :
                    HelpText1.Content = "";
                    HelpText2.Content = "View bill help";
                    break;
                default :
                    HelpText1.Content = "";
                    HelpText2.Content = "Menu help";
                    break;
            }
            displayGroupBox(7);
            
        }

        private void displayGroupBox(int index)
        {
            currentScreen = index;
            for(int i = 0; i < gB.Length; i++)
            {
                gB[i].Visibility = System.Windows.Visibility.Hidden;
                if (i == index)
                {
                    gB[i].Visibility = System.Windows.Visibility.Visible;
                }
            }
        }

        private void btn_ViewOrder_Click(object sender, RoutedEventArgs e)
        {
            displayGroupBox(5);
        }

        private void btn_CallWaiter_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn_Help_Click(object sender, RoutedEventArgs e)
        {
            displayHelp();
        }

        private void btn_ViewBill_Click(object sender, RoutedEventArgs e)
        {
            displayGroupBox(6);
        }

        private void btn_Drink_Click(object sender, RoutedEventArgs e)
        {
            displayGroupBox(0);
        }

        private void btn_Appetizer_Click(object sender, RoutedEventArgs e)
        {
            displayGroupBox(1);
        }

        private void btn_Entree_Click(object sender, RoutedEventArgs e)
        {
            displayGroupBox(2);
            
        }

        private void btn_Main_Click(object sender, RoutedEventArgs e)
        {
            displayGroupBox(3);
            
        }

        private void btn_Dessert_Click(object sender, RoutedEventArgs e)
        {
            displayGroupBox(4);
            
        }

        private void btn_GoBack_Click(object sender, RoutedEventArgs e)
        {
        }

    }
}
