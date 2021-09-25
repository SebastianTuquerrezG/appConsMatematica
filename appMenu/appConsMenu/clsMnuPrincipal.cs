using Servicios.Consolas;
using Servicios.Menus;
using System;

namespace appMatematica.Presentacion.Consola
{
    public class clsMnuPrincipal : clsMenu
    {
        protected override void configurarMenu()
        {
            atrItems = new string[5];
            atrItems[0] = "MENU PRINCIPAL";
            atrItems[1] = "Operaciones Aritmeticas";
            atrItems[2] = "Funciones Especiales";
            atrItems[3] = "Series";
            atrItems[4] = "Salir";
        }
        protected override void procesarOpcion()
        {
            switch (atrOpcion)
            {
                case 1: { new clsMnuOpAritmetica(); } break;
                case 2: { new clsMnuEspeciales(); } break;
                case 3: { new clsMnuSeries(); } break;
                case 4: clsConsola.EscribirSaltarLinea("Escogiste Salir"); clsConsola.LeerTecla(); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); clsConsola.LeerTecla();  break;
            }
        }
    }
}