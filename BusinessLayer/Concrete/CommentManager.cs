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
    public class CommentManager : ICommentService
    {
        ICommentDAL _commentDAL;

        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public void TDelete(Comment entity)
        {
            _commentDAL.Delete(entity);
        }

        public List<Comment> TGetCommentsByDestination(int id)
        {
            return _commentDAL.GetCommentsByDestination(id);
        }

        public List<Comment> TGetList()
        {
            return _commentDAL.GetList();
        }

        public List<Comment> TGetList(Expression<Func<Comment, bool>> filter)
        {
            return _commentDAL.GetList(filter);
        }

        public Comment TGetListByID(int id)
        {
            return _commentDAL.GetListByID(id);
        }

        public void TInsert(Comment entity)
        {
            _commentDAL.Insert(entity);
        }

        public void TUpdate(Comment entity)
        {
            _commentDAL.Update(entity);
        }
    }
}
