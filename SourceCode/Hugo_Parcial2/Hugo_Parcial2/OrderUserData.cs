using System;
using System.Windows.Forms;

namespace Hugo_Parcial2
{
    public partial class OrderUserData : UserControl
    {
        public OrderUserData()
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
                //try
                // {
                var dt = BDconnection.realizarConsulta(
                    $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser AND au.idUser = {textBox1.Text}");


                dataGridView1.DataSource = dt;
                MessageBox.Show("Datos obtenidos exitosamente");
            //}
            /*catch (Exception esg)
                {
                    MessageBox.Show("Ha cocurrido un problema");
                }*/
        }
    }
}
}