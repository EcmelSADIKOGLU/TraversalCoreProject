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
    public class About2Manager : IAbout2Service
    {
        IAbout2DAL _about2DAL;

        public About2Manager(IAbout2DAL about2DAL)
        {
            _about2DAL = about2DAL;
        }

        public void TDelete(About2 entity)
        {
            _about2DAL.Delete(entity);
        }

        public List<About2> TGetList()
        {
            return _about2DAL.GetList();
        }

        public About2 TGetListByID(int id)
        {
            return _about2DAL.GetListByID(id);
        }

        public void TInsert(About2 entity)
        {
            _about2DAL.Insert(entity);
        }

        public void TUpdate(About2 entity)
        {
            _about2DAL.Update(entity);
        }
    }
}
