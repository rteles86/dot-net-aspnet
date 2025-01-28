using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    
[Route("meus-testes")]
    public class TestesController : Controller
    {
        // GET: TestesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TestesController/Details/5
        [Route("detalhes/{codigo:int}/{nome:alpha?}")]
        public ActionResult Details(int codigo, string nome = "")
        {
            var print = new {Codigo = codigo, Nome = nome};
            return Json(print);
        }

        // GET: TestesController/Create
        [Route("novo-teste")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestesController/Create
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

        // GET: TestesController/Edit/5
        [Route("editar/{id:int}")]
        public ActionResult Edit(int id, string nome, string email)
        {
            var print = new {Id = id, Nome = nome, Email = email};
            return Json(print);
        }

        // POST: TestesController/Edit/5
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

        // GET: TestesController/Delete/5
        [Route("excluir/{id:int}")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestesController/Delete/5
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
