using System;
using System.Windows.Forms;

namespace Hugo_Parcial2
{
    public partial class FormAdmon : Form
    {
        private UserControl current = null;
        public FormAdmon()
        {
            InitializeComponent();
            current = createUser1;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new CreateUser();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,1,4);
            tableLayoutPanel1.SetRowSpan(current, 1);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new DeleteUser();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,1,4);
            tableLayoutPanel1.SetRowSpan(current, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dt = BDconnection.realizarConsulta("SELECT * FROM APPUSER");
            dataGridView1.DataSource = dt;
            MessageBox.Show("Datos obtenidos exitosamente");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AddBusiness();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,1,4);
            tableLayoutPanel1.SetRowSpan(current, 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new DeleteBusiness();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,1,4);
            tableLayoutPanel1.SetRowSpan(current, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var dt = BDconnection.realizarConsulta("SELECT * FROM BUSINESS");
            dataGridView1.DataSource = dt;
            MessageBox.Show("Datos obtenidos exitosamente");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AddProduct();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,1,4);
            tableLayoutPanel1.SetRowSpan(current, 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new DeleteProduct();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,1,4);
            tableLayoutPanel1.SetRowSpan(current, 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var dt = BDconnection.realizarConsulta("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address "+
            "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au"+ 
               " WHERE ao.idProduct = pr.idProduct "+
            "AND ao.idAddress = ad.idAddress " +
            "AND ad.idUser = au.idUser;");
            dataGridView1.DataSource = dt;
            MessageBox.Show("Datos obtenidos exitosamente");
        }
    }
}