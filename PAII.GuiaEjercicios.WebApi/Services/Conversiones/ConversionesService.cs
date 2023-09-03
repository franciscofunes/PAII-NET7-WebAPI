using System.Text;
using PAII.GuiaEjercicios.WebApi.Enums;
using PAII.GuiaEjercicios.WebApi.Models;
namespace PAII.GuiaEjercicios.WebApi.Services;


public class ConversionesService : IConversionesService
{
    public ConversionResult RealizarConversiones(bool valor)
    {
        // Inicializar variables para almacenar resultados de conversión y explicaciones
        bool resultadoConvertir, resultadoParsear, resultadoTryParsear;
        string explicacionConvertir, explicacionParsear, explicacionTryParsear;

        try
        {
            // Convertir el valor booleano a string
            string valorString = valor.ToString();

            // Usar Convert.ToBoolean
            resultadoConvertir = Convert.ToBoolean(valorString);
            explicacionConvertir = "Convertir.ToBoolean convierte un valor a booleano. El resultado es: " + resultadoConvertir;

            // Usar bool.Parse
            resultadoParsear = bool.Parse(valorString);
            explicacionParsear = "bool.Parse convierte un valor a booleano. El resultado es: " + resultadoParsear;

            // Usar bool.TryParse
            if (bool.TryParse(valorString, out resultadoTryParsear))
            {
                explicacionTryParsear = "bool.TryParse convierte un valor a booleano. El resultado es: " + resultadoTryParsear;
            }
            else
            {
                explicacionTryParsear = "bool.TryParse no pudo convertir el valor a booleano.";
            }
        }
        catch (Exception ex)
        {
            // Manejar cualquier excepción que pueda ocurrir durante la conversión
            resultadoConvertir = resultadoParsear = resultadoTryParsear = false;
            explicacionConvertir = explicacionParsear = explicacionTryParsear = "Error en la conversión: " + ex.Message;
        }

        // Crear un objeto ConversionResult para almacenar los resultados y explicaciones
        var resultadosConversion = new ConversionResult
        {
            ResultadoConvertir = resultadoConvertir,
            ExplicacionConvertir = explicacionConvertir,
            ResultadoParsear = resultadoParsear,
            ExplicacionParsear = explicacionParsear,
            ResultadoTryParsear = resultadoTryParsear,
            ExplicacionTryParsear = explicacionTryParsear
        };

        return resultadosConversion;
    }


    public IEnumerable<ExplicacionCasteo> ExplicarCasteos()
    {
        var explicaciones = new List<ExplicacionCasteo>();

        // Escenario a)
        try
        {
            // int resultadoA = (int)344.4;

            explicaciones.Add(new ExplicacionCasteo
            {
                Escenario = "a) int resultadoA = (int)344.4;",
                Explicacion = "En el escenario a), se intenta convertir un número decimal (344.4) a un entero (int). La parte decimal se trunca y se obtiene el valor 344 como resultado."
            });
        }
        catch (Exception ex)
        {
            explicaciones.Add(new ExplicacionCasteo
            {
                Escenario = "a) int resultadoA = (int)344.4;",
                Explicacion = "En el escenario a), se produce una excepción durante la conversión: " + ex.Message
            });
        }

        // Escenario b)
        // decimal b = 10;

        explicaciones.Add(new ExplicacionCasteo
        {
            Escenario = "b) decimal b = 10;",
            Explicacion = "En el escenario b), se asigna un valor entero (10) a una variable decimal (b). No hay pérdida de información en esta conversión."
        });

        // Escenario c)
        // int valorC = 443444;
        // short c = (short)valorC;

        explicaciones.Add(new ExplicacionCasteo
        {
            Escenario = "c) int valorC = 443444; short c = (short)valorC;",
            Explicacion = "En el escenario c), se asigna un valor entero (443444) a una variable entera corta (short c). Si el valor excede el rango de un corto, se producirá un desbordamiento y se puede perder información."
        });

        return explicaciones;
    }

    public string ObtenerMensajeColor(Colores color)
    {
        string mensaje;

        switch (color)
        {
            case Colores.Blanco:
                mensaje = "El color es Blanco.";
                break;

            case Colores.Azul:
                mensaje = "El color es Azul.";
                break;

            case Colores.Negro:
                mensaje = "El color es Negro.";
                break;

            default:
                mensaje = "Color no reconocido.";
                break;
        }

        return mensaje;
    }

    public string EvaluarVariableA(int a)
    {
        if (a > 10)
        {
            return "El valor es mayor que 10.";
        }
        else
        {
            return "El valor no es mayor que 10. (Mensaje de error)";
        }
    }

    public string ExplicarDiferenciaForForeach()
    {
        Dictionary<string, string> explicaciones = new Dictionary<string, string>
            {
                {
                    "for",
                    "La sentencia 'for' se utiliza para recorrer una colección o matriz mediante un índice numérico. Es útil cuando necesitas acceder a elementos en función de su posición en la colección."
                },
                {
                    "foreach",
                    "La sentencia 'foreach' se utiliza para recorrer una colección o matriz de forma secuencial, sin necesidad de un índice numérico. Es especialmente útil cuando solo necesitas acceder a los elementos sin preocuparte por los índices."
                }
            };

        Dictionary<string, string> ejemplos = new Dictionary<string, string>
            {
                {
                    "for",
                    "for (int i = 0; i < coleccion.Length; i++)\n{\n    Console.WriteLine(coleccion[i]);\n}"
                },
                {
                    "foreach",
                    "foreach (var elemento in coleccion)\n{\n    Console.WriteLine(elemento);\n}"
                }
            };

        StringBuilder mensaje = new StringBuilder();

        foreach (var tipo in explicaciones.Keys)
        {
            mensaje.AppendLine(explicaciones[tipo]);
            mensaje.AppendLine();
            mensaje.AppendLine($"Ejemplo de '{tipo}':");
            mensaje.AppendLine("```csharp");
            mensaje.AppendLine(ejemplos[tipo]);
            mensaje.AppendLine("```");
            mensaje.AppendLine();
        }

        mensaje.AppendLine("En resumen, 'for' se utiliza cuando necesitas un control más preciso sobre la iteración y el acceso a elementos, mientras que 'foreach' es más conveniente cuando solo necesitas recorrer todos los elementos de una colección.");

        return mensaje.ToString();
    }

    public int IncrementarVariable(int valorInicial)
    {
        const int ValorMaximo = 50;
        const int Incremento = 5;

        int resultado = valorInicial;

        while (resultado < ValorMaximo)
        {
            resultado += Incremento;
        }

        return resultado;
    }
}


