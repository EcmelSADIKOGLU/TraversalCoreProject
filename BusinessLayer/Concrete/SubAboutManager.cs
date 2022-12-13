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
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDAL _subAboutDAL;

        public SubAboutManager(ISubAboutDAL subAboutDAL)
        {
            _subAboutDAL = subAboutDAL;
        }

        public void TDelete(SubAbout entity)
        {
            _subAboutDAL.Delete(entity);
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutDAL.GetList();
        }

        public SubAbout TGetListByID(int id)
        {
            return _subAboutDAL.GetListByID(id);
        }

        public void TInsert(SubAbout entity)
        {
            _subAboutDAL.Insert(entity);
        }

        public void TUpdate(SubAbout entity)
        {
            _subAboutDAL.Update(entity);
        }
    }
}
