using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.GenericRepository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfUserDal : GenericRepository<Users>, IUserDal
    {
        Context baglan = new Context();
        public Users Login(Users p)
        {
            return baglan.UserDbSet.FirstOrDefault(x=>x.UserName==p.UserName && x.Password==p.Password);
        }
    }
}
