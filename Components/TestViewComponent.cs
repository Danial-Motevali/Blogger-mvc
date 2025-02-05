using Microsoft.AspNetCore.Mvc;

namespace Blogger_mvc.Components
{
    public class TestViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int number)
        {
            List<string> toDo = new List<string>();
            if (number == 1)
            {
                toDo.Add("No1");
                toDo.Add("No#1");
                toDo.Add("No@1");
                toDo.Add("No!1");
            }
            else
            {
                toDo.Add("No2");
                toDo.Add("No#2");
                toDo.Add("No@2");
                toDo.Add("No!2");
            }

            return View(toDo);
        }
    }
}
