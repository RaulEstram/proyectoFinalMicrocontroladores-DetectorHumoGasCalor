using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinalMicros.Forms
{
    public partial class FormModoManual : Form
    {
        public FormModoManual()
        {
            InitializeComponent();
        }

        private void buttonPrenderVerde_Click(object sender, EventArgs e)
        {
            pictureBoxLed.Image = Form1.imgLuzVerde;
            labelLed.Text = "Todo Bien";
        }

        private void buttonPrenderAmarillo_Click(object sender, EventArgs e)
        {
            pictureBoxLed.Image = Form1.imgLuzAmarillo;
            labelLed.Text = "Precaucion";
        }

        private void buttonPrenderRojo_Click(object sender, EventArgs e)
        {
            pictureBoxLed.Image = Form1.imgLuzRojo;
            labelLed.Text = "Peligro";
        }
    }
}
