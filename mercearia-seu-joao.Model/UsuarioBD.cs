using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mercearia_seu_joao.Model
{
    public class UsuarioBD
    {
        public int id { get; set; }
        public int nome { get; set; }
        public int email { get; set; }
        public int senha { get; set; }
        public int tipoUsuario { get; set; }
        public int dataHoraAlteracao { get; set; }
        public int dataHoraExclusao { get; set; }
    }
}
