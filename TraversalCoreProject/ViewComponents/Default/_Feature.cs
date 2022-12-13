using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDAL());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            ViewBag.v1 = values[0];
            ViewBag.v2 = values[1];
            ViewBag.v3 = values[2];
            ViewBag.v4 = values[3];
            ViewBag.v5 = values[4];
            return View();
        }
    }
}
