using Servicios.Consolas;
using Servicios.Menus;
using System;

namespace appMatematica.Presentacion.Consola
{
    public class clsMnuSeries : clsMenu
    {
        #region Fibonacci
        private int aux, n1 = 0, n2 = 1, lim, i;
        private void evFibonacci()
        {
            clsConsola.EscribirSaltarLinea("Ingresa la cantidad de numeros que deseas ver de la serie Fibonacci");
            lim = int.Parse(Console.ReadLine());
            clsConsola.EscribirSaltarLinea("  " + n1);
            for (i = 0; i <= lim; i++)
            {
                aux = n1; n1 = n2; n2 = aux + n1;
                clsConsola.EscribirSaltarLinea("  " + n1);
            }
            clsConsola.LeerTecla();
        }
        #endregion
        protected override void configurarMenu()
        {
            atrItems = new string[3];
            atrItems[0] = "MENU SERIES";
            atrItems[1] = "Fibonacci";
            atrItems[2] = "Regresar al Menu Anterior...";
        }
        protected override void procesarOpcion()
        {
            switch (atrOpcion)
            {
                case 1: { evFibonacci(); } break;
                case 2: clsConsola.EscribirSaltarLinea("Escogiste Salir"); clsConsola.LeerTecla(); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); clsConsola.LeerTecla(); break;
            }
        }
    }
}