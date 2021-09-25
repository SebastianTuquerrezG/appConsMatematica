using Servicios.Consolas;

namespace Servicios.Menus
{
    public class clsMenu
    {
        #region Atributos
        protected int atrOpcion = -1;
        protected int atrOpcionSalir;
        protected string[] atrItems; 
        #endregion
        #region Operaciones
        public clsMenu()
        {
            configurarMenuPrincipal();
            atrOpcionSalir = atrItems.Length - 1;
            iterarMenu();
        }
        protected virtual void configurarMenuPrincipal() { }
        protected virtual void procesarOpcionMPrincipal() { }
        protected virtual void configurarMenuOpAritmeticas() { }
        protected virtual void procesarOpcionOpAritmeticas() { }
        protected virtual void configurarMenuOpEspeciales() { }
        protected virtual void procesarOpcionOpEspeciales() { }
        protected virtual void configurarMenuSeries() { }
        protected virtual void procesarOpcionSeries() { }

        protected void imprimirMenu()
        {
            clsConsola.LimpiarPantalla();
            clsConsola.EscribirSaltarLinea(atrItems[0]);
            for (int i = 1; i < atrItems.Length; i++)
                clsConsola.EscribirSaltarLinea(i + "." + atrItems[i]);
        }
        private void iterarMenu() // Patron de Diseño: Metodo de Plantilla, Entorno vocabulario
        {
            do
            {
                imprimirMenu();
                atrOpcion = clsConsola.Leer<int>("Seleccione una Opcion -->");
                procesarOpcionMPrincipal();
            } while (atrOpcion != atrOpcionSalir);
        }
        #endregion
    }
}