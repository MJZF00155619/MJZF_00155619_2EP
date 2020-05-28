using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace Hugo_Parcial2
{
    public partial class DeleteAddress : UserControl
    {
        public DeleteAddress()
        {
            InitializeComponent();
        }
            
        private void DeleteAddress_Load(object sender, EventArgs e)
        {
            var addres = BDconnection.realizarConsulta("SELECT idaddress FROM ADDRESS");
            var addrescombo = new List<string>();
            foreach (DataRow dr in addres.Rows)
            {
                addrescombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = addrescombo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nonQuery = $"DELETE FROM ADDRESS WHERE idAddress='{comboBox1.SelectedItem.ToString()}'";

            BDconnection.realizarAccion(nonQuery);
            MessageBox.Show("Direccion Eliminada");
        }
    }
}