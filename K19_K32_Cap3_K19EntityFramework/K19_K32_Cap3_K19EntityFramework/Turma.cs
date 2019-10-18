using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K19_K32_Cap3_K19EntityFramework
{
    [Table("tbl_turma")]
    class Turma
    {
        public int TurmaID { get; set; }

        [Required]
        public int Vagas { get; set; }

        public Professor Professor { get; set; }

        public ICollection<Aluno> Alunos { get; set; }
    }
}
