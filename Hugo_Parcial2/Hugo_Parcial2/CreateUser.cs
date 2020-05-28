using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Hugo_Parcial2
{
    public partial class CreateUser : UserControl
    {
        public CreateUser()
        {
            InitializeComponent();
            var user = new List<bool>{true,false};
            comboBox1.DataSource = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Equals("") ||
                textBox2.Equals(""))

            {
                MessageBox.Show("No puede dejar los campos vacios!");
            }
            else
            {
                try
                {
                    BDconnection.realizarAccion($"INSERT INTO APPUSER(fullname, username, password, userType) VALUES(" +
                                            $"'{textBox1.Text}'," +
                                            $"'{textBox2.Text}'," +
                                            $"'{textBox3.Text}'," +
                                            $"{comboBox1.SelectedItem})");

                    MessageBox.Show("USUARIO ANADIDO");
                }
                catch (Exception esg)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}