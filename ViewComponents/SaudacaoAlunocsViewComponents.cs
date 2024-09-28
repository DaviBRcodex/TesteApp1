using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Models;

namespace PrimeiraApp.ViewComponents
{
    public class SaudacaoAlunocsViewComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //Pegar o aluno lá na base de dados!!! 
            //Pegar o dado (nome) do aluno quew está logado!
            var aluno = new Aluno() { Nome = "Eduardo" };

            return View(aluno);
        }
    }
}
