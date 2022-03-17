using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBanco
{
    public class Registro
    {
        private int cuenta;
        private string primerNombre;
        private string apellidoPaterno;
        private decimal saldo;

        // El constructor sin parámetros establece los miembros
        // a los valores predeterminados
        public Registro() : this(0, "", "", 0.0M)
        {

        } // fin del constructor

        // El constructor sobrecargado, establece los miembros
        // a los valores de los parámetros
        public Registro(int valorCuenta, string valorPrimerNombre,
            string valorApellidoPaterno, decimal valorSaldo)
        {
            Cuenta = valorCuenta;
            PrimerNombre = valorPrimerNombre;
            ApellidoPaterno = valorApellidoPaterno;
            Saldo = valorSaldo;
        } // fin del constructor

        // Propiedad que obtiene y establece Cuenta
        public int Cuenta { get => cuenta; set => cuenta = value; }

        // Propiedad que obtiene y establece PrimerNombre
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }

        // Propiedad que obtiene y establece Apellido
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }

        // Propiedad que obtiene y establece Saldo
        public decimal Saldo { get => saldo; set => saldo = value; }
    } // fin de la clase Registro
}
