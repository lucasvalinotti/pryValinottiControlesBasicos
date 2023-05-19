using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryValinottiControlesBasicos
{
    public partial class frmSecundario : Form
    {
        public frmSecundario()
        {
            InitializeComponent();
        }


        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            lblTexto.Text = txtTexto.Text;
        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            if (optAzul.Checked)
            {
                txtTexto.ForeColor = Color.Blue;
                lblTexto.ForeColor = Color.Blue;
            }
            else if (optRojo.Checked)
            {
                txtTexto.ForeColor = Color.Red;
                lblTexto.ForeColor = Color.Red;
            }
        }

        private void cmdEscribir_Click(object sender, EventArgs e)
        {
            lblTexto.Text = "";
            if (chkLucas.Checked)
            {
                lblTexto.Text += chkLucas.Text + " ";
            }
            if (chkSebastian.Checked)
            {
                lblTexto.Text += chkSebastian.Text + " ";
            }
            if (chkValinotti.Checked)
            {
                lblTexto.Text += chkValinotti.Text + " ";
            }
            if (chkLucas.Checked == false && chkSebastian.Checked == false && chkValinotti.Checked == false)
            {
                lblTexto.Text = "Su texto aparecera aqui...";
            }
            //List<CheckBox> list = new List<CheckBox>();
            //list.Add(chkLucas); list.Add(chkSebastian); list.Add(chkValinotti);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i].Checked)
            //    {
            //        lblTexto.Text += list[i].Text + " ";
            //    }
            //}
        }
    }
}
