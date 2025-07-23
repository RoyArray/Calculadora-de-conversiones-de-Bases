using System;
using Calculadora_de_conversiones_de_Bases.Models;
using Calculadora_de_conversiones_de_Bases.Services;
using Calculadora_de_conversiones_de_Bases.Data;

namespace Calculadora_de_conversiones_de_Bases
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnConvertir_Click(object sender, EventArgs e)
        {
            var numero = txtNumero.Text;
            var baseOrigen = ddlBaseOrigen.SelectedValue;
            var baseDestino = ddlBaseDestino.SelectedValue;

            try
            {
                var servicio = new ConvertidorService();
                var resultado = servicio.Convertir(numero, baseOrigen, baseDestino);
                lblResultado.Text = resultado;

                var conversion = new Conversion
                {
                    NumeroEntrada = numero,
                    BaseOrigen = baseOrigen,
                    BaseDestino = baseDestino,
                    Resultado = resultado
                };

                var repo = new ConversionRepository();
                repo.GuardarConversion(conversion);
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }
    }
}
