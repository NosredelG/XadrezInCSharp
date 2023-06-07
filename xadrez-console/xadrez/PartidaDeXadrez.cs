using System;
using tabuleiro;

namespace xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
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

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            turno++;
            MudaJogador();
        }

        public void ValidarPosicaoDeOrigem(Posicao pos)
        {            
            if (tab.peca(pos) == null)
            {
                throw new TabuleiroException("Nao existe peca na posicao escolhida!");
            }
            if (tab.peca(pos).cor != jogadorAtual)
            {
                throw new TabuleiroException("A peca escolhida nao e sua!");
            }
            if (!tab.peca(pos).ExisteMovimentosPossiveis())
            {
                throw new TabuleiroException("Nao ha movimentos possiveis para esta peca!");
            }
        }

        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).PodeMoverPara(destino))
            {
                throw new TabuleiroException("Posicao de destino invalida!");
            }            
        }

        private void MudaJogador()
        {
            if(jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
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

            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('f', 1).ToPosicao());
        }
    }
}
