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
    public class AboutManager : IAboutService
    {
        IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void TDelete(About entity)
        {
            _aboutDAL.Delete(entity);
        }

        public List<About> TGetList()
        {
            return _aboutDAL.GetList();
        }

        public About TGetListByID(int id)
        {
            return _aboutDAL.GetListByID(id);
        }

        public void TInsert(About entity)
        {
            _aboutDAL.Insert(entity);
        }

        public void TUpdate(About entity)
        {
            _aboutDAL.Update(entity);
        }
    }
}
