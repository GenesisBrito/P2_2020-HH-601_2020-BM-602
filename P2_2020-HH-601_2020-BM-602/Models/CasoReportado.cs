namespace P2_2020_HH_601_2020_BM_602.Models
{
    public class CasoReportado
    {
        public int Id_CasoReportado { get; set; }
        public int Departamento_Id { get; set; }
        public int Genero_Id { get; set; }
        public int Numero_Casos { get; set; }
        public int NumeroCasos_Recuperados { get; set; }
        public int NumeroCasos_Fallecidos { get; set; }
        public DateTime Fecha_Registro { get; set; }

        // Relación con la tabla Departamentos
        public Departamento? Departamento { get; set; }

        // Relación con la tabla Generos
        public Genero? Genero { get; set; }
    }
}
