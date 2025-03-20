using System;

namespace Ex10ao12
{
    public class Esfera
    {
        public double raio;
        double PI = Math.PI;


        public double calcularVolumeEsfera()
        {
            double volume = (4.0 / 3) * PI * Math.Pow(raio, 3);
            Console.WriteLine($"volume: {volume:F2}");
            return volume;
        }
    }
}