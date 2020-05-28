using System;
using System.Windows.Forms;

namespace Hugo_Parcial2
{
    public partial class DeleteBusiness : UserControl
    {
        public DeleteBusiness()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try{
            

            string nonQuery = $"DELETE FROM BUSINESS WHERE idBusiness = {textBox1.Text}";

            BDconnection.realizarAccion(nonQuery);
            MessageBox.Show("Negocio Eliminado");
            }
              catch (Exception ex)
              {
                  MessageBox.Show("Ha ocurrido un error!");
              }

        }
    }
}