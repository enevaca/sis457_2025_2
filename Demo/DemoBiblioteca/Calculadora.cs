namespace DemoBiblioteca
{
    public class Calculadora
    {
        public static int sumar(int numero1, int numero2) 
        {
            return numero1 + numero2;
        }

        public static int restar(int numero1, int numero2) => numero1 - numero2;

        public static Func<int, int, int> multplicar = (numero1, numero2) => numero1 * numero2;

        public static int dividir(int numero1, int numero2) => numero1 / numero2;

        public static int modulo(int numero1, int numero2) => numero1 % numero2;
    }
}
