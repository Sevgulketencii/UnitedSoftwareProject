using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericServices<Table> where Table:class
    {
        List<Table> Listele();
        void add(Table x);
        void remove(Table y);
        void update(Table p);
        Table getById(int id);
    }
}
