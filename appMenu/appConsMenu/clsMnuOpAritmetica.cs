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
            float a,b;
            clsConsola.LimpiarPantalla();
            clsConsola.EscribirSaltarLinea("Escogiste Division");
            a = clsConsola.Leer<float>("Introduce el dividendo: ");
            b = clsConsola.Leer<float>("Introduce el divisor: ");
            if(b == 0)
            {
                clsConsola.EscribirSaltarLinea("No se puede dividir entre cero, error: {0}");
            } else
            {
                clsConsola.EscribirSaltarLinea("El resultado del producto es " + a / b);
            }
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