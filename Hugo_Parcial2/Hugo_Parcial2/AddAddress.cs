using System;
using System.Windows.Forms;

namespace Hugo_Parcial2
{
    public partial class AddAddress : UserControl
    {
        public AddAddress()
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
                    BDconnection.realizarAccion($"INSERT INTO ADDRESS(idUser, address)  VALUES ({textBox1.Text}, '{textBox2.Text}');");
                    MessageBox.Show("Se ha registrado la direccion");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
            }
        }
    }
}