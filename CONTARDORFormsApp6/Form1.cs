using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTARDORFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int desde = Convert.ToInt32(textDesde.Text);
                int Hasta = Convert.ToInt32(textHasta.Text);
                textBoxCONT.Clear();


                for (int i = desde; i <= Hasta; i++)



                {
                    if
                        (i < Hasta)
                        textBoxCONT.AppendText(i.ToString() + " +");
                    else
                        textHasta.AppendText(i.ToString());



                }
                Text = " = " + Hasta.ToString();
            }

                  catch (Exception err)
            { 
                        
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCONT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textHasta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
