using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void addToBox(object sender, EventArgs e)
        {


            try
            {

            }
            catch (Exception ex) { }
            
            new WindowsFormsApp1
                .AdventureWorksLT2017DataSetTableAdapters
                .PEDIDOS2TableAdapter().Insert(textBox1.Text, int.Parse(textBox2.Text));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'adventureWorksLT2017DataSet.PEDIDOS2' Puede moverla o quitarla según sea necesario.
            this.pEDIDOS2TableAdapter.Fill(this.adventureWorksLT2017DataSet.PEDIDOS2);
            // TODO: esta línea de código carga datos en la tabla 'adventureWorksLT2017DataSet.Address' Puede moverla o quitarla según sea necesario.
            this.addressTableAdapter.Fill(this.adventureWorksLT2017DataSet.Address);

        }
    }
}
