
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListaTelefonica.Interface.Models
{
    public class AgendaModels
    {
        public int IdAgenda { get; set; }
        public string NomeContato { get; set; }
        public string EmailResidencial { get; set; }
        public string EmailComercial { get; set; }
        public string EmailOutro { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneComercial { get; set; }
        public string TelefoneOutro { get; set; }
        public string Empresa { get; set; }
        public string Endereco { get; set; }
        public string TelefoneContato { get; set; }
        public string EmailContato { get; set; }
    }
}