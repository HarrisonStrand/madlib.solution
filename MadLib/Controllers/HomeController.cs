using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult HomePage() { return View();}

    [Route("/fantasy-form")]
    public ActionResult FantasyForm() { return View();}

    [Route("/fantasy")]
    public ActionResult Fantasy(string noun, string species, string adjective, string noun2, string species2, string place, string action, string activity)
    {
      MadLibVariable myFantasyVariable = new MadLibVariable();
      myFantasyVariable.Noun = noun;
      myFantasyVariable.Species = species;
      myFantasyVariable.Adjective = adjective;
      myFantasyVariable.Noun2 = noun2;
      myFantasyVariable.Species2 = species;
      myFantasyVariable.Place = place;
      myFantasyVariable.Action = action;
      myFantasyVariable.Activity = activity;
      return View(myFantasyVariable);
    }
    [Route("/sci-fi-form")]
    public ActionResult ScifiForm() { return View();}

    [Route("/sci-fi")]
    public ActionResult Scifi(string occupation, string verb, string occupation2, string systemofgov, string species)
    {
      MadLibVariable mySciFiVariable = new MadLibVariable();
      mySciFiVariable.Occupation = occupation;
      mySciFiVariable.Verb = verb;
      mySciFiVariable.Occupation2 = occupation2;
      mySciFiVariable.SystemOfGov = systemofgov;
      mySciFiVariable.Species = species;
      return View(mySciFiVariable);
    }
    [Route("/modern-form")]
    public ActionResult ModernForm() { return View();}

    [Route("/modern")]
    public ActionResult Modern(string emotion, string occupation, string place, string country, string activity)
    {
      MadLibVariable myModernVariable = new MadLibVariable();
      myModernVariable.Emotion = emotion;
      myModernVariable.Occupation = occupation;
      myModernVariable.Place = place;
      myModernVariable.Country = country;
      myModernVariable.Activity = activity;
      return View(myModernVariable);
    }
  }
}