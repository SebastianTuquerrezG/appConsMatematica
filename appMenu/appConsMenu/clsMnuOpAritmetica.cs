using Servicios.Consolas;
using Servicios.Menus;
using System;

namespace appMatematica.Presentacion.Consola
{
    public class clsMnuOpAritmetica : clsMenu
    {
        // Patron de Bajo Acoplamiento
        private void evSuma()
        {
            clsConsola.LimpiarPantalla();
            clsConsola.EscribirSaltarLinea("Escogiste Suma");
            clsConsola.EscribirSaltarLinea("El resultado de la suma es= " + (clsConsola.Leer<int>("Introduce el valor para sumando 1: ") + clsConsola.Leer<int>("Introduce el segundo sumando 2: ")));
            clsConsola.LeerTecla();
        }
        private void evResta()
        {
            clsConsola.LimpiarPantalla();
            clsConsola.EscribirSaltarLinea("Escogiste Resta");
            clsConsola.EscribirSaltarLinea("El resultado de la resta es= " + (clsConsola.Leer<int>("Introduce el minuendo: ") - clsConsola.Leer<int>("Introduce el sustraendo: ")));
            clsConsola.LeerTecla();
        }
        private void evMultiplicacion()
        {
            clsConsola.LimpiarPantalla();
            clsConsola.EscribirSaltarLinea("Escogiste Producto");
            clsConsola.EscribirSaltarLinea("El resultado del producto es= " + (clsConsola.Leer<int>("Introduce el factor-1: ") * clsConsola.Leer<int>("Introduce el factor-2: ")));
            clsConsola.LeerTecla();
        }
        private void evDivision()
        {
            clsConsola.LimpiarPantalla();
            clsConsola.EscribirSaltarLinea("Escogiste Division");
            clsConsola.EscribirSaltarLinea("El resultado del producto es " + (clsConsola.Leer<float>("Introduce el dividendo: ") / clsConsola.Leer<float>("Introduce el divisor: ")));
            clsConsola.LeerTecla();
        }
        
        protected override void configurarMenu()
        {
            atrItems = new string[6];
            atrItems[0] = "MENU OPERACIONES ARITMETICAS";
            atrItems[1] = "Suma";
            atrItems[2] = "Resta";
            atrItems[3] = "Multiplicacion";
            atrItems[4] = "Dividir";
            atrItems[5] = "Regresar al Menu Principal...";
        }
        protected override void procesarOpcion()
        {
            switch (atrOpcion)
            {
                case 1: { evSuma(); } break;
                case 2: { evResta(); } break;
                case 3: { evMultiplicacion(); } break;
                case 4: { evDivision(); } break;
                case 5: clsConsola.EscribirSaltarLinea("Escogiste Salir"); clsConsola.LeerTecla(); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); clsConsola.LeerTecla(); break;
            }
        }
    }
}