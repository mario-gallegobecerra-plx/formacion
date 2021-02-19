using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfApp2.ConcesionarioDataSet concesionarioDataSet = ((WpfApp2.ConcesionarioDataSet)(this.FindResource("concesionarioDataSet")));
            // Cargar datos en la tabla CONCESIONARIOS. Puede modificar este código según sea necesario.
            WpfApp2.ConcesionarioDataSetTableAdapters.CONCESIONARIOSTableAdapter concesionarioDataSetCONCESIONARIOSTableAdapter = new WpfApp2.ConcesionarioDataSetTableAdapters.CONCESIONARIOSTableAdapter();
            concesionarioDataSetCONCESIONARIOSTableAdapter.Fill(concesionarioDataSet.CONCESIONARIOS);
            System.Windows.Data.CollectionViewSource cONCESIONARIOSViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("cONCESIONARIOSViewSource")));
            cONCESIONARIOSViewSource.View.MoveCurrentToFirst();
            // Cargar datos en la tabla COCHES. Puede modificar este código según sea necesario.
            WpfApp2.ConcesionarioDataSetTableAdapters.COCHESTableAdapter concesionarioDataSetCOCHESTableAdapter = new WpfApp2.ConcesionarioDataSetTableAdapters.COCHESTableAdapter();
            concesionarioDataSetCOCHESTableAdapter.Fill(concesionarioDataSet.COCHES);
            System.Windows.Data.CollectionViewSource cOCHESViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("cOCHESViewSource")));
            cOCHESViewSource.View.MoveCurrentToFirst();
        }




        private void CochesBtnClick(object sender, RoutedEventArgs e)
        {
            String nameCurrentConce = concesionarioSelecCmb.SelectedValue.ToString();
            ConcesionarioDataSet.CONCESIONARIOSDataTable ConcesionariosTable = new WpfApp2.ConcesionarioDataSetTableAdapters.CONCESIONARIOSTableAdapter().GetData();


            /*
            new WindowsFormsApp1
                .AdventureWorksLT2017DataSetTableAdapters
                .PEDIDOS2TableAdapter().Insert(textBox1.Text, int.Parse(textBox2.Text));
                */

        }




        // Change lbl
        private void DisplayLbl(LBL lbl)
        {
            switch (lbl)
            {
                case LBL.CONCESIONARIOS_EDIT:
                    ShowCochesLbl.Visibility = Visibility.Hidden;
                    ConcesionarSelectLbl.Visibility = Visibility.Hidden;
                    ConcesionarioEditLbl.Visibility = Visibility.Visible;
                    break;
                case LBL.CONCESIONARIOS_SELEC:
                    ShowCochesLbl.Visibility = Visibility.Hidden;
                    ConcesionarioEditLbl.Visibility = Visibility.Hidden;
                    ConcesionarSelectLbl.Visibility = Visibility.Visible;
                    break;
                case LBL.COCHES_LIST:
                    ConcesionarSelectLbl.Visibility = Visibility.Hidden;
                    ConcesionarioEditLbl.Visibility = Visibility.Hidden;
                    ShowCochesLbl.Visibility = Visibility.Visible;
                    break;
            }
        }


        enum LBL
        {
            CONCESIONARIOS_EDIT,
            CONCESIONARIOS_SELEC,
            COCHES_LIST
        }
    }
}
