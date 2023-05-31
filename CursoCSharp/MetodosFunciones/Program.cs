namespace MetodosFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saludo = Saludo("Anderson", "Mena");
            Console.WriteLine(saludo);

            EstoEsUnMetodo();

            int numero = 0;

            Console.WriteLine(String.Format("Número inicial {0}",numero));

            // Modificanado el número
            CambiarValor(ref numero);


            Console.WriteLine(String.Format("Número cambiado por referencia {0}", numero));

        }

        #region Metodos
        // El void solo ejecuta código
        public static void EstoEsUnMetodo()
        {
            Console.WriteLine("No retorno valor");
        }

        public static string Saludo(string nombre, string apellido)
        {
            return String.Format("Mi nombre es: {0} {1}", nombre, apellido);
        }

        public static void CambiarValor(ref int numero) 
        {
            numero = 2;
        }
        #endregion

        #region Procedimiento
        void Procedimeinto()
        {
            Console.WriteLine("Esto es un procedimiento");
        }
        #endregion

        #region Funciones
        int FuncionSuma(int a, int b)
        {
            return a + b;
        }
        #endregion
    }
}