using FirstMVCApp.Models;
using FirstMVCApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class CodeSnippetsController : Controller
    {
        private readonly CodeSnippetsRepository _repository;
        private readonly MembersRepository _membersRepository;

        public CodeSnippetsController(CodeSnippetsRepository repository, MembersRepository membersRepository)
        {
            _repository = repository;
            _membersRepository = membersRepository;
        }

        // GET: CodeSnippets
        public ActionResult Index()
        {
            var codeSnippets = _repository.GetAll();
            return View("Index", codeSnippets);
        }

        // GET: CodeSnippets/Details/5
        public ActionResult Details(Guid id)
        {
            var codeSnippet = _repository.GetById(id);
            return View("Details", codeSnippet);
        }

        // GET: CodeSnippets/Create
        public ActionResult Create()
        {
            var members = _membersRepository.GetMembers();
            ViewBag.data = members;
            return View("Create");
        }

        // POST: CodeSnippets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            var model = new CodeSnippetModel();
            TryUpdateModelAsync(model);
            _repository.Add(model);

            return RedirectToAction("Index");
        }

        // GET: CodeSnippets/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View("Edit", _repository.GetById(id));
        }

        // POST: CodeSnippets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, IFormCollection collection)
        {
            var model = new CodeSnippetModel();
            TryUpdateModelAsync(model);
            _repository.Update(model);
            return RedirectToAction("Index");
        }

        // GET: CodeSnippets/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View("Delete", _repository.GetById(id));
        }

        // POST: CodeSnippets/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            _repository.DeleteById(id);
            return RedirectToAction("Index");
        }
    }
}
