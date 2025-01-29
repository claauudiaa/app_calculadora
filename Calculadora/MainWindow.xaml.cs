using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DLLTest;

namespace Calculadora {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Card_MouseDown(object sender, MouseButtonEventArgs e) {
            DragMove();
        }

        public void fSumar()
        {
            int resultado = MathService.Add(Convert.ToInt32(txt_op1), (Convert.ToInt32(txt_op2)));
            txt_resultado.Text = resultado.ToString();
        }

        public void fRestar()
        {
            int resultado = MathService.Subtract(Convert.ToInt32(txt_op1), (Convert.ToInt32(txt_op2)));
            txt_resultado.Text = resultado.ToString();
        }

        public void fMultiplicar()
        {
            int resultado = MathService.Multiply(Convert.ToInt32(txt_op1), (Convert.ToInt32(txt_op2)));
            txt_resultado.Text = resultado.ToString();
        }

        public void fDividir()
        {
            int resultado = MathService.Divide(Convert.ToInt32(txt_op1), (Convert.ToInt32(txt_op2)));
            txt_resultado.Text = resultado.ToString();
        }

        public void fModulo()
        {
            int resultado = MathService.Modulo(Convert.ToInt32(txt_op1), (Convert.ToInt32(txt_op2)));
            txt_resultado.Text = resultado.ToString();
        }

        public void fRaiz()
        {
            double resultado = MathService.SquareRoot(Convert.ToDouble(txt_op1));
            txt_resultado.Text = resultado.ToString();
        }


        public void fPotencia()
        {
            double resultado = MathService.Power(Convert.ToDouble(txt_op1), (Convert.ToDouble(txt_op2)));
            txt_resultado.Text = resultado.ToString();
        }

        public void fFactorial()
        {
            int resultado = MathService.Factorial(Convert.ToInt32(txt_op1));
            txt_resultado.Text = resultado.ToString();
        }

        public void fLog()
        {
            int resultado = MathService.Logarithm(Convert.ToInt32(txt_op1));
            txt_resultado.Text = resultado.ToString();
        }
    }

}