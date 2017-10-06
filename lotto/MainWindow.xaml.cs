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

namespace lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int Min = 1;
            int Max = 52;
        
            //initials new random object
            Random randomNumbers = new Random();

            int lottoNumbers = randomNumbers.Next(1, 52);
            int lottoBonusNumber = randomNumbers.Next(1, 52);

            int[] lottoArray = new int[7];

            for (int arrayPos = 0; arrayPos < lottoArray.Length; arrayPos++)
            {
                lottoArray[arrayPos] = randomNumbers.Next(Min, Max);
            }
            tbx0.Text = Convert.ToString(lottoArray.GetValue(0));
            tbx1.Text = Convert.ToString(lottoArray.GetValue(1));
            tbx2.Text = Convert.ToString(lottoArray.GetValue(2));
            tbx3.Text = Convert.ToString(lottoArray.GetValue(3));
            tbx4.Text = Convert.ToString(lottoArray.GetValue(4));
            tbx5.Text = Convert.ToString(lottoArray.GetValue(5));
            tbx6.Text = Convert.ToString(lottoArray.GetValue(6));
            tbxBonus.Text = Convert.ToString(lottoBonusNumber);
        }

        private void btnUK_Click(object sender, RoutedEventArgs e)
        {
            int Min = 1;
            int Max = 58;

            //initials new random object
            Random randomNumbers = new Random();

            int lottoNumbers = randomNumbers.Next(1, 52);
            int lottoBonusNumber = randomNumbers.Next(1, 52);
            int[] lottoArray = new int[7];

            for (int arrayPos = 0; arrayPos < lottoArray.Length; arrayPos++)
            {
                lottoArray[arrayPos] = randomNumbers.Next(Min, Max);
            }
            tbx0.Text = Convert.ToString(lottoArray.GetValue(0));
            tbx1.Text = Convert.ToString(lottoArray.GetValue(1));
            tbx2.Text = Convert.ToString(lottoArray.GetValue(2));
            tbx3.Text = Convert.ToString(lottoArray.GetValue(3));
            tbx4.Text = Convert.ToString(lottoArray.GetValue(4));
            tbx5.Text = Convert.ToString(lottoArray.GetValue(5));
            tbx6.Text = Convert.ToString(lottoArray.GetValue(6));
            tbxBonus.Text = Convert.ToString(lottoBonusNumber);
        }
    }
}

