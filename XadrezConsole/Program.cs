using tabuleiro;
using xadrez;
using XadrezConsole;


try
{
    Tabuleiro tab = new Tabuleiro(8, 8);

    tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 8));
    tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
    tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 2));

    Tela.ImprimirTabuleiro(tab);

} catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}