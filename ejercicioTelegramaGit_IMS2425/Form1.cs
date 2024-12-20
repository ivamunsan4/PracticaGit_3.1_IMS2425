﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegramaGit_IMS2425
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama 
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente? 
            if (chkUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else
                tipoTelegrama = 'o';
            //Obtengo el número de palabras que forma el telegrama
            //Primero defino los delimitadores de palabras
            //IMS2425 CORRECCION DE CODIGO
            char[] delimitadores = new char[] { ' ', '\r', '\n' };
            //Cuento el número de palabras.
            numPalabras = textoTelegrama.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries).Length;
            //numPalabras = textoTelegrama.Length;

            //Si el telegrama es ordinario 
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    //IMS2425 CORRECCION DE CODIGO
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else
            //Si el telegrama es urgente 
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 5;
                    }
                    else
                    {
                        //IMS2425
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
