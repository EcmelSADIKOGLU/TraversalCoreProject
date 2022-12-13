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
    public class NewsletterManager : INewsletterService
    {
        INewsletterDAL _newsletterDAL;

        public NewsletterManager(INewsletterDAL newsletterDAL)
        {
            _newsletterDAL = newsletterDAL;
        }

        public void TDelete(Newsletter entity)
        {
            _newsletterDAL.Delete(entity);
        }

        public List<Newsletter> TGetList()
        {
            return _newsletterDAL.GetList();
        }

        public List<Newsletter> TGetList(Expression<Func<Newsletter, bool>> filter)
        {
            return _newsletterDAL.GetList(filter);
        }

        public Newsletter TGetListByID(int id)
        {
            return _newsletterDAL.GetListByID(id);
        }

        public void TInsert(Newsletter entity)
        {
            _newsletterDAL.Insert(entity);
        }

        public void TUpdate(Newsletter entity)
        {
            _newsletterDAL.Update(entity);
        }
    }
}
