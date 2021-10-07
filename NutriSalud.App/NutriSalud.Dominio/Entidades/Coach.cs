using System;

namespace NutriSalud.Dominio
{
    // Coach hereda de la clase "persona"    
    public class Coach : Persona
    {
        public char Tipo { get; set; }
        public string Correo { get; set; }
        public string TarjetaPro { get; set; }

        //Relacion con la clase "Paciente"
        public Paciente Paciente { get; set; }

    }
}