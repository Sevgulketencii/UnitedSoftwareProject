using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.GenericRepository
{
    public class GenericRepository<Table> : IGenericDal<Table> where Table : class
    {
        Context baglan = new Context();

        public void add(Table x)
        {
            baglan.Set<Table>().Add(x);
            baglan.SaveChanges();
        }

        public Table getById(int id)
        {
            return baglan.Set<Table>().Find(id);
        }

        public List<Table> Listele()
        {
            return baglan.Set<Table>().ToList();
        }

        public void remove(Table y)
        {
            baglan.Set<Table>().Remove(y);
            baglan.SaveChanges();
        }

        public void update(Table p)
        {
            baglan.Set<Table>().Update(p);
            baglan.SaveChanges();
        }
    }
}
