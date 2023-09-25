# 🎓 Universidad de la Matanza

<img src="https://www.freecodecamp.org/news/content/images/2022/12/main-image.png" alt="Curso" width="300">

### 🎓 Licenciatura en Tecnología

**Asignatura:** Programación Avanzada II

---
## 📜 Descripción

Este repositorio será utilizado para subir todas las asignaciones del curso "Programación Avanzada II" en la Universidad de la Matanza. Todos los recursos estarán en español.

## 📝 Instrucciones

**Introducción** - De acuerdo con las indicaciones de la wiki para la puesta en marcha del ambiente, se debe realizar lo siguiente:

**Fecha de Entrega:** 28 de agosto de 2023, 23:59

1. Crear un proyecto .NET multiplataforma vacío.
2. Subir el proyecto a un repositorio público propio.
3. Compartir el enlace al repositorio en la entrega de esta tarea.

El proyecto puede ser de tipo consola, Web API o Web MVC.

---
**TP Nº1** - Introducción a C#:

**Fecha de Entrega:** 4 de Septiembre de 2023, 23:59

**Aclaraciones:** La resolución del ejercicio se encuentra en la siguiente branch `feature/TP-N1-introduccion-csharp`

### Generalidades

1. Crear una función que devuelva la suma de dos números recibidos por parámetros.
2. Crear una función que reciba una cadena de 8 caracteres y retorne en el mismo parámetro la cadena cortada de izquierda a derecha en 4 caracteres.
3. Crear una función que devuelva la fecha y hora actual.
4. Escribir un comentario con `//`.
5. Escribir un comentario con `/*   */`.

### Enumeraciones

1. Crear una enumeración con los días de la semana, comenzando por Domingo con valor 1.
2. Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana.

### Conversiones

1. Realizar la conversión de true, false, 1 y 0 utilizando los métodos `Convert.`, `bool.Parse` y `bool.TryParse`. Explique cómo responde en cada caso cada uno de los métodos indicados.
2. Explique que sucede en los siguientes intentos de casteos de datos.
   a) `int a = (int)344.4;`
   b) `decimal a = 10;`
   c) `int a=443444; short b = (short)a;`

3. Escriba una sentencia `switch` utilizando una enumeración con 3 colores (blanco, azul y negro) y para cada caso indicar un mensaje de cual es el color informado.
4. Si se tiene una variable entera `a`, realice una sentencia `if` para evaluar si la variable `a` es mayor a 10. Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10.
5. Al ejercicio del punto 4), agregar la sentencia `else` y, en ella, indicar un mensaje de error.
6. ¿Cuál es la diferencia entre la sentencia `for` y `foreach`? ¿Cuándo se debe utilizar cada una de ellas?
7. Defina una variable `a` que en cada ciclo de una sentencia `while` incremente su valor en 5. Cuando la variable `a` exceda el valor de 50, el ciclo `while` debe finalizar.

El proyecto puede ser de tipo consola, Web API o Web MVC.

## 👥 Integrantes

- Juan Ignacio Aschura
- Francisco Ignacio Funes
- Juan Sebastián Campos

## 🚀 Ejecutar la Aplicación Web API

**Para ejecutar la aplicación Web API, sigue estos pasos:**

1. Ejecuta el siguiente comando para navegar a la rama de git correspondiente a cada entrega, por ejemplo:

   ```shell
      git checkout feature/TP-N1-introduccion-csharp
   ```

2. Abre una terminal o PowerShell en la carpeta del proyecto "PAII.GuiaEjercicios.WebApi".

3. Ejecuta el siguiente comando para iniciar la aplicación:

   ```shell
      dotnet run
   ```

4. Navega a la url `http://localhost:5294/swagger` en un navegador para ejectutar cada uno de los endpoints

## 🚀 Ejecutar Tests de la Aplicacion web api

**Para ejecutar los tests de la aplicación Web API, sigue estos pasos:**

1. posicionate en el pryecto "PAII.GuiaEjercicios.WebApi.Tests".

2. Ejecuta el siguiente comando para ejectutar los tests de la aplicación:

   ```shell
      dotnet test
   ```

---
## 💻 Comandos del Dotnet CLI que se utilzaron para crear la estructura del proyecto:

- ```shell
      dotnet new sln --name PAII.GuiaEjercicios
  ```

-  ```shell
      dotnet new webapi -n PAII.GuiaEjercicios.WebApi --output PAII.GuiaEjercicios.WebApi
   ```
-  ```shell
      dotnet new nunit -n PAII.GuiaEjercicios.WebApi.Tests –output PAII.GuiaEjercicios.WebApi.Tests --framework net7.0
   ```

-  ```shell 
      dotnet add PAII.GuiaEjercicios.WebApi.Tests reference PAII.GuiaEjercicios.WebApi
   ```

---
**Despues de crear todos los proyectos abrir powershell y correr este comando:**

-  ```shell 
      dotnet sln add (ls -r **/*.csproj)
   ```
---
**Volver a la consola del VSC y ejecutar estos comandos:**
-  ```shell 
      dotnet restore
   ```

-  ```shell
      dotnet build PAII.GuiaEjercicios.sln
   ```
