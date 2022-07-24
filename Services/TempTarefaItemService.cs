using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarefas.Models;

namespace Tarefas.Services
{
  public class TempTarefaItemService : ITarefaItemService
  {
    public Task<IEnumerable<TarefaItem>> GetItemAsync()
    {
      //Retorna uma array de items de tarfa
      IEnumerable<TarefaItem> items = new[]
      {
        new TarefaItem
        {
            Nome = "Aprendendo ASP.NET Core 2.2",
            EstaCompleta = false,
            DataConclusao = DateTimeOffset.Now.AddDays(30)
        },
        new TarefaItem
        {
            Nome = "Criar aplicações Web",
            EstaCompleta = false,
            DataConclusao = DateTimeOffset.Now.AddDays(60)
        }
      };
      return Task.FromResult(items);

    }
  }
}