using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace proyectoFinalMicros
{
    public partial class Form1 : Form
    {

        private Form activeForm;

        // variables para form del serial port
        public static System.IO.Ports.SerialPort serialPortMain;
        public static bool estadoConectado;
        public static bool estadoDesconectado;
        public static string puertoSerialConectado = "No Esta conectado";
        public static bool conectado = false;

        // variables para form del modo manual y automatico
        // imagenes
        public static Bitmap imgLuzVerde = new Bitmap(Application.StartupPath + "\\img\\luzVerde.png");
        public static Bitmap imgLuzAmarillo = new Bitmap(Application.StartupPath + "\\img\\luzAmarilla.png");
        public static Bitmap imgLuzRojo = new Bitmap(Application.StartupPath + "\\img\\luzRoja.png");
        public static Bitmap buzzerActivo = new Bitmap(Application.StartupPath + "\\img\\buzzerActivo.png");
        public static Bitmap buzzerDesactivado = new Bitmap(Application.StartupPath + "\\img\\buzzerDesactivado.png");
        public static Bitmap smokeNormal = new Bitmap(Application.StartupPath + "\\img\\smoke.png");
        public static Bitmap fire = new Bitmap(Application.StartupPath + "\\img\\fire.png");
        // variables para imagenes
        public static bool estadoGas = false;
        public static bool estadoBuzzer = false;
        public static string estadoLed = "V";

        public Form1(){
            InitializeComponent();
            serialPortMain = serialPort;
        }

        // boton abrir form de opciones del puerto serial
        private void buttonMenuSerial_Click(object sender, EventArgs e){
            Reset();
            openChildForm(new Forms.FormPuertoSerial(), sender);
            buttonSelected();
            buttonMenuSerial.BackColor = Color.FromArgb(213, 40, 42);
        }

        private void buttonMenuAutomatico_Click(object sender, EventArgs e)
        {
            Reset();
            openChildForm(new Forms.FormModoAutomatico(), sender);
            buttonSelected();
            buttonMenuAutomatico.BackColor = Color.FromArgb(213,40,42);
            if (conectado) {
                serialPortMain.Write("A");
            }
        }

        private void buttonMenuManual_Click(object sender, EventArgs e)
        {
            Reset();
            openChildForm(new Forms.FormModoManual(), sender);
            buttonSelected();
            buttonMenuManual.BackColor = Color.FromArgb(213, 40, 42);
            if (conectado)
            {
                serialPortMain.Write("M");
            }
        }

        private void buttonMenuOtros_Click(object sender, EventArgs e)
        {
            Reset();
            openChildForm(new Forms.Otros(), sender);
            buttonSelected();
            buttonMenuOtros.BackColor = Color.FromArgb(213, 40, 42);
        }

        // funcion para abrir un form
        private void openChildForm(Form childForm, object btnSender){
            if (activeForm != null){
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopPanel.Controls.Add(childForm);
            panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTituloPrincipal.Text = childForm.Text;
        }
        // funcion para cerrar el form actual
        private void buttonCloseForms_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        // funcion para reserear colores, etiquetas y todo lo necesario del form main
        public  void Reset()
        {
            labelTituloPrincipal.Text = "HOME";
            buttonCloseForms.Visible = false;
            buttonMenuAutomatico.BackColor = Color.FromArgb(0, 48, 72);
            buttonMenuOtros.BackColor = Color.FromArgb(0, 48, 72);
            buttonMenuManual.BackColor = Color.FromArgb(0, 48, 72);
            buttonMenuSerial.BackColor = Color.FromArgb(0, 48, 72);
            panelHeader.BackColor = Color.FromArgb(0, 23, 47);
            panelLogo.BackColor = Color.FromArgb(0,48,72);
            panelDesktopPanel.BackColor = Color.White;
        }

        public void buttonSelected() {
            buttonCloseForms.Visible = true;
            panelHeader.BackColor = Color.FromArgb(213, 40, 42);
            panelLogo.BackColor = Color.FromArgb(163, 0, 0);
        }

        
    }


    

}
