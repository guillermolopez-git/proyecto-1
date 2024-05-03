// Proposito: Modelo de la tarjeta de credito con una funcion para calcular el credito disponible.
using System.Text.Json.Serialization;

namespace CodexApp.Models
{
    public class Creditcard
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("numero")]
        public string? Numero { get; set; }

        [JsonPropertyName("nombre")]
        public string? Nombre { get; set; }

        [JsonPropertyName("expiracion")]
        public string? Expiracion { get; set; }

        [JsonPropertyName("limite")]
        public int Limite { get; set; }

        [JsonPropertyName("saldo")]
        public decimal Saldo { get; set; }

        [JsonPropertyName("cvv")]
        public int Cvv { get; set; }

        [JsonPropertyName("pin")]
        public int Pin { get; set; }

       public decimal SaldoDisp => Limite - Saldo;
    }
}
