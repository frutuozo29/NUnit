using System;

namespace Calculadora
{
    public class Calculadora
    {
        public float Somar(float a, float b)
        {
            return a + b;
        }

        public float Subtrair(float a, float b)
        {
            return a - b;
        }

        public float Multiplicar(float a, float b)
        {
            return a * b;
        }

        public float Dividir(float a, float b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException("Não pode ser dividido por zero");
            }
        }
    }
}
