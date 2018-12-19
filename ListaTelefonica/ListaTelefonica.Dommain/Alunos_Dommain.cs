using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefonica.Dommain
{
    public class Alunos_Dommain
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual string Curso { get; set; }
        public virtual string Sexo { get; set; }
    }
}
