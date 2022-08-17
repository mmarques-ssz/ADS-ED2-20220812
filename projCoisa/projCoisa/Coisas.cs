using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projCoisa
{
    class Coisas
    {
        private Coisa[] asCoisas;
        private int max;
        private int qtde;

        public int Max { get => max; }
        public int Qtde { get => qtde; }
        public Coisa[] AsCoisas { get => asCoisas; }

        public Coisas(int max)
        {
            this.max = max;
            this.qtde = 0;
            asCoisas = new Coisa[this.max];
            for(int i=0; i<this.max; ++i)
            {
                asCoisas[i] = new Coisa(-1,"...");
            }
        }

        public string mostrar()
        {
            string s = "";
            foreach(Coisa c in asCoisas)
            {
                s += c.ToString();
            }
            return s;
        }

        public bool adicionar(Coisa c)
        {
            bool podeAdicionar = (this.qtde < this.max);
            if (podeAdicionar)
            {
                this.asCoisas[this.qtde] = c;
                this.qtde++;
            }
            return podeAdicionar;
        }

        public Coisa pesquisar(Coisa c)
        {
            Coisa coisaAchada = new Coisa(-1, "...");
            int i = 0;
            while (i < this.max && this.asCoisas[i].Id!=c.Id)
            {
                i++;
            }
            if (i<this.max)
            {
                coisaAchada = this.asCoisas[i];
            }
            return coisaAchada;
        }

        public bool remover(Coisa c)
        {

            return true;
        }
    }
}
