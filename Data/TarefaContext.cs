using System.Data;

namespace TarefasApiMinimal.Data;

public class TarefaContext
{
    public delegate Task<IDbConnection> GetConnection();
}
