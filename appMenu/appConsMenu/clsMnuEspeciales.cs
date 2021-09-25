using Servicios.Consolas;
using Servicios.Menus;
using System;

namespace appMatematica.Presentacion.Consola
{
    public class clsMnuEspeciales : clsMenu
    {
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
            clsConsola.LeerTecla();
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
            atrItems = new string[3];
            atrItems[0] = "MENU FUNCIONES ESPECIALES";
            atrItems[1] = "Factorial";
            atrItems[2] = "Regresar al Menu Principal";
        }
        protected override void procesarOpcion()
        {
            switch (atrOpcion)
            {
                case 1: { evFactorial(); } break;
                case 2: clsConsola.EscribirSaltarLinea("Escogiste Salir"); clsConsola.LeerTecla(); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); clsConsola.LeerTecla(); break;
            }
        }
    }
}