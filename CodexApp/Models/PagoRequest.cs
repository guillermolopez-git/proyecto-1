namespace CodexApp.Models
{
    public class PagoRequest(int pin, string descripcion, decimal monto)
    {
        public int Pin { get; set; } = pin;
        public string? Descripcion { get; set; } = descripcion;
        public decimal Monto { get; set; } = monto;
    }
}
