namespace Banca
{
    public class Bebida : Produto
    {
        public string Tipo { get; set; }

        public Bebida(int codigo, string nome, string tipo) : base(codigo, nome)
        {

            Tipo = tipo;
        }


    }
}
