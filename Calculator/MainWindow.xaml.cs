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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Function C;
        public const double PI = 3.141592653589793;
        public const double E = 2.7182818284;

     

        private void CorrectNumber()
        {
            //Если есть знак "бесконечность" - не даёт писать цифры после него
            if (lblNumber.Text.IndexOf("∞") != -1)
                lblNumber.Text = lblNumber.Text.Substring(0, lblNumber.Text.Length - 1);

            //Округление
            if (lblNumber.Text[0] == '0' && (lblNumber.Text.IndexOf(",") != 1))
                lblNumber.Text = lblNumber.Text.Remove(0, 1);

            //Округление для отрицательного числа
            if (lblNumber.Text[0] == '-')
                if (lblNumber.Text[1] == '0' && (lblNumber.Text.IndexOf(",") != 2))
                    lblNumber.Text = lblNumber.Text.Remove(1, 1);
        }

        public MainWindow()
        {
            InitializeComponent();

            C = new Function();
            lblNumber.Text = "0";
        }


        private void btnE_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += Convert.ToString(E);
            CorrectNumber();
        }

        private void btnClear_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text = "0";

            C.Clear_A();
        }

        private void btnNumTochka_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((lblNumber.Text.IndexOf(",") == -1) && (lblNumber.Text.IndexOf("∞") == -1))
            {
                lblNumber.Text += ".";
            }
                
        }

        private void btnPi_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += Convert.ToString(PI);
            CorrectNumber();
        }

        private void btnNum7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += "7";
            CorrectNumber();
        }

        private void btnNum8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += "8";
            CorrectNumber();
        }

        private void btnNum9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += "9";
            CorrectNumber();
        }

        private void btnNum4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += "4";
            CorrectNumber();
        }

        private void btnNum5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += "5";
            CorrectNumber();
        }

        private void btnNum6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += "6";
            CorrectNumber();
        }

        private void btnNum1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += "1";
            CorrectNumber();
        }

        private void btnNum2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += "2";
            CorrectNumber();
        }

        private void btnNum3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += "3";
            CorrectNumber();
        }

        private void btnNum0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += "0";
            CorrectNumber();
        }

        private void btnNumRavno_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
                lblNumber.Text = C.Multiplication(Convert.ToDouble(lblNumber.Text)).ToString();

                lblNumber.Text = C.Division(Convert.ToDouble(lblNumber.Text)).ToString();

                lblNumber.Text = C.Sum(Convert.ToDouble(lblNumber.Text)).ToString();

                lblNumber.Text = C.Subtraction(Convert.ToDouble(lblNumber.Text)).ToString();

        }

        private void btnNumSkobka1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += "(";
        }

        private void btnNumSkobka2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += ")";
        }

        private void btnSin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnDeg_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnNumDelit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            C.Put_A(Convert.ToDouble(lblNumber.Text));

            lblNumber.Text += "/";
        }

        private void btnNumMulti_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            C.Put_A(Convert.ToDouble(lblNumber.Text));

            lblNumber.Text += "х";
        }

        private void btnNumMinus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lblNumber.Text += "-";
            C.Put_A(Convert.ToDouble(lblNumber.Text));
        }

        private void btnNumPlus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            C.Put_A(Convert.ToDouble(lblNumber.Text));

            lblNumber.Text += "+";
        }
    }
}
