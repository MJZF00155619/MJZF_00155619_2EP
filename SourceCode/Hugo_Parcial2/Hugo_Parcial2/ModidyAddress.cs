using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace Hugo_Parcial2
{
    public partial class ModidyAddress : UserControl
    {
        public ModidyAddress()
        {
            InitializeComponent();
        }

        private void ModidyAddress_Load(object sender, EventArgs e)
        {
            var address = BDconnection.realizarConsulta("SELECT address FROM ADDRESS");
            var addressCombo = new List<string>();
            foreach (DataRow dr in address.Rows)
            {
                addressCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = addressCombo;
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
                    string query = $"SELECT idaddress FROM ADDRESS WHERE address ='{comboBox1.SelectedItem.ToString()}'";
                    var dt = BDconnection.realizarConsulta(query);
                    var dr = dt.Rows[0];
                    var idaddress = Convert.ToInt32(dr[0].ToString());
                    string nonQuery = $"UPDATE ADDRESS SET address = '{textBox1.Text}' WHERE idAddress = {idaddress}";
                    
                   
                     BDconnection.realizarAccion(nonQuery);
                    MessageBox.Show("Se ha modificado la direccion");
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
            }
        }
    }
}