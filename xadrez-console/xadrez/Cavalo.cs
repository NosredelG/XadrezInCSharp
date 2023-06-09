using tabuleiro;

namespace xadrez
{
    internal class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //acima-esquerda
            pos.DefinirValores(posicao.linha + 2, posicao.coluna - 1);
            if (tab.PosicaValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //acima-direita
            pos.DefinirValores(posicao.linha + 2, posicao.coluna + 1);
            if (tab.PosicaValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //abaixo-esquerda
            pos.DefinirValores(posicao.linha - 2, posicao.coluna - 1);
            if (tab.PosicaValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //abaixo-direita
            pos.DefinirValores(posicao.linha - 2, posicao.coluna + 1);
            if (tab.PosicaValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //direita-acima
            pos.DefinirValores(posicao.linha + 1, posicao.coluna + 2);
            if (tab.PosicaValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //direita-abaixo
            pos.DefinirValores(posicao.linha - 1, posicao.coluna + 2);
            if (tab.PosicaValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //esquerda-acima
            pos.DefinirValores(posicao.linha + 1, posicao.coluna - 2);
            if (tab.PosicaValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //esquerda-abaixo
            pos.DefinirValores(posicao.linha - 1, posicao.coluna - 2);
            if (tab.PosicaValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }

        public override string ToString()
        {
            return "C";
        }
    }
}
