using Data;
using System.IO;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class ReshController : Controller
    {
        private readonly IReshRepository _reshRepository;

        public ReshController(IReshRepository reshRepository)
        {
            _reshRepository = reshRepository;
        }

        public ActionResult Get(int id)
        {
            var reshUnit = _reshRepository.Get(id);
            return Json(reshUnit, JsonRequestBehavior.AllowGet);
        }

        #region helpers
        public string RenderViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
        #endregion

        //public ActionResult Get(int id)
        //{
        //    var reshUnit = _reshRepository.Get(id);
        //    return Json(reshUnit, JsonRequestBehavior.AllowGet);
        //}
    }
}