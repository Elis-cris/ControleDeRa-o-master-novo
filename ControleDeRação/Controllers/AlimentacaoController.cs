using Microsoft.AspNetCore.Mvc;

namespace ControleDeRacao.Controllers
{

        public IActionResult Agenda()
        {
            return View();
        }

        [HttpPost]

        public IActionResult SalvarAgenda(string matutino, string vespertino, string noturno)
        {

            // Lógica para salvar a agenda (Horários 07:00, 13:00, 19:00, etc.)

            return RedirectToAction("Agenda");

        }
    }
}
