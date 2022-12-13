using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCommentDAL : GenericRepository<Comment>, ICommentDAL
    {
        public List<Comment> GetCommentsByDestination(int id)
        {
            using(Context c = new Context())
            {
               var values = c.Comments.Where(x=>x.DestinationID== id).ToList();
               return values;
            }
            
        }
    }
}
