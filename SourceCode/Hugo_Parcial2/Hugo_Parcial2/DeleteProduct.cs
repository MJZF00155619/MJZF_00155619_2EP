using System;
using System.Windows.Forms;

namespace Hugo_Parcial2
{
    public partial class DeleteProduct : UserControl
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            string nonQuery = $"DELETE FROM PRODUCT WHERE idProduct = {textBox1.Text}";

            BDconnection.realizarAccion(nonQuery);
            MessageBox.Show("Producto Eliminado");
            }
              catch (Exception ex)
              {
                  MessageBox.Show("Ha ocurrido un error!");
              }
        }
    }
}