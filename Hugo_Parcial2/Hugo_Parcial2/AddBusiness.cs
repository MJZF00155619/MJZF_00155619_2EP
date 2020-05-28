using System;
using System.Windows.Forms;

namespace Hugo_Parcial2
{
    public partial class AddBusiness : UserControl
    {
        public AddBusiness()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
                
            {
                MessageBox.Show("No puede dejar los campos vacios");
            }
            else
            {
                try
                {
                    BDconnection.realizarAccion($"INSERT INTO BUSINESS(name, description) VALUES('{textBox1.Text}', '{textBox2.Text}');");
                    MessageBox.Show("Se ha guardado el negocio");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
            }
        }
    }
}