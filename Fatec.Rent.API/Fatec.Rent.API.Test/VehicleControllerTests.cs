using Fatec.Rent.API.Controllers;
using Fatec.Rent.API.Domain;
using Fatec.Rent.API.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace Fatec.Rent.API.Test
{
    public class VehicleControllerTests
    {
        VehicleController subject;
        Mock<IVehicleRepository> repository;
        public VehicleControllerTests()
        {
            // ARRANGE (Prepara��o)
            this.repository = new Mock<IVehicleRepository>();
            this.subject = new VehicleController(
                Mock.Of<ILogger<VehicleController>>(),
                repository.Object);
        }
        [Fact]
        public async Task Get_Returns_A_List_Of_Vehicles()
        {
            // ACT (A��o)
            var vehicles = await subject.Get();

            // ASSERT (Valida��o)
            Assert.IsAssignableFrom<IEnumerable<Vehicle>>(vehicles);
        }

        [Fact]
        public async Task Get_Returns_A_List_Of_Vehicles_From_Repository()
        {
            // ARRANGE (Prepara��o)
            var esperado = new List<Vehicle>();
            repository.Setup(r => r.GetAll()).ReturnsAsync(esperado);

            // ACT (A��o)
            var vehicles = await subject.Get();

            // ASSERT (Valida��o)
            Assert.Same(esperado.AsEnumerable(), vehicles);
        }
    }
}