using System.Text;

namespace ExemploDados.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preço {get; set ;}
        
        public int Estoque {get; private set ;}

        public Produto()
        {
            this.Estoque = 0;
        }

        public Produto (string Nome , double Preço)
        {
            this.Nome = Nome;
            this.Preço = Preço;
            this.Estoque = 0;
        }
        public int Vender(int qtde)
        {
            if(this.Estoque - qtde >= 0)
            {
                this.Estoque -= qtde;
            }
            return this.Estoque;
        }

        public int Comprar (int qtde)
        {
            this.Estoque += qtde;
            return this.Estoque;
        }

        public string ObterTexto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nNome: {this.Nome}\n");
             sb.Append($"Preço R$ : {this.Preço:F2}\n");
              sb.Append($"Estoque : {this.Estoque}\n");    
              return sb.ToString();
        }
        

        
    }
}