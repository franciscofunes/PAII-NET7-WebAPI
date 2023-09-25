using PAII.GuiaEjercicios.WebApi.Models;
using PAII.GuiaEjercicios.WebApi.Services.Generalidades;

namespace PAII.GuiaEjercicios.WebApi.Tests;

public partial class GeneralidadesServiceTest
{
    public class GeneralidadesServiceTests
    {
        private IGeneralidadesService _generalidadesService;

        public void SetUp()
        {
            // Create an instance of your service to be used in each test.
            _generalidadesService = new GeneralidadesService();
        }

        [Test]
        public void Sumar_ShouldReturnSum()
        {
            // Arrange
            var _generalidadesService = new GeneralidadesService();

            double numero1 = 5;
            double numero2 = 3;

            // Act
            double result = _generalidadesService.Sumar(numero1, numero2);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void CortarCadena_ShouldReturnSubstring()
        {
            // Arrange
            string cadena = "abcdefgh";
            var _generalidadesService = new GeneralidadesService();

            // Act
            string result = _generalidadesService.CortarCadena(cadena);

            // Assert
            Assert.That(result, Is.EqualTo("abcd"));
        }


        [Test]
        public void CortarCadena_ShouldThrowExceptionWhenLengthGreaterThan8()
        {
            // Arrange
            string cadena = "abcdefghi"; // el Lenght de la cadena es mayor a 8 caracteres
            var _generalidadesService = new GeneralidadesService();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => _generalidadesService.CortarCadena(cadena));
        }

        [Test]
        public void ObtenerFechaHoraActual_ShouldReturnCurrentDateTime()
        {
            // Arrange
            DateTime expected = DateTime.Now;
            var _generalidadesService = new GeneralidadesService();

            // Act
            DateTime result = _generalidadesService.ObtenerFechaHoraActual();

            // Assert
            //Esto se hace para tener en cuenta cualquier diferencia leve en los valores de DateTime debido al tiempo que lleva ejecutar la prueba.
            Assert.That(result, Is.EqualTo(expected).Within(TimeSpan.FromSeconds(1)));
        }

        [Test]
        public void ObtenerComentariosCSharp_ShouldReturnComments()
        {
            // Arrange
            var _generalidadesService = new GeneralidadesService();

            // Act
            CommentsTypes result = _generalidadesService.ObtenerComentariosCSharp();

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.ComentarioUnaLinea, Is.EqualTo("// Este es un comentario de una sola línea con //").NoClip);
            Assert.That(result.ComentarioMultilinea, Is.EqualTo("/*\n   Este es un comentario de varias líneas con /*\n   Puede abarcar múltiples líneas.\n*/").NoClip);
        }

    }
}