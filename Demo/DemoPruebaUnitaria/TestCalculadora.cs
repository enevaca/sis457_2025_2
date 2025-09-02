using DemoBiblioteca;

namespace DemoPruebaUnitaria
{
    [TestClass]
    public sealed class TestCalculadora
    {
        [TestMethod]
        public void TestSuma()
        {
            // Definimos las variables -> Arrage
            int numero1 = 6;
            int numero2 = 7;

            // Ejecutamos la prueba -> Act
            int resultado = Calculadora.sumar(numero1, numero2);

            // Comprobamos los resultados -> Assert
            int resultadoEsperado = 13;
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void TestResta()
        {
            int numero1 = 10, numero2 = 6;
            int resultado = Calculadora.restar(numero1, numero2);
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            int numero1 = 10, numero2 = 6;
            int resultado = Calculadora.multplicar(numero1, numero2);
            Assert.AreEqual(60, resultado);
        }

        [TestMethod]
        public void TestDivision()
        {
            int numero1 = 10, numero2 = 6;
            int resultado = Calculadora.dividir(numero1, numero2);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void TestDivisionPorCero()
        {
            int numero1 = 10, numero2 = 0;
            Assert.ThrowsException<DivideByZeroException>(() => Calculadora.dividir(numero1, numero2));
        }

        [TestMethod]
        public void TestModulo()
        {
            int numero1 = 10, numero2 = 6;
            int resultado = Calculadora.modulo(numero1, numero2);
            Assert.AreEqual(4, resultado);
        }
    }
}
