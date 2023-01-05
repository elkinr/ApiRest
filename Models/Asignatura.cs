namespace ApiRest.Models
{
    public class Asignatura
    {
        public string Nombre { get; set; }

        public string Descripcion { get;set; }

        public int Creditos { get; set; }

        public string Area { get; set; }

        public Tipo tipo { get; set; }

    }

    public enum Tipo
    {
       Electiva = 0,
       Obligatoria = 1

    }
}
