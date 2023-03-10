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

namespace Genshin_Puzzle_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int num1;
        private int num2;
        private int num3;
        private int num4;
        

        public MainWindow()
        {
            InitializeComponent();

            RandomizeNumbers();

            
        }

        //randomizes all buttons
        private void startClick(object sender, RoutedEventArgs e)
        {
            RandomizeNumbers();

        }


        //buttons to play the game
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            num1 = num1 + 1;
            num2 = num2 + 1;
            num3 = num3 + 1;



            if (num1 == 4)
            {
                num1 = 1;
            }

            if (num2 == 4)
            {
                num2 = 1;
            }

            if (num3 == 4)
            {
                num3 = 1;
            }

            button1.Content = num1;
            button2.Content = num2;
            button3.Content = num3;
            WinCondition();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            num1 = num1 + 1;
            num2 = num2 + 1;
            num4 = num4 + 1;



            if (num1 == 4)
            {
                num1 = 1;
            }

            if (num2 == 4)
            {
                num2 = 1;
            }

            if (num4 == 4)
            {
                num4 =1;
            }

            button1.Content = num1;
            button2.Content = num2;
            button4.Content = num4;
            WinCondition();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            num1 = num1 + 1;
            num3 = num3 + 1;
            num4 = num4 + 1;



            if (num1 == 4)
            {
                num1 = 1;
            }

            if (num3 == 4)
            {
                num3 = 1;
            }

            if (num4 == 4)
            {
                num4 = 1;
            }

            button1.Content = num1;
            button3.Content = num3;
            button4.Content = num4;
            WinCondition();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            num3 = num3 + 1;
            num2 = num2 + 1;
            num4 = num4 + 1;



            if (num3 == 4)
            {
                num3 = 1;
            }

            if (num2 == 4)
            {
                num2 = 1;
            }

            if (num4 == 4)
            {
                num4 = 1;
            }

            button3.Content = num3;
            button2.Content = num2;
            button4.Content = num4;

            WinCondition();
        }


        //randomizes all buttons
        private void RandomizeNumbers()
        {
            Random randomNum = new Random();
             num1 = randomNum.Next(1, 4);
             num2 = randomNum.Next(1, 4);
             num3 = randomNum.Next(1, 4);
             num4 = randomNum.Next(1, 4);

            button1.Content = num1;
            button2.Content = num2;
            button3.Content = num3;
            button4.Content = num4;
        }

        private void WinCondition()
        {

            if (num1== num2 && num2 == num3 && num3 ==num4) 
            {
                MessageBox.Show("Congratulations, you won!");
            }
            RandomizeNumbers();
        }
        
        

        
    }
}
