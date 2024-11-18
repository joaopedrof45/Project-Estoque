
using System.Globalization;

namespace PrimeiroApp
{
    internal class Produto
    {
        public string? nome;
        public double preco;
        public int quantidade;


        public double ValorTotalEmEstoque() {
            return preco * quantidade;
        }

        // para sobrescrever a classe que tem a função de mostrar o obejto se n vai retoranr algo como classe.objeto
        // ao inves dos dados 
        public override string ToString()
        {
            return nome + ", $ "+ preco.ToString("F2", CultureInfo.InvariantCulture)+", "+quantidade+" unidades, Total: $ "
                +ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
            
        }
        public void AdicionarSaldo(int qtd) 
        {
            quantidade = quantidade + qtd;
        }

        public void RemoverSaldo(int qtd)
        {
            quantidade = quantidade - qtd;
        }

    }

   

}
