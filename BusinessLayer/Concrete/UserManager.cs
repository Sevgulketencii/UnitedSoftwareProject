using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : UsersServices
    {
        IUserDal _user;

        public UserManager(IUserDal user)
        {
            _user = user;
        }

        public void add(Users x)
        {
            _user.add(x);
        }

        public Users getById(int id)
        {
            return _user.getById(id);
        }

        public List<Users> Listele()
        {
            return _user.Listele();
        }

        public Users Login(Users p)
        {
            return _user.Login(p);
        }

        public void remove(Users y)
        {
            _user.remove(y);
        }

        public void update(Users p)
        {
            _user.update(p);
        }

        public Users WhoUser(string name)
        {
            return _user.whoUser(name);
        }
    }
}
