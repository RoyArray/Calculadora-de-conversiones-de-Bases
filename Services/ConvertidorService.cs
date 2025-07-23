using System;

namespace Calculadora_de_conversiones_de_Bases.Services
{
    public class ConvertidorService
    {
        public string Convertir(string numero, string baseOrigen, string baseDestino)
        {
            int valorDecimal = ConvertirADecimal(numero, baseOrigen);
            return ConvertirDesdeDecimal(valorDecimal, baseDestino);
        }

        private int ConvertirADecimal(string numero, string baseOrigen)
        {
            int fromBase = BaseToInt(baseOrigen);
            return Convert.ToInt32(numero, fromBase);
        }

        private string ConvertirDesdeDecimal(int numeroDecimal, string baseDestino)
        {
            int toBase = BaseToInt(baseDestino);
            return Convert.ToString(numeroDecimal, toBase).ToUpper();
        }

        private int BaseToInt(string nombreBase)
        {
            switch (nombreBase.ToLower())
            {
                case "binario": return 2;
                case "octal": return 8;
                case "decimal": return 10;
                case "hexadecimal": return 16;
                default: throw new Exception("Base no soportada");
            }
        }
    }
}
