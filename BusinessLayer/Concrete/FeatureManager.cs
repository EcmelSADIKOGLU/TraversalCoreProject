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
    public class FeatureManager : IFeatureService
    {
        IFeatureDAL _featureDAL;

        public FeatureManager(IFeatureDAL featureDAL)
        {
            _featureDAL = featureDAL;
        }

        public void TDelete(Feature entity)
        {
            _featureDAL.Delete(entity);
        }

        public List<Feature> TGetList()
        {
            return _featureDAL.GetList();
        }

        public List<Feature> TGetList(Expression<Func<Feature, bool>> filter)
        {
            return _featureDAL.GetList(filter);
        }

        public Feature TGetListByID(int id)
        {
            return _featureDAL.GetListByID(id);
        }

        public void TInsert(Feature entity)
        {
            _featureDAL.Insert(entity);
        }

        public void TUpdate(Feature entity)
        {
            _featureDAL.Update(entity);
        }
    }
}
