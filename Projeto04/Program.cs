using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto04{
    internal class Program{
        static void Main(string[] args){
            Produto p = new Produto();
            Console.WriteLine("Insira os dados do produto;");
            Console.Write("Nome; ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço; ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque; ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados do produto; " + p);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado; ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados! ");
            Console.WriteLine(p);
            Console.WriteLine("Digite o número de produtos a ser removido; ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados! ");
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
