using System;
using Nancy;

namespace Triangles
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["form.html", new Triangle(0, 0, 0)];
      };
      Get["/triangle"] = _ => {
        int Side1 = 0;
        int.TryParse(Request.Query["Side1"], out Side1);
        int Side2 = 0;
        int.TryParse(Request.Query["Side2"], out Side2);
        int Side3 = 0;
        int.TryParse(Request.Query["Side3"], out Side3);

        Triangle triangle = new Triangle(Side1, Side2, Side3);
        if (Side1 == 0 || Side2 == 0 || Side3 == 0 || !triangle.IsTriangle())
        {
          return View["form.html", triangle];
        }
        else{
          return View["result.html", triangle];
        }
      };
    }
  }
}
