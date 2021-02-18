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
using System.Globalization;
using static WpfApp1.Calculadora;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            formatter = new NumberFormatInfo();
            formatter.NumberDecimalSeparator = ".";
            InitializeComponent();
        }

        string lastPressed = "";
        NumberFormatInfo formatter;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string contentPressed = (sender as Button).Content.ToString();

            switch (contentPressed)
            {
                case "+":
                    if( lastPressed != "=")
                        sum(Convert.ToDouble(screenLbl.Content.ToString(),formatter));
                    screenLbl.Content = "0";
                    lastPressed = "+";
                    break;
                case "-":
                    if (lastPressed != "=")
                        res(double.Parse(screenLbl.Content.ToString(), formatter));
                    screenLbl.Content = "0";
                    lastPressed = "-";
                    break;
                case "x":
                    if (lastPressed != "=")
                        if (lastPressed == "")
                            totalValue = double.Parse(screenLbl.Content.ToString(), formatter);
                        else
                            por(double.Parse(screenLbl.Content.ToString(), formatter));
                    screenLbl.Content = "0";
                    lastPressed = "x";
                    break;
                case "/":
                    if (lastPressed != "=")
                        if (lastPressed == "")
                            totalValue = double.Parse(screenLbl.Content.ToString(), formatter);
                        else
                            entre(double.Parse(screenLbl.Content.ToString(), formatter));
                    screenLbl.Content = "0";
                    lastPressed = "/";
                    break;
                case "=":
                    switch (lastPressed){
                        case "+":
                            sum(double.Parse(screenLbl.Content.ToString(), formatter));
                            break;
                        case "-":
                            res(double.Parse(screenLbl.Content.ToString(), formatter));
                            break;
                        case "x":
                            por(double.Parse(screenLbl.Content.ToString(), formatter));
                            break;
                        case "/":
                            entre(double.Parse(screenLbl.Content.ToString(), formatter));
                            break;
                    }
                    lastPressed = "=";
                    screenLbl.Content = totalValue.ToString();
                    break;
                case ".":
                    addPoint();
                    break;
                case "CE":
                    screenLbl.Content = "0";
                    totalValue = 0;
                    lastPressed = "";
                    break;
                default:
                    setNumberScreen(contentPressed);
                    break;

            }

        }


        private void setNumberScreen(String content)
        {

            string currentContent = screenLbl.Content.ToString();

            try
            {
                int.Parse(content);
            }catch(Exception e)
            {
                screenLbl.Content = "0";
            }

            if (currentContent == "0") {
                if( content == "0")
                    return;
                currentContent = "";
            }
            screenLbl.Content = currentContent + content;

        }

        private void addPoint()
        {
            string currentContent = screenLbl.Content.ToString();

            if (!currentContent.Contains('.'))
                screenLbl.Content = currentContent + ".";
        }

    }

}
