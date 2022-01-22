using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PI_ATV04_Bruno_Mello.Models;

namespace PI_ATV04_Bruno_Mello.Controllers
{
    
     public class OrcamentoController : Controller
    
    {
               
     
        public IActionResult Excluir(int IdOrcamento){
            OrcamentoRepository or = new  OrcamentoRepository();
            Orcamento orcEncontrado = or.BuscarPorId(IdOrcamento);
            or.Excluir(orcEncontrado);
            return RedirectToAction("Listagem", "Orcamento");
        }
      

     
        public IActionResult Editar(int IdOrcamento){
            OrcamentoRepository or = new OrcamentoRepository();
            Orcamento orcEncontrado = or.BuscarPorId(IdOrcamento);
            return View(orcEncontrado);
        }


        [HttpPost]
        public IActionResult Editar(Orcamento o){
            OrcamentoRepository or = new OrcamentoRepository();
            or.Editar(o);
            return RedirectToAction("Listagem", "Orcamento");

        }

        public IActionResult Cadastro(){
            
            return View();
        }
        
        
        [HttpPost]
        public IActionResult Cadastrar(Orcamento o){
            OrcamentoRepository or = new OrcamentoRepository();

            or.Cadastrar(o);

            return RedirectToAction("Listagem", "Orcamento");//action, controller
        }

        public IActionResult Listagem(){

            OrcamentoRepository or = new OrcamentoRepository();
            List<Orcamento> Lista = or.Listar();
            return View(Lista);
        }
    }
}