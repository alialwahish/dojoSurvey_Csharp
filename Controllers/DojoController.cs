using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey{

    public class DojoController: Controller{
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Display(string name,string dojo_location, string favorite_location, string comment){
            ViewBag.name=name;
            ViewBag.dojo_location=dojo_location;
            ViewBag.favorite_location=favorite_location;
            ViewBag.comment=comment;
            return View("Display");
        }
    }

}