using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2013106853_ENT;

namespace _2013106853_PER.EntitesConfigurations
{
    public class PropietarioConfiguration : EntityTypeConfiguration<Propietario>
    {
        public PropietarioConfiguration()
        {
            //Table Configurations
            ToTable("Propietarios");

            HasKey(a => a.PropietarioId);

            Property(a => a.DNI);
            Property(a => a.Nombres);
            Property(a => a.Apellidos);
            Property(a => a.LicenciaConducir);

        }
    }
}
