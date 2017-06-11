using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2013106853_ENT;

namespace _2013106853_PER.EntitesConfigurations
{
    public class ParabrisaConfiguration : EntityTypeConfiguration<Parabrisas>
    {
        public ParabrisaConfiguration()
        {
            //Table Configurations
            ToTable("Parabrisas");

            HasKey(a => a.ParabrisasId);

            Property(a => a.NumSerie);

            //Relations Configurations
        }
    }
}
