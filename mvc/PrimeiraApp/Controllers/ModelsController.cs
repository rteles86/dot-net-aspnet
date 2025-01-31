using System;
using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers;

public class ModelsController: Controller
{
    public IActionResult Index(){

        var aluno = new Aluno{
                Nome = "x",
                Email = "xteles",
                ConfirmacaoEmail = "rteles ok"
                };
        if(TryValidateModel(aluno)){
            return View(aluno);
        }

        var ms = ModelState;

        var errorsModel = ms.Select(x => x.Value.Errors )
                            .Where(y => y.Count > 0)
                            .ToList();

        errorsModel.ForEach(r => Console.WriteLine(r.First().ErrorMessage));

        return View();
    }
}
