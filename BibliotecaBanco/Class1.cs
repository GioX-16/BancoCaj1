using System;

namespace BibliotecaBanco
{
    public class Registro
    {
        private int cuenta;
        private string Primernombre;
        private string Apellidopaterno;
        private decimal saldo;

        // El constructor sin parametros establece los miembros //
        //a los valores predeterminados //

        public Registro() : this(0, "", "", 0.0M)
        {

        }

        /*El constructor sobre cargado, establece los miembros
         a los valores de los parametros */

        public Registro(int ValorCuenta, string valorprimernombre,
            string valorApellidoPaterno, decimal valorSaldo)
        {
            cuenta = ValorCuenta;
            Primernombre = valorprimernombre;
            Apellidopaterno = valorApellidoPaterno;
            saldo = valorSaldo;
        }  // FIN DEL CONSTRUCTOR 

        public int Cuenta { get => cuenta; set => cuenta = value; }
        public string Primernombre1 { get => Primernombre; set => Primernombre = value; }
        public string Apellidopaterno1 { get => Apellidopaterno; set => Apellidopaterno = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }

        // Propiedad que obtiene y establece cuenta // 

    }
}
