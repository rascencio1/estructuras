using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _22feb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void procesar(byte primero)
        {
            // me aseguro que todo quepa dentro de un solo byte


           string bits = Convert.ToString(primero, 2);

            string direccion = Convert.ToString (bits[1])+ Convert.ToString(bits[2] + Convert.ToString(bits[3]));

            if (direccion == "000")
            {
                lblDireccion.Text = "norte";       
            }

            else if (direccion == "001")
            {
                lblDireccion.Text = "noreste";
            }

            else if (direccion == "010")
            {
                lblDireccion.Text = "este";
            }

            else if (direccion == "011")
            {
                lblDireccion.Text = "sureste";
            }

            else if (direccion == "100")
            {
                lblDireccion.Text = "sur";
            }
            else if (direccion == "101")
            {
                lblDireccion.Text = "suroeste";
            }
            else if (direccion == "110")
            {
                lblDireccion.Text = "oeste";
            }
            else if (direccion == "111")
            {
                lblDireccion.Text = "noroeste";
            }

            string nivelTanque = Convert.ToString(bits[4])  + Convert.ToString(bits[5]);
            if (nivelTanque == "00")
                lblLlenado.Text = "vacio";
            else if (nivelTanque == "01")
                lblLlenado.Text = "nivel medio";
            else if (nivelTanque == "10")
                lblLlenado.Text = "lleno";
            else if (nivelTanque == "11")
                lblLlenado.Text = "proceso de llenado";

            bool sensor2 = Convert.ToBoolean(bits[6]);
            if (sensor2 == true)
                lblSensor2.Text = "Sensor 2 encendido";
            bool sensor1 = Convert.ToBoolean(bits[7]);
            if (sensor1 == true)
                lblSensor1.Text = "sensor 1 encendido";
        }

        public string setFecha (byte[] fecha)
        {

            string numero = Convert.ToString(fecha[1], 2)+ Convert.ToString(fecha[2], 2);
            return numero;
        }
            


        

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            byte primero = Convert.ToByte(txtEntrada.Text);
               
            
            procesar(primero);

         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            byte segundo = Convert.ToByte(txtFecha.Text[0] + txtFecha.Text[1] + txtFecha.Text[2] + txtFecha.Text[3] + txtFecha.Text[4] + txtFecha.Text[5] + txtFecha.Text[6] + txtFecha.Text[7]);
            byte tercero = Convert.ToByte(txtFecha.Text[8] + txtFecha.Text[9] + txtFecha.Text[10] + txtFecha.Text[11] + txtFecha.Text[12] + txtFecha.Text[13] + txtFecha.Text[14] + txtFecha.Text[15]);
            byte[] fecha = { segundo, tercero };
            lblFecha.Text =setFecha(fecha);
            
        }
    }
}
