using Dapper;
using Fatec.Rent.API.Domain;
using Fatec.Rent.API.Interfaces;

namespace Fatec.Rent.API.Data.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly IDbContext db;

        public VehicleRepository(IDbContext db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<Vehicle>> GetAll()
        {
            using (var connection = db.GetConnection())
            {
                return await connection.QueryAsync<Vehicle>("SELECT * FROM Vehicle;");
            }
        }
    }
}