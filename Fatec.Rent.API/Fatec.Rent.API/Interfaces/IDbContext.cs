using System.Data;

namespace Fatec.Rent.API.Interfaces
{
    public interface IDbContext
    {
        IDbConnection GetConnection();
    }
}