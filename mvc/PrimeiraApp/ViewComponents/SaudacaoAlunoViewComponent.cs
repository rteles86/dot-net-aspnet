using System;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Models;

namespace PrimeiraApp.ViewComponents;

public class SaudacaoAlunoViewComponent : ViewComponent
{

    public async Task<IViewComponentResult> InvokeAsync(string nome, int id)
    {
        //Aqui poderia chamar um serviço ou dados de um DB
        var aluno = new Aluno() { Nome = nome, Id = id };
        return View(aluno);
    }
}