using Fatec.Rent.API.Domain;

namespace Fatec.Rent.API.Interfaces
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetAll();
    }
}