using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentListForBlog : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDAL());
        public IViewComponentResult Invoke()
        {
            var values = commentManager.TGetCommentsByDestination(ViewBag.DestinationID);
            ViewBag.Count = values.Count;
            return View(values);
        }
    }
}
