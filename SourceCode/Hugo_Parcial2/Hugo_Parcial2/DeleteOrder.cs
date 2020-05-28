using System;
using System.Windows.Forms;

namespace Hugo_Parcial2
{
    public partial class DeleteOrder : UserControl
    {
        public DeleteOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DELETE FROM APPORDER WHERE idOrder = 1

            try
            {
                string nonQuery = $"DELETE FROM APPORDER WHERE idOrder ='{textBox1.Text}'";
                BDconnection.realizarAccion(nonQuery);
                MessageBox.Show("Orden Eliminada");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        
    }
}