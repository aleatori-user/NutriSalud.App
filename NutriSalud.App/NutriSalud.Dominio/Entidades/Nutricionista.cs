using System;

namespace NutriSalud.Dominio
{
    // Nutricionista hereda de la clase "persona"
    public class Nutricionista : Persona
    {
        public char Tipo { get; set; }
        public string Correo { get; set; }
        public string TarjetaPro { get; set; }

        //Relacion con la clase "Paciente"
        public Paciente Paciente { get; set; }

        //Relacion con la clase "Recomendaciones"
        public Recomendacion Recomendacion { get; set; }

    }
}