using System;
using System.Windows.Forms;

namespace Hugo_Parcial2
{
    public partial class FormNoAdmon : Form
    {
        private UserControl current = null;
        public FormNoAdmon()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new AddAddress();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,2,5);
            tableLayoutPanel1.SetRowSpan(current, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new DeleteAddress();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,2,5);
            tableLayoutPanel1.SetRowSpan(current, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new ModidyAddress();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,2,5);
            tableLayoutPanel1.SetRowSpan(current, 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dt = BDconnection.realizarConsulta($"SELECT ad.idAddress, ad.address FROM ADDRESS ad WHERE idUser={textBox1.Text}");
            dataGridView1.DataSource = dt;
            MessageBox.Show("Datos obtenidos exitosamente");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new AddOrder();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,2,5);
            tableLayoutPanel1.SetRowSpan(current, 1);           
      }

        private void button6_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new DeleteOrder();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,2,5);
            tableLayoutPanel1.SetRowSpan(current, 1);           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current= new OrderUserData();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current,2,5);
            tableLayoutPanel1.SetRowSpan(current, 1);     
        }
    }
}