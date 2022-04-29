using MVCCochesAwsAurora.Data;
using MVCCochesAwsAurora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCochesAwsAurora.Repositories
{
    public class RepositoryCoches
    {
        private CochesContext context;

        public RepositoryCoches(CochesContext context)
        {
            this.context = context;
        }

        public List<Coche> GetAllCoches()
        {
            return this.context.Coches.ToList();
        }

        public void InsertCoche(Coche coche)
        {
            this.context.Add(coche);
            this.context.SaveChanges();
        }
    }
}
