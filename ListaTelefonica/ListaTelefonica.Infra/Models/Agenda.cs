
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefonica.Infra.Models
{
    public class Agenda
    {
    
        public virtual int IdAgenda { get; set; }
        public virtual string NomeContato { get; set; }
        public virtual string EmailResidencial { get; set; }
        public virtual string EmailComercial { get; set; }
        public virtual string EmailOutro { get; set; }
        public virtual string TelefoneResidencial { get; set; }
        public virtual string TelefoneComercial { get; set; }
        public virtual string TelefoneOutro { get; set; }
        public virtual string Empresa { get; set; }
        public virtual string Endereco { get; set; }
        public virtual string TelefoneContato { get; set; }
        public virtual string EmailContato { get; set; }

    }
}
