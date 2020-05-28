using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hugo_Parcial2
{
  public partial class Form1 : Form
  {
    
    private UserControl current = null;
    public Form1()
    {
      InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      var dn = BDconnection.realizarConsulta($"SELECT username FROM APPUSER WHERE username = '{textBox1.Text}'");
      var dr1 = dn.Rows[0];

      var dc2 = BDconnection.realizarConsulta($"SELECT password FROM APPUSER WHERE username = '{textBox1.Text}'");
      var dr2 = dc2.Rows[0];


      if (dr1[0].ToString().Equals(textBox1.Text) && dr2[0].ToString().Equals(textBox2.Text))
      {
        var dt = BDconnection.realizarConsulta($"SELECT usertype FROM APPUSER WHERE username='{textBox1.Text}'");
        var dr = dt.Rows[0];

        if (dr[0].ToString() == "True")
        {
          FormAdmon frmA = new FormAdmon();
          frmA.Show();
        }
        else if (dr[0].ToString() == "False"){
          
          FormNoAdmon frmN = new FormNoAdmon();
          frmN.Show();
        }
      }
      else
      {
        MessageBox.Show("Datos incorrectos");
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      tableLayoutPanel1.Controls.Remove(current);
      current= new ModifyPassword();
      current.Dock = DockStyle.Fill;
      tableLayoutPanel1.Controls.Add(current,2,1);
      tableLayoutPanel1.SetRowSpan(current, 4);
    }
  }
}
