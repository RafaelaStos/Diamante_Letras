namespace DiamanteLetra.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inicio = 'A';

            Console.WriteLine("Informe um letra do alfabeto: ");
            char opcao = Convert.ToChar(Console.ReadLine());

            int espaco = -1;

            espaco = parteSuperior(inicio, opcao, espaco);
            espaco = parteInferior(inicio, opcao, espaco);

        }

        private static int parteInferior(char inicio, char opcao, int espaco)
        {
            int margem = 0;
            for (char letra = opcao; letra >= inicio; letra--)
            {

                for (int i = 0; i < margem; i++)
                {
                    Console.Write(" ");
                }
                margem++;
                Console.Write(letra);

                for (int i = 0; i < espaco; i++)
                {
                    Console.Write(" ");
                }

                espaco -= 2;
                if (letra == 'A')
                    Console.WriteLine();
                else
                    Console.WriteLine(letra);
            }

            return espaco;
        }

        private static int parteSuperior(char inicio, char opcao, int espaco)
        {
            int margem = opcao - inicio;
            for (char letra = inicio; letra < opcao; letra++)
            {

                for (int i = 0; i < margem; i++)
                {
                    Console.Write(" ");
                }
                margem--;
                Console.Write(letra);

                for (int i = 0; i < espaco; i++)
                {
                    Console.Write(" ");
                }

                espaco += 2;
                if (letra == 'A')
                    Console.WriteLine();
                else
                    Console.WriteLine(letra);
            }

            return espaco;
        }
    }
}
