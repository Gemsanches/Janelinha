using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janelinha.Cadastros
{
    class Cliente
    {
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }
    }
}
