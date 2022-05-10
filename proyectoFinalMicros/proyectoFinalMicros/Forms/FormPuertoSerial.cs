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

namespace proyectoFinalMicros.Forms
{
    public partial class FormPuertoSerial : Form
    {
        public static string puertoSerial;
        public FormPuertoSerial(){
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Form1.serialPortMain.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }
        // cuando se carga el form
        private void FormPuertoSerial_Load(object sender, EventArgs e){
            cargarPuertosSeriales();
            opcionesporDefecto();
            if (Form1.conectado) {
                cargarHistorial();
            }
        }

        // funcion para obtener puertos seriales del sistema
        private void cargarPuertosSeriales() {
            string[] listaPuetosSeriales = System.IO.Ports.SerialPort.GetPortNames();
            comboBoxPuertosSeriales.DataSource = listaPuetosSeriales;
        }
        // boton actualizar opciones de puertos seriales
        private void buttonActualizarPuertosSeriales_Click(object sender, EventArgs e){
            cargarPuertosSeriales();
        }
        // boton conectarse al puerto serial
        private void buttonConectar_Click(object sender, EventArgs e){
            puertoSerial = comboBoxPuertosSeriales.SelectedItem.ToString();
            labelPuertoSerial.Text = puertoSerial;
            if (!Form1.serialPortMain.IsOpen) {
                try {
                    Form1.serialPortMain.PortName = puertoSerial;
                    Form1.serialPortMain.Open();
                    buttonConectar.Enabled = false;
                    buttonDesconectar.Enabled = true;
                    Form1.estadoConectado = false;
                    Form1.estadoDesconectado = true;
                    Form1.puertoSerialConectado = puertoSerial;
                    Form1.conectado = true;
                } catch {
                    MessageBox.Show("Error al conectarse al puerto serial: " + labelPuertoSerial.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cargarPuertosSeriales();
                    opcionesporDefecto();
                }
            }
        }
        // boton desconectarse del puerto serial
        private void buttonDesconectar_Click(object sender, EventArgs e){
            if (Form1.serialPortMain.IsOpen){
                Form1.serialPortMain.Close();
                Form1.conectado = false;
                Form1.puertoSerialConectado = "No Esta conectado";
                opcionesporDefecto();
            }
        }
        // funcion para poner las opciones por defecto
        public void opcionesporDefecto(){
            buttonConectar.Enabled = true;
            buttonDesconectar.Enabled = false;
            labelPuertoSerial.Text = "No Conectado";
        }
        // funcion para cargar el historial del estado de esta pantalla 
        public void cargarHistorial(){
            buttonConectar.Enabled = Form1.estadoConectado;
            buttonDesconectar.Enabled = Form1.estadoDesconectado;
            labelPuertoSerial.Text = Form1.puertoSerialConectado;
        }

        public void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            if (Form1.conectado)
            {
                try
                {
                    string data_port = Form1.serialPortMain.ReadLine();
                    textBox1.Text = data_port;
                }
                catch {
                }
            }
        }
    }
}
