using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList().OrderByDescending(x=>x.DestinationID).Take(8).ToList();
            return View(values);
        }
    }
}
