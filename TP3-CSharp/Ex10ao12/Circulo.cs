using System;

namespace Ex10ao12
{
    public class Circulo
    {
        double PI = Math.PI;
        public double raio;

        public double calcularAreaCirculo()
        {
            double area = PI * Math.Pow(raio, 2);
            Console.WriteLine($"Area: {area:N2}");
            return area;
        }
    }
}