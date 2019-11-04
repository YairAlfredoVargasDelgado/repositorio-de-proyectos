namespace Models
{
    public class Persona
    {
        public string Identificación { get; set; }

        public Sexo Sexo { get; set; }

        public int Edad { get; set; }

        public string Nombres { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        public Persona() { }
    }
}