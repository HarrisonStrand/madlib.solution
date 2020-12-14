using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View();}

    [Route("/story")]
    public ActionResult Story(string noun, string species, string adjective, string noun2, string species2, string place, string action, string activity)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Noun = noun;
      myMadLibVariable.Species = species;
      myMadLibVariable.Adjective = adjective;
      myMadLibVariable.Noun2 = noun2;
      myMadLibVariable.Species2 = species;
      myMadLibVariable.Place = place;
      myMadLibVariable.Action = action;
      myMadLibVariable.Activity = activity;
      return View(myMadLibVariable);
    }
  }
}