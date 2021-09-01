using Servicios.Consolas;
using Servicios.Menus;
using System;

namespace appMatematica.Presentacion.Consola
{
    public class clsMenuPrincipal : clsMenu
    {
        // Patron de Bajo Acoplamiento
        private void evSuma()
        {
            clsConsola.LimpiarPantalla();
            clsConsola.EscribirSaltarLinea("Escogiste Suma");
            clsConsola.EscribirSaltarLinea("El resultado de la suma es= " + (clsConsola.Leer<int>("Introduce el valor para sumando 1: ") + clsConsola.Leer<int>("Introduce el segundo sumando 2: ")));
        }
        private void evResta()
        {
            clsConsola.LimpiarPantalla();
            clsConsola.EscribirSaltarLinea("Escogiste Resta");
            clsConsola.EscribirSaltarLinea("El resultado de la resta es= " + (clsConsola.Leer<int>("Introduce el minuendo: ") - clsConsola.Leer<int>("Introduce el sustraendo: ")));
        }
        private void evMultiplicacion()
        {
            clsConsola.LimpiarPantalla();
            clsConsola.EscribirSaltarLinea("Escogiste Producto");
            clsConsola.EscribirSaltarLinea("El resultado del producto es= " + (clsConsola.Leer<int>("Introduce el factor-1: ") * clsConsola.Leer<int>("Introduce el factor-2: ")));
        }
        private void evDivision()
        {
            clsConsola.LimpiarPantalla();
            clsConsola.EscribirSaltarLinea("Escogiste Division");
            clsConsola.EscribirSaltarLinea("El resultado del producto es " + (clsConsola.Leer<float>("Introduce el dividendo: ") / clsConsola.Leer<float>("Introduce el divisor: ")));
        }
        #region Factorial
        private int numero;
        private void evFactorial()
        {
            clsConsola.LimpiarPantalla();
            clsConsola.EscribirSaltarLinea("Escogiste calcular el factorial de un número");
            do
            {
                clsConsola.EscribirSaltarLinea("Digita el numero que quieras calcular");
                // clsConsola.ConvertirParse_LeerDato();
                numero = int.Parse(Console.ReadLine());
                if (numero < 0)
                    clsConsola.EscribirSaltarLinea("No existe el factorial de un numero negativo");
            } while (numero < 0);
            calculoFactorial(numero);
        }
        private void calculoFactorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
                factorial *= i;

            clsConsola.EscribirSaltarLinea("El Factorial de " + num + " es: " + factorial);
        }
        #endregion

        protected override void configurarMenu()
        {
            atrOpcionSalir = 5;
            atrItems = new string[7];
            atrItems[0] = "MENU OPERACIONES ARITMETICAS";
            atrItems[1] = "Suma";
            atrItems[2] = "Resta";
            atrItems[3] = "Producto";
            atrItems[4] = "Division";
            atrItems[5] = "Factorial";
            atrItems[6] = "Salir";
        }
        protected override void procesarOpcion()
        {
            switch (atrOpcion)
            {
                case 1: { evSuma(); } break;
                case 2: { evResta(); } break;
                case 3: { evMultiplicacion(); } break;
                case 4: { evDivision(); } break;
                case 5: { evFactorial(); } break;
                case 6: clsConsola.EscribirSaltarLinea("Escogiste Salir"); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); break;
            }
            clsConsola.LeerTecla();
        }
    }
}