using System.ComponentModel.DataAnnotations.Schema;

namespace TarefasApiMinimal.Data;

[Table("Tarefas")]
public record Tarefa(int Id, string Atividade, string Status);

