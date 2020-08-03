using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IA.Forms;

namespace IA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Te haremos una serie de preguntas y en " + "\n"+"base a eso te recomendaremos algun lugar!!");
            this.Hide();
            PreguntasForm cf = new PreguntasForm();
            cf.Show();
        }
    }
}
