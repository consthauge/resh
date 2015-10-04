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
    }
}