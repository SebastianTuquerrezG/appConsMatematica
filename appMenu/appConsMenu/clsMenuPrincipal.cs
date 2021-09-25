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
        #region Fibonacci
        private int aux, n1 = 0, n2 = 1, lim, i;
        private void evFibonacci()
        {
            clsConsola.EscribirSaltarLinea("Ingresa la cantidad de numeros que deseas ver de la serie Fibonacci");
            lim = int.Parse(Console.ReadLine());
            clsConsola.EscribirSaltarLinea("  " + n1);
            for (i = 0; i <= lim; i++)
            {
                aux = n1 ; n1 = n2; n2 = aux + n1;
                clsConsola.EscribirSaltarLinea("  " + n1);
            }
        }
        #endregion

        #region MENU PRINCIPAL
        protected override void configurarMenuPrincipal()
        {
            atrOpcionSalir = 4;
            atrItems = new string[5];
            atrItems[0] = "MENU PRINCIPAL";
            atrItems[1] = "Operaciones aritmeticas";
            atrItems[2] = "Funciones especiales";
            atrItems[3] = "Series";
            atrItems[4] = "Salir";
        }
        protected override void procesarOpcionMPrincipal()
        {
            switch (atrOpcion)
            {
                case 1: {
                        configurarMenuOpAritmeticas();
                        procesarOpcionOpAritmeticas();   
                    } break;
                case 2: {
                        configurarMenuOpEspeciales();
                        procesarOpcionOpEspeciales();
                    } break;
                case 3: {
                        configurarMenuSeries();
                        procesarOpcionSeries();
                    } break;
                case 4: clsConsola.EscribirSaltarLinea("Escogiste Salir"); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); break;
            }
            clsConsola.LeerTecla();
        }
        #endregion
        #region MENU OPERACIONES ARITMETICAS
        protected override void configurarMenuOpAritmeticas()
        {
            atrOpcionSalir = 5;
            atrItems = new string[6];
            atrItems[0] = "MENU PRINCIPAL";
            atrItems[1] = "Suma";
            atrItems[2] = "Resta";
            atrItems[3] = "Multiplicar";
            atrItems[4] = "Dividir";
            atrItems[5] = "Regresar al menu principal";
        }
        protected override void procesarOpcionOpAritmeticas()
        {
            switch (atrOpcion)
            {
                case 1: { evSuma(); } break;
                case 2: { evResta(); } break;
                case 3: { evMultiplicacion(); } break;
                case 4: { evDivision(); } break;
                case 5: clsConsola.EscribirSaltarLinea("Escogiste Salir"); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); break;
            }
            clsConsola.LeerTecla();
        }
        #endregion
        #region MENU FUNCIONES ESPECIALES
        protected override void configurarMenuOpEspeciales()
        {
            atrOpcionSalir = 2;
            atrItems = new string[3];
            atrItems[0] = "MENU FUNCIONES ESPECIALES";
            atrItems[1] = "Factorital de un numero";
            atrItems[2] = "Regresar al menu principal";
        }
        protected override void procesarOpcionOpEspeciales()
        {
            switch(atrOpcion)
            {
                case 1: { evFactorial(); } break;
                case 2: clsConsola.EscribirSaltarLinea("Escogiste Salir"); break;
            }
        }
        #endregion
        #region MENU SERIES
        protected override void configurarMenuSeries()
        {
            atrOpcionSalir = 2;
            atrItems = new string[3];
            atrItems[0] = "MENU SERIES";
            atrItems[1] = "Fibonacci";
            atrItems[2] = "Regresar al menu principal";
        }
        protected override void procesarOpcionSeries()
        {
            switch (atrOpcion)
            {
                case 1: { evFactorial(); } break;
                case 2: clsConsola.EscribirSaltarLinea("Escogiste Salir"); break;
            }
        }
        #endregion
    }
}