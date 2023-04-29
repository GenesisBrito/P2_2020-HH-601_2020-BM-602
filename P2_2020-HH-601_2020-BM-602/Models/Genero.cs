namespace P2_2020_HH_601_2020_BM_602.Models
{

    public class Genero
    {
        public int Id_Genero { get; set; }
        public string Nombre_Genero { get; set; }

        public Genero()
        {
            Nombre_Genero = string.Empty; // Asignar un valor predeterminado para evitar valores nulos
        }
    }
}
