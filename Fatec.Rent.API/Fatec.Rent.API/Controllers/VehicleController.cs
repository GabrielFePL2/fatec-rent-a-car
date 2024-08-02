using Fatec.Rent.API.Domain;
using Fatec.Rent.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fatec.Rent.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> logger;
        private readonly IVehicleRepository vehicleRepository;

        public VehicleController(ILogger<VehicleController> logger, IVehicleRepository repository)
        {
            this.logger = logger;
            this.vehicleRepository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Vehicle>> Get()
        {
            logger.LogInformation("Get executado com sucesso.");
            return await vehicleRepository.GetAll();
        }
    }
}