using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace Hugo_Parcial2
{
    public partial class AddProduct : UserControl
    {
        public AddProduct()
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
                    BDconnection.realizarAccion($"INSERT INTO PRODUCT(idBusiness, name) VALUES({comboBox1.SelectedItem}, '{textBox1.Text}');");
                    MessageBox.Show("Se ha registrado el producto");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            var prod = BDconnection.realizarConsulta("SELECT idbusiness FROM Business");
            var prodCombo = new List<string>();
            foreach (DataRow dr in prod.Rows)
            {
                prodCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = prodCombo;
        }
    }
}