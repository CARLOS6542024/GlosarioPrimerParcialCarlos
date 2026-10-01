namespace GlosarioPrimerParcialCarlos.Models
{
    public class Termino
    {
        public string Palabra { get; set; } = "";

        public string Definicion { get; set; } = "";

        public DateTime FechaAgregado { get; set; } = DateTime.Now;
    }
}
