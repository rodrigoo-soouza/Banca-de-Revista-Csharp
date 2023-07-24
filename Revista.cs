using System;

namespace Banca
{
    public class Revista : Produto
    {
        public string Editora { get; set; }

        public Revista(int codigo, string nome, string editora) : base(codigo, nome)
        {
            Editora = editora;
        }


    }
}
