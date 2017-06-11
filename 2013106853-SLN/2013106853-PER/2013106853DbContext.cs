using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2013106853_ENT;
using _2013106853_PER.EntitesConfigurations;

namespace _2013106853_PER
{
    public class _2013106853DbContext : DbContext
    {
        public DbSet<Asiento> Asientos { get; set; }



        public DbSet<Carro> Carros { get; set; }

        public DbSet<Cinturon> Cinturones { get; set; }


        public DbSet<Llanta> Llantas { get; set; }

        public DbSet<Parabrisas> Parabrisas { get; set; }

        public DbSet<Propietario> Propietarios { get; set; }

        public DbSet<Volante> Volantes { get; set; }

        public _2013106853DbContext() : base ("SolConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AsientoConfiguration());

            modelBuilder.Configurations.Add(new CarroConfiguration());

            modelBuilder.Configurations.Add(new CinturonConfiguration());
            modelBuilder.Configurations.Add(new LlantaConfiguration());
            modelBuilder.Configurations.Add(new ParabrisaConfiguration());
            modelBuilder.Configurations.Add(new PropietarioConfiguration());

            modelBuilder.Configurations.Add(new VolanteConfiguration());


            base.OnModelCreating(modelBuilder);
        }

        

    }
}
