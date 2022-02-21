using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using PI_ATV04_Bruno_Mello.Models;

namespace PI_ATV04_Bruno_Mello.Controllers
{
    
     public class UsuarioController : Controller
    {
        
        public IActionResult Login()
        {
            return View();
        }
              
    [HttpPost]
        public IActionResult Login(Usuario u)
        {

            UsuarioRepository ur = new UsuarioRepository();
            Usuario userEncontrado = ur.ValidarLogin(u);

            if (userEncontrado == null)
            {
                ViewBag.Mensagem = "Falha no login ";
                return View();
            }
            else
            {
                HttpContext.Session.SetInt32("IdUsuario", userEncontrado.Id);
                HttpContext.Session.SetString("Nome", userEncontrado.Nome);
                
                return RedirectToAction("Listagem", "Orcamento");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();//Limpa todos os dados registrados da sessão e redireciona 
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Excluir(int Id)
        {
            UsuarioRepository ur = new UsuarioRepository();
            Usuario userEncontrado = ur.BuscarPorId(Id);
            ur.Excluir(userEncontrado);
            return RedirectToAction("Listagem", "Usuario");//action, controllerreturn RedirectToAction()

        }
      
        public IActionResult Editar(int Id){
            UsuarioRepository ur = new UsuarioRepository();//busca no banco 
            Usuario userEncontrado =ur.BuscarPorId(Id);
            return View(userEncontrado);
        }


        [HttpPost]
        public IActionResult Editar(Usuario u){
            UsuarioRepository ur = new UsuarioRepository();
            ur.Editar(u);
            return RedirectToAction("Listagem", "Usuario");//action, controller
        }

   
        public IActionResult Cadastro(){
            //return RedirectToAction("Cadastro", "Usuario");
            return View();
        }
        
        //ação (requisição)
        [HttpPost]
        public IActionResult Cadastro(Usuario u){
            UsuarioRepository ur = new UsuarioRepository();

            ur.Cadastrar(u);

            return RedirectToAction("Listagem", "Usuario");//action, controller
        }

        public IActionResult Listagem(){

            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> Lista = ur.Listar();
            return View(Lista);
        }
    }
}