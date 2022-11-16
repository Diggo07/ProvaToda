using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mercearia_seu_joao.Model
{
    internal class ProdutoBD
    {
        public int id { get; set; }
        public int nome { get; set; }
        public int quantidade { get; set; }
        public int fornecedor { get; set; }
        public int precoUnitario { get; set; }
        public int dataHoraAlteracao { get; set; }
        public int dataHoraExclusao { get; set; }
     
    }
}
