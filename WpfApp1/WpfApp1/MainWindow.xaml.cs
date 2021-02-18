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





 // Custom class vars
        string lastPressed = "";
        NumberFormatInfo formatter;
        bool isAdvanceChecked = false;


        // Custom methods
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string contentPressed = (sender as Button).Content.ToString();

            double screenValue = double.Parse(screenLbl.Content.ToString(), formatter);

            try
            {

                switch (contentPressed)
                {
                    case "+":
                        if (lastPressed != "=")
                            sum(Convert.ToDouble(screenLbl.Content.ToString(), formatter));
                        screenLbl.Content = "0";
                        lastPressed = "+";
                        break;
                    case "-":
                        if (lastPressed != "=")
                            res(screenValue);
                        screenLbl.Content = "0";
                        lastPressed = "-";
                        break;
                    case "x":
                        if (lastPressed != "=")
                            if (lastPressed == "")
                                totalValue = screenValue;
                            else
                                por(screenValue);
                        screenLbl.Content = "0";
                        lastPressed = "x";
                        break;
                    case "/":
                        if (lastPressed != "=")
                            if (lastPressed == "")
                                totalValue = screenValue;
                            else
                                entre(screenValue);
                        screenLbl.Content = "0";
                        lastPressed = "/";
                        break;
                    case "=":
                        switch (lastPressed)
                        {
                            case "+":
                                sum(screenValue);
                                break;
                            case "-":
                                res(screenValue);
                                break;
                            case "x":
                                por(screenValue);
                                break;
                            case "/":
                                entre(screenValue);
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
                    case "R2":
                        raiz2(screenValue);
                        screenLbl.Content = totalValue.ToString();
                        break;
                    case "Lg10":
                        log10(screenValue);
                        screenLbl.Content = totalValue.ToString();
                        break;
                    default:
                        setNumberScreen(contentPressed);
                        break;

                }
            } catch (Exception err)
            {
                screenLbl.Content = "Error";
                totalValue = 0;
                lastPressed = "";
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

        double principalWidthStart = 450.164;
        double windowPrincipalAdvance = 646.964;
        private void ToggleAdvaceCheck(object sender, RoutedEventArgs e)
        {

            isAdvanceChecked = !isAdvanceChecked;
            if (!isAdvanceChecked)
            {
                advancePanel.Visibility = Visibility.Hidden;
                principalWindow.Width = principalWidthStart;
                return;
            }
            advancePanel.Visibility = Visibility.Visible;
            principalWindow.Width = windowPrincipalAdvance;

        }
    }

}
