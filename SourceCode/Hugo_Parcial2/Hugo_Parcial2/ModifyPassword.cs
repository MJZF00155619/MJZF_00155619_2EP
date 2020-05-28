using System;
using System.Windows.Forms;

namespace Hugo_Parcial2
{
    public partial class ModifyPassword : UserControl
    {
        public ModifyPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dn = BDconnection.realizarConsulta($"SELECT username FROM APPUSER WHERE username = '{textBox1.Text}'");
            var dr1 = dn.Rows[0];

            var dc2 = BDconnection.realizarConsulta($"SELECT password FROM APPUSER WHERE username = '{textBox1.Text}'");
            var dr2 = dc2.Rows[0];


            if (dr1[0].ToString().Equals(textBox1.Text) && dr2[0].ToString().Equals(textBox2.Text))
            {
                try
                {
                    string query = $"SELECT idUser FROM APPUSER WHERE username ='{textBox1.Text}'";
                    var dt = BDconnection.realizarConsulta(query);
                    var dr = dt.Rows[0];
                    var idUser = Convert.ToInt32(dr[0].ToString());
                    string nonQuery = $"UPDATE APPUSER SET password = '{textBox3.Text}' WHERE idUser = {idUser}";
                    
                   
                    BDconnection.realizarAccion(nonQuery);
                    MessageBox.Show("Se ha modificado la direccion");
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }  
              
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        
    }
}