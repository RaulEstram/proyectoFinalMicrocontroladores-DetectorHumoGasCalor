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
    public partial class FormModoAutomatico : Form
    {

        public FormModoAutomatico(){
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Form1.serialPortMain.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e){
            if (Form1.conectado){
                try{
                    string data_port = Form1.serialPortMain.ReadLine();
                    string[] data = data_port.Split(',');
                    labelGas.Text = data[1] + " ppm" ;
                    labelTemperatura.Text = data[2] + " °C";
                    // led
                    if (data[3] == "V"){
                        pictureBoxLed.Image = Form1.imgLuzVerde;
                        labelActuadorLed.Text = "Todo Bien";
                        Form1.estadoLed = "V";
                    } else if (data[3] == "A") {
                        pictureBoxLed.Image = Form1.imgLuzAmarillo;
                        labelActuadorLed.Text = "Precaucion";
                        Form1.estadoLed = "A";
                    } else if (data[3] == "R") {
                        pictureBoxLed.Image = Form1.imgLuzRojo;
                        labelActuadorLed.Text = "Peligro";
                        Form1.estadoLed = "R";
                    }
                    // buzzer
                    if (data[4] == "0") {
                        pictureBoxBuzzer.Image = Form1.buzzerDesactivado;
                        labelBuzzer.Text = "Desactivado";
                        Form1.estadoBuzzer = false;
                    } else if (data[4] == "1") {
                        pictureBoxBuzzer.Image = Form1.buzzerActivo;
                        labelBuzzer.Text = "Activo";
                        Form1.estadoBuzzer = true;
                    }
                    // gas
                    if (int.Parse(data[1]) < 400) {
                        pictureBoxGas.Image = Form1.smokeNormal;
                        Form1.estadoGas = false;
                    } else if (int.Parse(data[1]) < 700) {
                        pictureBoxGas.Image = Form1.fire;
                        Form1.estadoGas = true;
                    } else if (int.Parse(data[1]) >= 700) {
                        pictureBoxGas.Image = Form1.fire;
                        Form1.estadoGas = true;
                    }
                } catch {
                }
            }
        }
    }
}
