using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUserDal:IGenericDal<Users>
    {
        Users Login(Users p);
        Users whoUser(string name);
    }
}
