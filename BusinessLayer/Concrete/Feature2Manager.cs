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
    public class Feature2Manager : IFeature2Service
    {
        IFeature2DAL _feature2DAL;

        public Feature2Manager(IFeature2DAL feature2DAL)
        {
            _feature2DAL = feature2DAL;
        }

        public void TDelete(Feature2 entity)
        {
            _feature2DAL.Delete(entity);
        }

        public List<Feature2> TGetList()
        {
            return _feature2DAL.GetList();
        }

        public List<Feature2> TGetList(Expression<Func<Feature2, bool>> filter)
        {
            return _feature2DAL.GetList(filter);
        }

        public Feature2 TGetListByID(int id)
        {
            return _feature2DAL.GetListByID(id);
        }

        public void TInsert(Feature2 entity)
        {
            _feature2DAL.Insert(entity);
        }

        public void TUpdate(Feature2 entity)
        {
            _feature2DAL.Update(entity);
        }
    }
}
