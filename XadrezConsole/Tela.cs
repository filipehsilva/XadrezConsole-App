using tabuleiro;

namespace XadrezConsole
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int c = 0; c < tab.Colunas; c++)
                {
                    if (tab.Peca(i, c) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write($"{tab.Peca(i, c)} ");

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
