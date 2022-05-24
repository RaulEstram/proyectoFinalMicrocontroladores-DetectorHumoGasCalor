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
    public partial class FormModoManual : Form{
        public FormModoManual(){
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Form1.serialPortMain.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void buttonPrenderVerde_Click(object sender, EventArgs e){
            if (Form1.conectado){
                Form1.serialPortMain.Write("V");
                pictureBoxLed.Image = Form1.imgLuzVerde;
                labelLed.Text = "Todo Bien";
            }
        }

        private void buttonPrenderAmarillo_Click(object sender, EventArgs e){
            if (Form1.conectado){
                Form1.serialPortMain.Write("Y");
                pictureBoxLed.Image = Form1.imgLuzAmarillo;
                labelLed.Text = "Precaucion";
            }
        }

        private void buttonPrenderRojo_Click(object sender, EventArgs e){
            if (Form1.conectado){
                Form1.serialPortMain.Write("R");
                pictureBoxLed.Image = Form1.imgLuzRojo;
                labelLed.Text = "Peligro";
            }
        }
        

        private void buttonPrenderBuzzer_Click(object sender, EventArgs e){
            if (Form1.conectado){
                Form1.serialPortMain.Write("R");
                pictureBoxLed.Image = Form1.imgLuzRojo;
                labelLed.Text = "Peligro";
            }
        }

        private void buttonPrenderBuzzer_Click_1(object sender, EventArgs e){
            if (Form1.conectado){
                Form1.serialPortMain.Write("P");
                pictureBoxBuzzer.Image = Form1.buzzerActivo;
                labelBuzzer.Text = "Alarma Activada";
            }
        }

        private void buttonApagarBuzzer_Click(object sender, EventArgs e){
            if (Form1.conectado){
                Form1.serialPortMain.Write("O");
                pictureBoxBuzzer.Image = Form1.buzzerDesactivado;
                labelBuzzer.Text = "Alarma Desactivada";
            }
        }


        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e){
            if (Form1.conectado){
                try{
                    string data_port = Form1.serialPortMain.ReadLine();
                    string[] data = data_port.Split(',');
                    labelGas.Text = data[1] + " ppm";
                    labelTemperatura.Text = data[2] + " °C";

                    // gas
                    if (data[1] == "0"){
                        pictureBoxGas.Image = Form1.smokeNormal;
                    } else if (data[1] == "1") {
                        pictureBoxGas.Image = Form1.fire;
                    }
                } catch {
                }
            }
        }

        private void FormModoManual_Load(object sender, EventArgs e) {
            if (Form1.conectado) {
                if (Form1.estadoLed == "V") {
                    pictureBoxLed.Image = Form1.imgLuzVerde;
                } else if (Form1.estadoLed == "A") {
                    pictureBoxLed.Image = Form1.imgLuzAmarillo;
                } else if (Form1.estadoLed == "R") {
                    pictureBoxLed.Image = Form1.imgLuzRojo;
                }

                if (Form1.estadoBuzzer == false) {
                    pictureBoxBuzzer.Image = Form1.buzzerDesactivado;
                } else if (Form1.estadoBuzzer == true) {
                    pictureBoxBuzzer.Image = Form1.buzzerActivo;
                }

            }
        }
    }
}
