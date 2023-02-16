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
    public class AboutManager : AboutServices
    {

        IAboutDal _about;

        public AboutManager(IAboutDal about)
        {
            _about = about;
        }

        public void add(About x)
        {
            _about.add(x);
        }

        public About getById(int id)
        {
            return _about.getById(id);
        }

        public List<About> Listele()
        {
            return _about.Listele();
        }

        public void remove(About y)
        {
            _about.remove(y);
        }

        public About Status()
        {
            return _about.Status();
        }

        public void update(About p)
        {
            _about.update(p);
        }
    }
}
