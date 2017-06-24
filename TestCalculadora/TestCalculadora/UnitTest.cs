using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace TestCalculadora
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestarSoma()
        {
            var calculadora = new Calculadora.Calculadora();
            NUnit.Framework.Assert.AreEqual(2, calculadora.Somar(1, 1));
        }

        [Test]
        public void TestarSubtracao()
        {
            var calculadora = new Calculadora.Calculadora();
            NUnit.Framework.Assert.AreEqual(25, calculadora.Subtrair(50, 25));
        }

        [Test]
        public void TestarMultiplicacao()
        {
            var calculadora = new Calculadora.Calculadora();
            NUnit.Framework.Assert.AreEqual(25, calculadora.Multiplicar(5, 5));
        }

        [Test]
        public void TestarDivisao()
        {
            var calculadora = new Calculadora.Calculadora();
            NUnit.Framework.Assert.AreEqual(100, calculadora.Dividir(200, 2));
        }

        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestarDivisaoPorZero()
        {
            var calculadora = new Calculadora.Calculadora();
            calculadora.Dividir(50, 0);
        }

        [Test]
        [NUnit.Framework.Ignore("Esse método de teste não será executado")]
        public void TestarIgnorado()
        {
            var calculadora = new Calculadora.Calculadora();
            calculadora.Dividir(50, 0);
        }

    }
}
