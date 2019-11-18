using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHouse
{
    public partial class Form1 : Form

    {
        int pieza1 = 0;
        int bano1 = 0;
        int sala1 = 0;
        int garaje = 0;
        int piscina = 0;
        int patio = 0;
        /*int pieza2 = 0;
        int bano2 = 0;
        int cocina = 0;
        int sala2 = 0;*/

        System.IO.Ports.SerialPort arduino;
        public Form1()
        {
            InitializeComponent();
            PicPieza1.Image = Image.FromFile("off-128.png");
            PicBano1.Image = Image.FromFile("off-128.png");
            PicGaraje.Image = Image.FromFile("off-128.png");
            PicPatio.Image = Image.FromFile("off-128.png");
            PicSala1.Image = Image.FromFile("off-128.png");
           PicPiscina.Image = Image.FromFile("piscina-off.png");
            arduino = new System.IO.Ports.SerialPort();
            arduino.PortName = "COM4";
            arduino.BaudRate = 9600;
            arduino.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (arduino.IsOpen) arduino.Close();
        }

        private void PicPieza1_Click(object sender, EventArgs e)
        {
            if (pieza1 == 0)
            {
                 arduino.Write("a");
                pieza1 = 1;
                PicPieza1.Image = Image.FromFile("on-128.png");
            }
            else
            {
                arduino.Write("b");
                pieza1 = 0;
                PicPieza1.Image = Image.FromFile("off-128.png");
            }
        }

        private void PicPiscina_Click(object sender, EventArgs e)
        {
            if (piscina == 0)
            {
                arduino.Write("c");
                piscina = 1;
                PicPiscina.Image = Image.FromFile("piscina.gif");
            }
            else
            {
                arduino.Write("d");
                piscina = 0;
                PicPiscina.Image = Image.FromFile("piscina-off.png");
            }
        }

        private void PicBano1_Click(object sender, EventArgs e)
        {
            if (bano1 == 0)
            {
                 arduino.Write("e");
                bano1 = 1;
                PicBano1.Image = Image.FromFile("on-128.png");
            }
            else
            {
                arduino.Write("f");
                bano1 = 0;
                PicBano1.Image = Image.FromFile("off-128.png");
            }
        }

        private void PicSala1_Click(object sender, EventArgs e)
        {
            if (sala1 == 0)
            {
                arduino.Write("g");
                sala1 = 1;
                PicSala1.Image = Image.FromFile("on-128.png");
            }
            else
            {
                arduino.Write("h");
                sala1 = 0;
                PicSala1.Image = Image.FromFile("off-128.png");
            }
        }

        private void PicPatio_Click(object sender, EventArgs e)
        {
            if (patio == 0)
            {
                 arduino.Write("i");
                patio = 1;
                PicPatio.Image = Image.FromFile("on-128.png");
            }
            else
            {
                arduino.Write("j");
                patio = 0;
                PicPatio.Image = Image.FromFile("off-128.png");
            }
        }

        private void PicGaraje_Click(object sender, EventArgs e)
        {
            if (garaje == 0)
            {
                 arduino.Write("k");
                garaje = 1;
                PicGaraje.Image = Image.FromFile("on-128.png");
            }
            else
            {
                arduino.Write("l");
                garaje = 0;
                PicGaraje.Image = Image.FromFile("off-128.png");
            }
           
        }
    }
}
