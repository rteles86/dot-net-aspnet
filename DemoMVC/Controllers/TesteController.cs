using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("meu-teste")]
    public class TesteController : Controller
    {
        // GET: TesteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TesteController/Details/5
        [Route("detalhes/{id:int}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TesteController/Create
        [Route("novo")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: TesteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TesteController/Edit/5
        [Route("editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TesteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TesteController/Delete/5
        [Route("excluir/{id:int}")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TesteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
