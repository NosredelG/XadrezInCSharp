using tabuleiro;

namespace xadrez
{
    internal class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        private bool ExisteInimigo(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p!= null && p.cor != cor;
        }

        private bool Livre(Posicao pos)
        {
            return tab.peca(pos) == null;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            if(cor == Cor.Branca)
            {
                //andar uma casa
                pos.DefinirValores(posicao.linha - 1, posicao.coluna);
                if (tab.PosicaValida(pos) && Livre(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                //andar duas casas
                pos.DefinirValores(posicao.linha - 2, posicao.coluna);
                if (tab.PosicaValida(pos) && Livre(pos) && qteMovimentos == 0)
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                //pegar inimigo diagonal direita
                pos.DefinirValores(posicao.linha - 1, posicao.coluna + 1);
                if (tab.PosicaValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                //pegar inimigo diagonal direita
                pos.DefinirValores(posicao.linha - 1, posicao.coluna - 1);
                if (tab.PosicaValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }

            }
            if (cor == Cor.Preta)
            {
                //andar uma casa
                pos.DefinirValores(posicao.linha + 1, posicao.coluna);
                if (tab.PosicaValida(pos) && Livre(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                //andar duas casas
                pos.DefinirValores(posicao.linha + 2, posicao.coluna);
                if (tab.PosicaValida(pos) && Livre(pos) && qteMovimentos == 0)
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                //pegar inimigo diagonal direita
                pos.DefinirValores(posicao.linha + 1, posicao.coluna + 1);
                if (tab.PosicaValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                //pegar inimigo diagonal direita
                pos.DefinirValores(posicao.linha + 1, posicao.coluna - 1);
                if (tab.PosicaValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
            }

            return mat;
        }

        public override string ToString()
        {
            return "P";
        }
    }
}
