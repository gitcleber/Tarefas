using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tarefas.Models;
using Tarefas.Services;

namespace Tarefas.Controllers
{
    public class TarefasController : Controller
    {
        ITarefaItemService _tarefaService;
        public TarefasController(ITarefaItemService tarefaService)
        {
            _tarefaService = tarefaService;
            
        }

        public async Task<IActionResult> Index()
        {
            //obter itens da tarefa
            // TempTarefaItemService servico = new TempTarefaItemService();
            // var tarefas = servico.GetItemAsync();
            
            var tarefas = await _tarefaService.GetItemAsync();

            var model = new TarefaViewModel();
            {
                model.TarefaItems = tarefas;
            }
            return View(model);
        }

        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}