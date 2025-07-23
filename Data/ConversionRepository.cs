using System.Data.SqlClient;
using Calculadora_de_conversiones_de_Bases.Models;

namespace Calculadora_de_conversiones_de_Bases.Data
{
    public class ConversionRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=ConversorDB;Integrated Security=True";

        public void GuardarConversion(Conversion conversion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Conversiones (NumeroEntrada, BaseOrigen, BaseDestino, Resultado) VALUES (@num, @baseOrigen, @baseDestino, @resultado)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@num", conversion.NumeroEntrada);
                cmd.Parameters.AddWithValue("@baseOrigen", conversion.BaseOrigen);
                cmd.Parameters.AddWithValue("@baseDestino", conversion.BaseDestino);
                cmd.Parameters.AddWithValue("@resultado", conversion.Resultado);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
