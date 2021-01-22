using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFinalodevi.Models
{
    public class oyunlar
    {
        public virtual int Id { get; set; }
        public virtual string oyunisim { get; set; }
        public virtual string fiyat { get; set; }
        public virtual konsol konsol { get; set; }

    }

    public class oyunlarMap : ClassMapping<oyunlar>
    {
        public oyunlarMap()
        {
            Table("oyunlar");
            Id(x => x.Id, m => m.Generator(Generators.Native));
            Property(x => x.oyunisim, c => c.Length(40));
            Property(x => x.fiyat, c => c.Length(20));
            ManyToOne(x => x.konsol);
        }
    }
}