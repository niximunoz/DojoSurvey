using Microsoft.AspNetCore.Mvc;
namespace DojoSurveyController.Controllers;
public class DojoSurveyController : Controller
{

    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }
    [HttpGet("result/{firstName}")]
    public IActionResult Result(string firstName, string location,  string language, string comments)
    {
        ViewBag.FirstName = firstName;
        ViewBag.Location = location;
        ViewBag.Language = language;
        ViewBag.Comments = comments;
        return View("result");
    }
    [HttpPost("result")]
    public RedirectToActionResult MostrarDatos(string firstName, string location, string language, string comments){
        return RedirectToAction("Result",new {firstName = firstName , location = location, language = language, comments = comments});
    }
}