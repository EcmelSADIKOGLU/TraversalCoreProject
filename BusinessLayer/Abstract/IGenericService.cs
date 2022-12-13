
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<Entity> where Entity : class
    {
        void TInsert(Entity entity);
        void TUpdate(Entity entity);
        void TDelete(Entity entity);
        List<Entity> TGetList();
        List<Entity> TGetList(Expression<Func<Entity, bool>> filter);
        Entity TGetListByID(int id);

    }
}
