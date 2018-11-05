using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace two.Models
{
  
        public class LivreContext : DbContext
        {
            public LivreContext(DbContextOptions<LivreContext> options)
                : base(options)
            { }

            public DbSet<Livre> Livres { get; set; }
            public DbSet<Contenu> Contenus { get; set; }
        }

        public class Livre
        {
            public int LivreId { get; set; }
            public string LivreTitre { get; set; }
            public string LivreAuteur { get; set; }

        public ICollection<Contenu> Contenus { get; set; }
        }

        public class Contenu
        {
            public int ContenuId { get; set; }
            public string Resume { get; set; }
            public string Content { get; set; }

            public int LivreId { get; set; }
            public Livre Livre { get; set; }
        }
    
}

