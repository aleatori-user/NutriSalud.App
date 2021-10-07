using System;

namespace NutriSalud.Dominio
{
    public class Recomendacion
    {
        public int Id { get; set; }
        public string Platillos { get; set; }
        public double Calorias { get; set; }
        public double Carbohidratos { get; set; }
        public double Proteinas { get; set; }
        public double Grasa { get; set; }
    }
}