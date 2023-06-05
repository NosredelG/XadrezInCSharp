using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));

            tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 7));

            Tela.ImprimirTabuleiro(tab);
        }
    }
}
