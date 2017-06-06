using Nancy;
using System.Collections.Generic;


namespace WordCounter.Project
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["WordCounter.cshtml"];

      Post["WordCounter"] = _ =>
      {
        WordCounter newWordCounter = new WordCounter(Request.Form["word"], Request.Form["sentence"]);
        return View["/WordCounter_Result", newWordCounter];
      };
    }
  }
}
