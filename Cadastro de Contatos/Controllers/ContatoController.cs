﻿using Microsoft.AspNetCore.Mvc;

namespace Cadastro_de_Contatos.Controllers {
    public class ContatoController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult Criar() {
            return View();
        }

        public IActionResult Editar() {
            return View();
        }

        public IActionResult ApagarConfirmacao() {
            return View();
        }
    }
}
