using System;

namespace Calculadora_de_conversiones_de_Bases.Models
{
    public class Conversion
    {
        public string NumeroEntrada { get; set; }
        public string BaseOrigen { get; set; }
        public string BaseDestino { get; set; }
        public string Resultado { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}