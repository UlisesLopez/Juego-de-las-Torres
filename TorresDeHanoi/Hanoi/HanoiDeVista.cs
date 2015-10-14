using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Hanoi
{
    static class HanoiDeVista
    {
        public static bool Intercambiar(ListBox ListaA, ListBox ListaB, Stack destino, Stack origen)
        {
            Object item = ListaB.SelectedItem;
            if (item.ToString() != origen.Peek().ToString())
            {
                MessageBox.Show("El elemento no se puede mover", "Torres De Hanoi",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ListaB.ClearSelected();
            }
            else {
                if (destino.Count == 0 || ((int)origen.Peek() < (int)destino.Peek()))
                {
                    ListaA.Items.Insert(0, item);
                    ListaB.Items.Remove(item);
                    destino.Push(origen.Peek());
                    origen.Pop();
                    return true;

                }
                else {
                    MessageBox.Show("Movimiento no Valido :(", "Torres de Hanoi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ListaB.ClearSelected();
                }

            }
            return false;
        }///////////////////Fin del Metodo Intercambiar



    }
}
