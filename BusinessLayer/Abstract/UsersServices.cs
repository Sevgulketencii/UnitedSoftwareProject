using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface UsersServices:IGenericServices<Users>
    {
        Users Login(Users p);
        Users WhoUser(string name);
    }
}
