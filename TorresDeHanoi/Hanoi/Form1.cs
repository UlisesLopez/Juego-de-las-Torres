using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Hanoi
{
    public partial class Form1 : Form
    {
        ListBox torreOrigen;
        Stack PilaOrigen;
        Hanoi_Modelo hanoi = new Hanoi_Modelo();
        int movimientos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (HanoiDeVista.Intercambiar(listBox1, torreOrigen, hanoi.Torre1, PilaOrigen))
                FinDeJuego();
        }

        public void FinDeJuego()
        {
            movimientos++;
            label2.Text = String.Format("Movimientos: {0}", movimientos);
            if (hanoi.Torre3.Count == Convert.ToInt32(comboBox1.Text)) MessageBox.Show("Felicidades Ganaste ", " Juego de las Torres de Hanoi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int discos = Convert.ToInt32(comboBox1.Text);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            hanoi.Clear();
            for (int i = discos; i > 0; i--)
            {
                listBox1.Items.Insert(0, i);
                hanoi.Torre1.Push(i);
            }
            movimientos = 0;
            label2.Text = String.Format("Movimientos: {0}", movimientos);

        }

        private void HacerDragDrop(ListBox lista, Stack pila)
        {
            try
            {
                torreOrigen = lista;
                PilaOrigen = pila;
                lista.DoDragDrop(lista.SelectedItem, DragDropEffects.Move);
            }
            catch (Exception)
            {}
        }

        private void DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            HacerDragDrop(listBox1, hanoi.Torre1);
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (HanoiDeVista.Intercambiar(listBox2, torreOrigen, hanoi.Torre2, PilaOrigen))
                FinDeJuego();
        }

        private void listBox3_DragDrop(object sender, DragEventArgs e)
        {
            if (HanoiDeVista.Intercambiar(listBox3, torreOrigen, hanoi.Torre3, PilaOrigen))
                FinDeJuego();
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            HacerDragDrop(listBox2, hanoi.Torre2);
        }

        private void listBox3_MouseDown(object sender, MouseEventArgs e)
        {
            HacerDragDrop(listBox3, hanoi.Torre3);
        }





    }
}
