namespace Banca
{
    public abstract class Produto
    {

        protected int Codigo { get; set; }
        protected string Nome { get; set; }
        protected int Estoque { get; set; }
        protected double ValorUnitario { get; set; }

        public Produto(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }


        public void IncluirEstoque(int quantidade)
        {

            Estoque += quantidade;
        }

        public void TirarEstoque(int quantidade)
        {

            if (quantidade <= Estoque)
            {

                Estoque -= quantidade;
            }
            else
            {
                Console.WriteLine("Estoque Indisponivel!!!");

            }


        }
    }

}

