using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projCoisa
{
    class Program
    {
        static void Main(string[] args)
        {
            Coisas minhasCoisas = new Coisas(5);
            Console.WriteLine("Qtde de elementos: {0}/{1}", minhasCoisas.Qtde, minhasCoisas.Max);
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(1, "Bola")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(2, "Casa")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(3, "PC")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine("Qtde de elementos: {0}/{1}", minhasCoisas.Qtde, minhasCoisas.Max);
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(4, "Pirulito")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(5, "Esfiha")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(6, "Escova de dente")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine("Qtde de elementos: {0}/{1}", minhasCoisas.Qtde, minhasCoisas.Max);
            Console.WriteLine(minhasCoisas.mostrar());

            Coisa coisinhaPesquisada = minhasCoisas.pesquisar(new Coisa(4));
            if (coisinhaPesquisada.Id == -1)
                Console.WriteLine("Não encontrado");
            else
                Console.WriteLine(coisinhaPesquisada.ToString());

        }
    }
}
