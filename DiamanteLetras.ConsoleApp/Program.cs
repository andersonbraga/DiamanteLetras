namespace DiamanteLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
            char[] letrasAlfabeto = alfabeto.ToCharArray();
            Console.WriteLine("Insira uma letra: ");
            char letraEscolhida = Convert.ToChar(Console.ReadLine().ToUpper());
            int indice = 1;

            for (int i = 0; i < letrasAlfabeto.Length; i++)
            {
                if (letraEscolhida == letrasAlfabeto[i])
                {

                    indice += Array.IndexOf(letrasAlfabeto, letraEscolhida);
                    //Console.WriteLine(indice); voltou o index correto

                    for (int j = 0; j <= indice -1; j++)
                    {
                      
                        for (int k = 0; k < indice - j; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int h = 0; h < 1; h++)
                        {
                            Console.Write(letrasAlfabeto[j]);

                            for (int k = 0; k <= 2 * j - 2; k++)
                            {
                                Console.Write(" ");
                            }

                            if (j != 0)
                            {
                                Console.Write(letrasAlfabeto[j]);
                            }
                            Console.WriteLine();
                        }

                    }

                    for (int j = indice -2; j >= 0; j--)
                    {

                        for (int k = 0; k < indice - j; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int h = 0; h < 1; h++)
                        {
                            Console.Write(letrasAlfabeto[j]);

                            for (int k = 0; k <= 2 * j - 2; k++)
                            {
                                Console.Write(" ");
                            }

                            if (j != 0)
                            {
                                Console.Write(letrasAlfabeto[j]);
                            }
                            Console.WriteLine();
                        }

                    }
                }
            }
        }
    }
}


