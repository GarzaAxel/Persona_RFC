using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaRFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contacto p = new Contacto();
            string R = p.Recoleccion(txtApp.Text, txtapm.Text, txtname.Text, txtfecha.Text);
            txtRFC.Text = R;
        }

        private void txtfecha_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtApp.Clear();
            txtapm.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtfecha.Text = "AA/MM/DD";
        }
    }
}
