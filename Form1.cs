﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tragamonedas_pokemon
{
    public partial class Tragamonedas : Form
    {

        private List<string> seleccion = new List<string>();
        private List<PictureBox> imagenes = new List<PictureBox>();
        private Random r = new Random();
        private int ultimo;
        int ganador;
        private Timer timer = new Timer();
        private int vueltas = 0;

        public Tragamonedas()
        {
            InitializeComponent();
            array_pictures();

            ultimo = r.Next(0, 23);
            timer.Interval = 40;
            timer.Tick += timer_Tick;

        }

        private void BTN_JUGAR_Click(object sender, EventArgs e)
        {

            jugar();

        }

        private void picture_cereza_Click(object sender, EventArgs e)
        {
            seleccion_fruta("cereza", picture_cereza);
        }

        private void picture_manzana_Click(object sender, EventArgs e)
        {
            seleccion_fruta("manzana", picture_manzana);
        }

        private void picture_naranja_Click(object sender, EventArgs e)
        {
            seleccion_fruta("naranja", picture_naranja);
        }

        private void picture_campana_Click(object sender, EventArgs e)
        {
            seleccion_fruta("campana", picture_campana);
        }

        private void picture_melon_Click(object sender, EventArgs e)
        {
            seleccion_fruta("melon", picture_melon);
        }

        private void picture_estrella_Click(object sender, EventArgs e)
        {
            seleccion_fruta("estrella", picture_estrella);
        }

        private void picture_sandia_Click(object sender, EventArgs e)
        {
            seleccion_fruta("sandia", picture_sandia);
        }

        private void picture_777_Click(object sender, EventArgs e)
        {
            seleccion_fruta("777", picture_777);
        }

        private void picture_bar_Click(object sender, EventArgs e)
        {
            seleccion_fruta("bar", picture_bar);
        }


        private void seleccion_fruta(string nombre, PictureBox pictureBox)
        {
            if (seleccion.Contains(nombre))
            {
                seleccion.Remove(nombre);
                pictureBox.BackColor = SystemColors.ButtonHighlight;
            }
            else if (seleccion.Count != 2)
            {
                seleccion.Add(nombre);
                pictureBox.BackColor = SystemColors.GrayText;

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {



            imagenes[ultimo].BackColor = SystemColors.ButtonHighlight;

            ultimo++;

            if (ultimo >= imagenes.Count)
            {
                ultimo = 0;
                vueltas++;

            }

            if (vueltas == 3)
            {
                timer.Stop();
                timer.Interval = 100;
                timer.Start();

            }

            if(vueltas == 5)
            {
                timer.Stop();
                timer.Interval = 150;
                timer.Start();

                if(ganador == ultimo)
                {
                    timer.Stop();
                    vueltas = 0;
                    timer.Interval = 40;
                    BTN_JUGAR.Enabled = true;
                    
                    if (seleccion.Contains(imagenes[ganador].Tag))
                    {

                        imagenes[ganador].BackColor = SystemColors.Highlight;

                        Notificacion noti = new Notificacion(true);
                        noti.ShowDialog();

                    }

                }

            }

            imagenes[ultimo].BackColor = SystemColors.Highlight;

        }

        private void jugar()
        {

            if(seleccion.Count >= 2) { 

                BTN_JUGAR.Enabled = false;
                ganador = r.Next(0, 23);
                timer.Start();


            }
            else
            {
                MessageBox.Show("SELECCIONA 2 FRUTAS","ALERTA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }



        private void array_pictures()
        {

            imagenes.Add(picture_0);
            imagenes.Add(picture_1);
            imagenes.Add(picture_2);
            imagenes.Add(picture_3);
            imagenes.Add(picture_4);
            imagenes.Add(picture_5);
            imagenes.Add(picture_6);
            imagenes.Add(picture_7);
            imagenes.Add(picture_8);
            imagenes.Add(picture_9);
            imagenes.Add(picture_10);
            imagenes.Add(picture_11);
            imagenes.Add(picture_12);
            imagenes.Add(picture_13);
            imagenes.Add(picture_14);
            imagenes.Add(picture_15);
            imagenes.Add(picture_16);
            imagenes.Add(picture_17);
            imagenes.Add(picture_18);
            imagenes.Add(picture_19);
            imagenes.Add(picture_20);
            imagenes.Add(picture_21);
            imagenes.Add(picture_22);
            imagenes.Add(picture_23);


        }


    }
}
