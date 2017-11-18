using System.Threading.Tasks;
using System.Data;

namespace Tgd.Persistance.MsSql
{
    public interface IDbConnectionFactory
    {
        Task<IDbConnection> GetConnectionAsync();
    }
}