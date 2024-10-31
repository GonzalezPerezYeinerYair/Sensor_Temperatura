using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sensor_Temperatura
{
    public partial class Form1 : Form
    {
        delegate void SetTexDelegate(string value);

        public SerialPort ArduinoPort { get; } 
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM5";
            ArduinoPort.BaudRate = 9600; // es la taza de sondeo del sensor
            ArduinoPort.DataBits = 8;
            ArduinoPort.ReadTimeout = 1000;
            ArduinoPort.WriteTimeout = 1000;
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedEventHandler);
            //ArduinoPort.Open();

            this.btnConector.Click += btnConector_Click;
            this.btnDesconectar.Click += btnDesconectar_Click;
        }

        private void DataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string dato = ArduinoPort.ReadLine();
            EscribirTxt(dato);
        }

        private void EscribirTxt(string dato) {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new SetTexDelegate(EscribirTxt), dato);
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error", "error");
                }
            }
            else {
                lbTemp.Text = dato;           
            }
        }

        private void btnConector_Click(object sender, EventArgs e)
        {
            try {
                if (!ArduinoPort.IsOpen)
                    ArduinoPort.Open();
                if (int.TryParse(tbLimTemp.Text, out int temperaturaLimit)){
                    //Convierte el valor a una cadena y luego en un arreglo de bytes
                    string limitString = temperaturaLimit.ToString();
                    ArduinoPort.Write(limitString);
                    MessageBox.Show("Conexion establecida");
                }
                else{
                    MessageBox.Show("Ingresa un valor numerico valido");
                }
                lbConexion.Text = "Conexion OK";
                lbConexion.ForeColor = System.Drawing.Color.Lime;
            }
            catch{
                MessageBox.Show("Configure el puerto de comunicacion correcto o desconecte");
            }
        }
        private void btnDesconectar_Click(object sender, EventArgs e){
            btnConector.Enabled = true;
            btnDesconectar.Enabled = false;
            if (ArduinoPort.IsOpen)
                ArduinoPort.Close();
            lbConexion.Text = "Desconectado";
            lbConexion.ForeColor = System.Drawing.Color.Red;
            lbTemp.Text = "00.0";
            MessageBox.Show("Desconectado");
        }
        private void label1_Click(object sender, EventArgs e){}
        private void Form1_Load(object sender, EventArgs e){}
        private void tbLimTemp_Click(object sender, EventArgs e){}
        private void lbTemp_Click(object sender, EventArgs e){}
    }
}
/*#include <Servo.h>
const int analogIn = A0;
const int servopin = 9; // Pin al que está conectado el motor
int temperatureLimit = 28; // Limite de temperatura inicial
int temperatureLimitSerial = -1; 

int RawValue = 0;
double Voltage = 0;
double tempC = 0;
double tempF = 0;
Servo Servo1;
void setup() {
  Serial.begin(9600);
  Servo1.attach(servopin);
}
void loop() {
  if (Serial.available() > 0) {
    temperatureLimitSerial = Serial.parseInt(); // Lee el limite de temperatura desde serial
    Serial.println("Valor recibido:");
    Serial.println(temperatureLimitSerial);
  }
  RawValue = analogRead(analogIn);//lee la temperatura
  Voltage = (RawValue / 1023.0) * 5000; // 5000 para obtener milivoltios
  tempC = Voltage * 0.1; // Celsius
  tempF = (tempC * 1.8) + 32; // Fahrenheit

  Serial.print("(C): ");
  Serial.println(tempC, 1);
  // serial si fue recibido un nuevo limite lo usa, de lo contrario el local)
  int currentLimit = (temperatureLimitSerial != -1) ? temperatureLimitSerial : temperatureLimit;
  // Controla el motor en funcion del limite de temperatura
  if (tempC > currentLimit) {//mueve al servo
    Servo1.write(0);
    delay(1000);
    Servo1.write(90);
    delay(1000);
    Servo1.write(180);
    delay(1000);
  } else {
  Servo1.write(90); // Manten el servo en el centro (90 grados) como estado de reposo
  }
  delay(5000); // Espera antes de volver a leer la temperatura
}

*/
