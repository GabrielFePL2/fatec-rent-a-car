using Fatec.Rent.API.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Fatec.Rent.API.Data.Context
{
    public class DapperDbContext : IDbContext
    {
        private readonly string connectionString;
        public DapperDbContext(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("FatecRentDb");
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}