namespace CodexApp.Models
{
    public class AumentoLimite(int pin, int nuevoLimite)
    {
        public int Pin { get; set; } = pin;
        public int NuevoLimite { get; set; } = nuevoLimite;
    }
}
