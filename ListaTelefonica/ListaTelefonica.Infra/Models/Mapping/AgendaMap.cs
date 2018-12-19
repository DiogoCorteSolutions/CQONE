using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ListaTelefonica.Infra.Models.Mapping
{
    public class AgendaMap : ClassMap<Agenda>
    {
        public AgendaMap()
        {
            Id(x => x.IdAgenda);
            Map(x => x.NomeContato);
            Map(x => x.EmailResidencial);
            Map(x => x.EmailComercial);
            Map(x => x.EmailOutro);
            Map(x => x.TelefoneResidencial);
            Map(x => x.TelefoneComercial);
            Map(x => x.TelefoneOutro);
            Map(x => x.Empresa);
            Map(x => x.Endereco);
            Map(x => x.TelefoneContato);
            Map(x => x.EmailContato);
            Table("TB_AGENDATEL");

        }
    }
}
