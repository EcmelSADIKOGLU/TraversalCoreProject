using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDAL _guideDAL;

        public GuideManager(IGuideDAL guideDAL)
        {
            _guideDAL = guideDAL;
        }

        public void TDelete(Guide entity)
        {
            _guideDAL.Delete(entity);
        }

        public List<Guide> TGetList()
        {
            return _guideDAL.GetList();
        }

        public List<Guide> TGetList(Expression<Func<Guide, bool>> filter)
        {
            return _guideDAL.GetList(filter);
        }

        public Guide TGetListByID(int id)
        {
            return _guideDAL.GetListByID(id);
        }

        public void TInsert(Guide entity)
        {
            _guideDAL.Insert(entity);
        }

        public void TUpdate(Guide entity)
        {
            _guideDAL.Update(entity);
        }
    }
}
