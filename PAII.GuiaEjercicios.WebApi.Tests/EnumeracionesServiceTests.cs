using PAII.GuiaEjercicios.WebApi.Services.Enumeraciones;

namespace PAII.GuiaEjercicios.WebApi.Tests;

public partial class EnumeracionessServiceTest
{
    [TestFixture]
    public class EnumeracionesServiceTests
    {
        private IEnumeracionesService _enumeracionesService;

        [SetUp]
        public void SetUp()
        {
            // Create an instance of your service to be used in each test.
            _enumeracionesService = new EnumeracionesService();
        }

        [Test]
        public void ObtenerDiasSemana_DebeDevolverDiasConTexto()
        {
            // Act
            IEnumerable<string> diasConTexto = _enumeracionesService.ObtenerDiasSemana();

            // Assert
            // Puedes afirmar los valores esperados para cada día de la semana aquí.
            List<string> diasList = diasConTexto.ToList(); // Convertir a lista para acceder a la propiedad Count.

            Assert.That(diasList, Is.Not.Empty); // Asegura que la colección no esté vacía.
            Assert.That(diasList.Count, Is.EqualTo(7)); // Asegura que haya 7 días.

            // Ejemplos de afirmaciones para días específicos (personaliza estos valores en función de tus valores de enumeración).
            Assert.That(diasList, Contains.Item("Domingo"));
            Assert.That(diasList, Contains.Item("Lunes"));
            Assert.That(diasList, Contains.Item("Martes"));
            // Agrega afirmaciones similares para los otros días.
        }
    }
}