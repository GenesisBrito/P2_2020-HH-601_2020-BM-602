namespace P2_2020_HH_601_2020_BM_602.Models
{
    public class CasoReportado
    {
        public int Id { get; set; }
        public int DepartamentoId { get; set; }
        public int GeneroId { get; set; }
        public int NumeroCasos { get; set; }
        public int NumeroCasosRecuperados { get; set; }
        public int NumeroCasosFallecidos { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relación con la tabla Departamentos
        public Departamento Departamento { get; set; }

        // Relación con la tabla Generos
        public Genero Genero { get; set; }
    }
}
