using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<Entity> where Entity : class
    {
        void Insert(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);
        List<Entity> GetList();
        List<Entity> GetList(Expression<Func<Entity,bool>> filter);
        Entity GetListByID(int id);
    }
}
