using System;

namespace NutriSalud.Dominio
{
    public class Paciente : Persona
    {
        public char Tipo { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }

        //Relacion con la clase "Recomendaciones"
        public Recomendacion Recomendacion { get; set; }

        //Relacion con la clase "HistoricoPaciente"
        public HistoricoPaciente HistoricoPaciente { get; set; }
    }
}