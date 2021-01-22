using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;

namespace WebFinalodevi.Models

{
    [Serializable]
    public class konsol
    {
        public virtual int Id { get; set; }
        public virtual string marka { get; set; }
        public virtual string hafıza { get; set; }
        
        public virtual ICollection<oyunlar> oyunlarim { get; set; } = new List<oyunlar>();
    }

    /*
    [Id] [int] NOT NULL,
	[Ad] [nvarchar](20) NOT NULL,
	[Sube] [nvarchar](30) NULL,
	[Telefon] [nvarchar](20) NULL,
	[Sehir] [nvarchar](30) NULL,
    */

    public class konsolMap : ClassMapping<konsol>
    {
        public konsolMap()
        {
            Table("konsol");
            Id(x => x.Id, m => m.Generator(Generators.Native));
            Property(x => x.marka, c => c.Length(20));
            Property(x => x.hafıza, c => c.Length(20));
        

            Set(e => e.oyunlarim,
                mapper =>
                {
                    mapper.Key(k => k.Column("konsol"));
                    mapper.Inverse(true);
                    mapper.Cascade(Cascade.All);
                },
               relation => relation.OneToMany(mapping => mapping.Class(typeof(oyunlar))));
        }
    }
}