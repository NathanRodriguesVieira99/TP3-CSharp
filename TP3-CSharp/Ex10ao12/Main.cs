using System;

namespace Ex10ao12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();
            circulo.raio = 3.0;
            circulo.calcularAreaCirculo();

            Esfera esfera = new Esfera();
            esfera.raio = 5.0;
            esfera.calcularVolumeEsfera();

        }
    }
}