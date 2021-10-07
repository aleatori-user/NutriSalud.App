using System;

namespace NutriSalud.Dominio
{
    public class HistoricoPaciente
    {
        public int Id { get; set; }
        public string Platillos { get; set; }
        public double Palorias { get; set; }
        public double Carbohidratos { get; set; }
        public double Proteinas { get; set; }
        public double Grasa { get; set; }
        public double Peso { get; set; }
        public double Medidas { get; set; }
    }
}