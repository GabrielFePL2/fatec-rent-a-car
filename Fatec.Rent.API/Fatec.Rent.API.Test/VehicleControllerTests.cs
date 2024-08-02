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
            // ARRANGE (Preparação)
            this.repository = new Mock<IVehicleRepository>();
            this.subject = new VehicleController(
                Mock.Of<ILogger<VehicleController>>(),
                repository.Object);
        }
        [Fact]
        public async Task Get_Returns_A_List_Of_Vehicles()
        {
            // ACT (Ação)
            var vehicles = await subject.Get();

            // ASSERT (Validação)
            Assert.IsAssignableFrom<IEnumerable<Vehicle>>(vehicles);
        }

        [Fact]
        public async Task Get_Returns_A_List_Of_Vehicles_From_Repository()
        {
            // ARRANGE (Preparação)
            var esperado = new List<Vehicle>();
            repository.Setup(r => r.GetAll()).ReturnsAsync(esperado);

            // ACT (Ação)
            var vehicles = await subject.Get();

            // ASSERT (Validação)
            Assert.Same(esperado.AsEnumerable(), vehicles);
        }
    }
}