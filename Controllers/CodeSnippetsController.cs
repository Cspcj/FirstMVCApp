﻿using FirstMVCApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class CodeSnippetsController : Controller
    {
        private readonly CodeSnippetsRepository _repository;

        public CodeSnippetsController(CodeSnippetsRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
