using DotLiquid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    public class Doce : Produto
    {
        public string Marca { get; set; }

        public Doce(int codigo, string nome, string marca) : base(codigo, nome)
        {

            Marca = marca;
        }
    }
}
