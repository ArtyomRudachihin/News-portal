using Microsoft.AspNetCore.Mvc;

namespace News_portal
{
    public class NewsController : Controller
    {
        // GET: /News/Index
        public IActionResult Index()
        {
            // Ваш код для получения списка новостей из базы данных
            return View();
        }
        public IActionResult Index1()
        {
            // Ваш код для получения списка новостей из базы данных
            return View();
        }
        public IActionResult Dalee()
        {
            // Ваш код для получения списка новостей из базы данных
            return View();
        }

        // GET: /News/Edit/1
        public IActionResult Edit(int id)
        {
            // Ваш код для получения данных конкретной новости по её id
            return View();
        }

        // POST: /News/Edit/1
        [HttpPost]
        public IActionResult Edit(int id, NewsViewModel model)
        {
            // Ваш код для сохранения отредактированной новости в базе данных
            return RedirectToAction("Index");
        }

        // GET: /News/Delete/1
        public IActionResult Delete(int id)
        {
            // Ваш код для удаления новости из базы данных
            return RedirectToAction("Index");
        }
    }
    public class HomeController : Controller
    {
        public ActionResult Index1()
        {
            return View();
        }
    }
}