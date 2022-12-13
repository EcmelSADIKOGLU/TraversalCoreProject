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
    public class DestinationManager : IDestinationService
    {
        IDestinationDAL _destinationDAL;

        public DestinationManager(IDestinationDAL destinationDAL)
        {
            _destinationDAL = destinationDAL;
        }

        public void TDelete(Destination entity)
        {
            _destinationDAL.Delete(entity);
        }

        public List<Destination> TGetList()
        {
            return _destinationDAL.GetList();
        }

        public Destination TGetListByID(int id)
        {
            return _destinationDAL.GetListByID(id);
        }

        public void TInsert(Destination entity)
        {
            _destinationDAL.Insert(entity);
        }

        public void TUpdate(Destination entity)
        {
            _destinationDAL.Update(entity);
        }
    }
}
