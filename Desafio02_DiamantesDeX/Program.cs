namespace Desafio02_DiamantesDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Qual o tamanho do diamante? (Somente números ímpares)");

                int numeroEscolhido = 0;

                ApenasNumeroImpar(ref numeroEscolhido);

                CriaDiamante(numeroEscolhido); //Apenas "for" e "if" - Código mais lento

                //CriaDiamante2(numeroEscolhido); //Com "new string()" e "for" - Código mais rápido

                PulaLinha();
            }
        }

        private static void CriaDiamante2(int tamanhoDiamante)
        {
            int meio = (tamanhoDiamante - 1) / 2;

            PulaLinha();

            for (int i = 1; i <= tamanhoDiamante; i = i + 2)
            {
                Console.WriteLine(new string(' ', meio--) + new string('x', i));
            }
            ++meio;
            for (int i = tamanhoDiamante - 2; i >= 1; i = i - 2)
            {
                Console.WriteLine(new string(' ', ++meio) + new string('x', i));
            }
        }

        private static void CriaDiamante(int tamanhoDiamante)
        {
            char[] areaDiamante = new char[tamanhoDiamante];

            int meio = (areaDiamante.Length - 1) / 2;

            int contador = 0;

            for (int i = 0; i < tamanhoDiamante; i++)
            {
                areaDiamante[i] = ' ';
            }

            for (int i = 0; i < areaDiamante.Length; i++)
            {
                if (i == 0)
                {
                    PulaLinha();
                    areaDiamante[meio] = 'x';
                }
                else if (i < meio + 1)
                {
                    areaDiamante[meio + i] = 'x';
                    areaDiamante[meio - i] = 'x';
                }
                else
                {
                    areaDiamante[contador] = ' ';
                    areaDiamante[areaDiamante.Length - 1 - contador] = ' ';
                    contador++;
                }

                foreach (char construtor in areaDiamante)
                {
                    Console.Write(construtor);
                }

                PulaLinha();
            }
        }

        private static void ApenasNumeroImpar(ref int numero)
        {
            bool VerificaEntrada;

            do
            {
                Console.Write("Tamanho Diamante: ");
                string entrada = Console.ReadLine();
                VerificaEntrada = int.TryParse(entrada, out numero);

                if (!VerificaEntrada || numero % 2 == 0)
                {
                    Console.WriteLine("\nValor Inválido! (Somente números ímpares)");
                }
            }
            while (!VerificaEntrada || numero % 2 == 0);
        }

        private static void PulaLinha()
        {
            Console.WriteLine("");
        }
    }
}