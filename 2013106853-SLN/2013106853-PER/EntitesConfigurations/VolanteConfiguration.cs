using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2013106853_ENT;

namespace _2013106853_PER.EntitesConfigurations
{
    public class VolanteConfiguration : EntityTypeConfiguration<Volante>
    {
        public VolanteConfiguration()
        {
            //Table Configurations
            ToTable("Volante");

            HasKey(a => a.VolanteId);

            Property(a => a.NumSerie);
        }
    }
}
