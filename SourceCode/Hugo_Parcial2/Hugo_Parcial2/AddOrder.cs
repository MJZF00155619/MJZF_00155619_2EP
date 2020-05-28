using System;
using System.Windows.Forms;
using System.Data;
using  System.Collections.Generic;

namespace Hugo_Parcial2
{
    public partial class AddOrder : UserControl
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
                
            if (comboBox1.Equals("") ||
                comboBox2.Equals("") || comboBox3.Equals("") )

            {
                MessageBox.Show("No puede dejar los campos vacios!");
            }
            else
            {
                try
                {

                    BDconnection.realizarAccion($"INSERT INTO APPORDER(createDate, idProduct, idAddress) VALUES (" +
                                                $"'{DateTime.Today}'," +
                                                $"{comboBox1.SelectedItem}," +
                                                $"{comboBox2.SelectedItem})");

                    MessageBox.Show("ORDEN ANADIDA");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            var bus = BDconnection.realizarConsulta("SELECT idbusiness FROM BUSINESS");
            var busCombo = new List<string>();
            foreach (DataRow dr in bus.Rows)
            {
                busCombo.Add(dr[0].ToString());
            }
            comboBox1.DataSource = busCombo;
            
            var dir = BDconnection.realizarConsulta("SELECT idaddress FROM ADDRESS");
            var dirCombo = new List<string>();
            foreach (DataRow ds in dir.Rows)
            {  
                dirCombo.Add(ds[0].ToString());
            }
            comboBox2.DataSource = dirCombo;
            
            var prod = BDconnection.realizarConsulta($"SELECT idProduct FROM PRODUCT WHERE idBusiness={comboBox1.Text}");
            var prodCombo = new List<string>();
            foreach (DataRow dt in prod.Rows)
            {
                prodCombo.Add(dt[0].ToString());
            }
            comboBox3.DataSource = prodCombo;
        }

        
    }
}