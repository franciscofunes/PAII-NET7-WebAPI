using PAII.GuiaEjercicios.WebApi.Enums;
using PAII.GuiaEjercicios.WebApi.Services;

namespace PAII.GuiaEjercicios.WebApi.Tests;

public partial class ConversionesServiceTest
{
    [TestFixture]
    public class ConversionesServiceTests
    {
        private IConversionesService _conversionesService;

        [SetUp]
        public void SetUp()
        {
            // Create an instance of your service to be used in each test.
            _conversionesService = new ConversionesService();
        }

        [Test]
        public void RealizarConversiones_ShouldConvertValues()
        {
            // Arrange
            bool valor = true;

            // Act
            var resultado = _conversionesService.RealizarConversiones(valor);

            // Assert
            // Verifica que los resultados sean los esperados
            Assert.That(resultado.ResultadoConvertir, Is.True);
            Assert.That(resultado.ResultadoParsear, Is.True);
            Assert.That(resultado.ResultadoTryParsear, Is.True);
            Assert.That(resultado.ExplicacionConvertir, Does.Contain("Convertir.ToBoolean convierte un valor a booleano."));
            Assert.That(resultado.ExplicacionParsear, Does.Contain("bool.Parse convierte un valor a booleano."));
            Assert.That(resultado.ExplicacionTryParsear, Does.Contain("bool.TryParse convierte un valor a booleano."));
        }

        [Test]
        public void ObtenerMensajeColor_ShouldReturnCorrectMessage()
        {
            // Arrange
            Colores colorBlanco = Colores.Blanco;
            Colores colorAzul = Colores.Azul;
            Colores colorNegro = Colores.Negro;
            Colores colorDesconocido = (Colores)42; // Valor desconocido

            // Act
            string mensajeBlanco = _conversionesService.ObtenerMensajeColor(colorBlanco);
            string mensajeAzul = _conversionesService.ObtenerMensajeColor(colorAzul);
            string mensajeNegro = _conversionesService.ObtenerMensajeColor(colorNegro);
            string mensajeDesconocido = _conversionesService.ObtenerMensajeColor(colorDesconocido);

            // Assert
            // Verifica que los mensajes sean los esperados para los colores conocidos
            Assert.That(mensajeBlanco, Is.EqualTo("El color es Blanco."));
            Assert.That(mensajeAzul, Is.EqualTo("El color es Azul."));
            Assert.That(mensajeNegro, Is.EqualTo("El color es Negro."));

            // Verifica que el mensaje para un color desconocido sea el esperado
            Assert.That(mensajeDesconocido, Is.EqualTo("Color no reconocido."));
        }

        [Test]
        public void EvaluarVariableA_ShouldReturnCorrectMessage()
        {
            // Arrange
            int valorMayorQue10 = 15;
            int valorMenorOIgualA10 = 10;
            int valorNegativo = -5;

            // Act
            string mensajeMayorQue10 = _conversionesService.EvaluarVariableA(valorMayorQue10);
            string mensajeMenorOIgualA10 = _conversionesService.EvaluarVariableA(valorMenorOIgualA10);
            string mensajeNegativo = _conversionesService.EvaluarVariableA(valorNegativo);

            // Assert
            // Verifica que los mensajes sean los esperados para diferentes valores de 'a'
            Assert.That(mensajeMayorQue10, Is.EqualTo("El valor es mayor que 10."));
            Assert.That(mensajeMenorOIgualA10, Is.EqualTo("El valor no es mayor que 10. (Mensaje de error)"));
            Assert.That(mensajeNegativo, Is.EqualTo("El valor no es mayor que 10. (Mensaje de error)"));
        }

        [Test]
        public void IncrementarVariable_ShouldReturnCorrectResult()
        {
            // Arrange
            int valorMenorQue50 = 40;
            int valorIgualA50 = 50;
            int valorMayorQue50 = 60;

            // Act
            int resultadoMenorQue50 = _conversionesService.IncrementarVariable(valorMenorQue50);
            int resultadoIgualA50 = _conversionesService.IncrementarVariable(valorIgualA50);
            int resultadoMayorQue50 = _conversionesService.IncrementarVariable(valorMayorQue50);

            // Assert
            // Verifica que los resultados sean los esperados para diferentes valores iniciales
            Assert.That(resultadoMenorQue50, Is.EqualTo(50));
            Assert.That(resultadoIgualA50, Is.EqualTo(50));
            Assert.That(resultadoMayorQue50, Is.EqualTo(60)); // Ya que el valor inicial es mayor que 50, no debe cambiar.
        }
    }
}