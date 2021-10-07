using System;

namespace NutriSalud.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumeroContacto { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public Genero Sexo { get; set; }

    }
}
