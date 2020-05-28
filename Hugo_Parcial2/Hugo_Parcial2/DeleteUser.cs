using System;
using System.Windows.Forms;

namespace Hugo_Parcial2
{
    public partial class DeleteUser : UserControl
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            string nonQuery = $"DELETE FROM APPUSER WHERE idUser = {textBox1.Text}";

            BDconnection.realizarAccion(nonQuery);
            MessageBox.Show("Usuario Eliminado");
            }
              catch (Exception ex)
              {
                  MessageBox.Show("Ha ocurrido un error!");
              }
        }
    }
}