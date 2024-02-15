using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.IO;

namespace Proyecto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.CenterToScreen();
        }


        private void Guardar(string fileName, string texto)
        {
            
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream); 

            writer.WriteLine(texto);

            writer.Close();
        }


        private void Form_Resize(object sender, EventArgs e)
        {
            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);
            BotonIr.Left = this.ClientSize.Width - BotonIr.Width;
            comboBox1.Width = BotonIr.Left - comboBox1.Left;
        }

        private void iniciioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.microsoft.com.");
        }

        private void BotonIr_Click(object sender, EventArgs e)
        {   
            string url = comboBox1.Text.ToString();

            if (!(url.Contains(".")))
            {
                url = "https://www.microsoft.com." + url;

            }

            if (!(url.Contains("http")) || (!(url.Contains("."))))
            {
                url = "http://" + url;

            }

            webView21.CoreWebView2.Navigate(url);

            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Ingresa una direccion o una palabra para continuar.");
            }
            else
            {
                Guardar(@"C:\Users\sebastianleon_h\Desktop\archivo.txt", comboBox1.Text);
                
                comboBox1.Text = "";
                comboBox1.Items.Clear();
                Leer();
            }
        }


        private void haciaAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void haciaAdelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }


        private void Leer()
        {
            string fileName = (@"C:\Users\sebastianleon_h\Desktop\archivo.txt");

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)

            {

                string textoLeido = reader.ReadLine();

                comboBox1.Items.Add(textoLeido);

            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            Leer();

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
