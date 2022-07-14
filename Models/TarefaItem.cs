using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarefas.Models
{
  public class TarefaItem
  {
    public System.Guid Id { get; set; }
    public bool EstaCompleta { get; set; }
    public string Nome { get; set; }
    public DateTimeOffset? DataConclusao { get; set; }

  }
}