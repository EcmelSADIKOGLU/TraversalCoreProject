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
    public class ContactManager : IContactService
    {
        IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public void TDelete(Contact entity)
        {
            _contactDAL.Delete(entity);
        }

        public List<Contact> TGetList()
        {
            return _contactDAL.GetList();
        }

        public Contact TGetListByID(int id)
        {
            return _contactDAL.GetListByID(id);
        }

        public void TInsert(Contact entity)
        {
            _contactDAL.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactDAL.Update(entity);
        }
    }
}
