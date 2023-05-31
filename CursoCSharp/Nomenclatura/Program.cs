using System;

namespace Nomenclatura
{
    internal class Program
    {
        //Variable privada
        private readonly string _estaEsMiCadena;
        static void Main(string[] args)
        {
            // Camel case
            var estoEsUnaVariable = "Camel";

            // Pascal 
            var EstoEsUnaVariable = "Pascal";

            Program program = new Program();
            program.SumarDosNummeros(1, 2);
        }

        public void SumarDosNummeros(int numeroUno, int numeroDos)
        {
            Console.WriteLine(numeroUno + numeroDos);
        }
    }
}
