using System;
using System.Windows;
using KushninCalculatorLib;

namespace KushninCalculatorWPF
{
    public partial class MainWindow : Window
    {
        private readonly Calculator _calculator = new Calculator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            TxtError.Text = string.Empty;
            TxtResult.Text = string.Empty;

            try
            {
                if (!double.TryParse(TxtA.Text, out double a))
                    throw new FormatException("Число A введено неверно");

                if (!double.TryParse(TxtB.Text, out double b))
                    throw new FormatException("Число B введено неверно");

                string operation = TxtOp.Text.Trim();
                if (string.IsNullOrEmpty(operation))
                    throw new FormatException("Операция не указана");

                double result = _calculator.Calculate(a, b, operation);
                TxtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                TxtError.Text = "Ошибка: " + ex.Message;
            }
        }
    }
}