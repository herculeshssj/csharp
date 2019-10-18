using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K32_Cap3_K19EntityFramework
{
    [Table("tbl_aluno")]
    class Aluno
    {
        public int AlunoID { get; set; }

        [Required]
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }
    }
}
