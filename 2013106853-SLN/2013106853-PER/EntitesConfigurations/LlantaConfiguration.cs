﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2013106853_ENT;

namespace _2013106853_PER.EntitesConfigurations
{
    public class LlantaConfiguration : EntityTypeConfiguration<Llanta>
    {
        public LlantaConfiguration()
        {
            //Table Configurations
            ToTable("Llantas");

            HasKey(a => a.LlantaId);

            Property(a => a.NumSerie);

            //Relations Configurations

            //relacion composicion (1 a *)
            HasRequired(c => c.Carro)
                .WithMany(c => c.Llantas);

        }

    }
}
