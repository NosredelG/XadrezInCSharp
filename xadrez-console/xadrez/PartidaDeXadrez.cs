using System;
using tabuleiro;

namespace xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.IncrementarQteMovimentos();
            Peca capturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {
            tab.ColocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('a', 2).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('b', 2).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('f', 2).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('g', 2).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('h', 2).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('a', 7).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('b', 7).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('c', 7).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('d', 7).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('e', 7).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('f', 7).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('g', 7).ToPosicao());
            tab.ColocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('h', 7).ToPosicao());

            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 3).ToPosicao());
        }
    }
}
