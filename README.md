# Universidad Tecnológica de Panamá

# Facultad de Ingeniería de Sistemas Computacionales

## Laboratorio #2 - Programación Orientada a Objetos

### Herramientas de Programación Aplicada III 

## Fecha de Ejecución:

1 de septiembre de 2026

---

## Objetivos

- Comprender la estructura básica de una aplicación de consola desarrollada en C#.

- Identificar el método `Main` como el punto de entrada principal de una aplicación de consola.

- Crear clases en archivos separados aplicando la nomenclatura correspondiente en C#.

- Crear objetos a partir de clases utilizando el operador `new`.

- Implementar métodos públicos para definir acciones que pueden realizar los objetos.

- Utilizar métodos con y sin parámetros.

- Comprender la diferencia entre parámetros y argumentos al realizar llamadas a métodos.

- Aplicar variables de instancia para almacenar información propia de cada objeto.

- Utilizar los modificadores de acceso `public` y `private`.

- Implementar propiedades utilizando los descriptores de acceso `get` y `set`.

- Comprender el concepto de encapsulamiento para proteger los datos internos de una clase.

---

## Introducción

La Programación Orientada a Objetos permite organizar un programa mediante clases y objetos. Una clase funciona como una estructura que define los datos y comportamientos que posteriormente pueden utilizar los objetos creados a partir de ella.

Durante el Laboratorio #2 se desarrollaron tres programas de consola utilizando la clase `LibroCalificaciones`.

En el primer programa se creó una clase que contiene un método encargado de mostrar un mensaje de bienvenida. En el segundo programa se modificó el método para recibir el nombre de un curso mediante un parámetro. Finalmente, en el tercer programa se implementó una variable de instancia privada y una propiedad con `get` y `set`, permitiendo almacenar y modificar el nombre del curso de manera controlada.

Estas actividades permitieron introducir conceptos fundamentales de Programación Orientada a Objetos en C#, como clases, objetos, métodos, parámetros, propiedades, encapsulamiento y modificadores de acceso.

---

## Requisitos Previos

Para desarrollar y ejecutar este laboratorio se requiere contar con el siguiente entorno:

### Tecnologías utilizadas

- **Lenguaje de programación:** C#
- **Framework:** .NET
- **Tipo de aplicación:** Aplicación de Consola
- **Entorno de desarrollo:** Visual Studio Community 2026
- **Control de versiones:** Git
- **Repositorio:** GitHub

### Sistema Operativo

- Windows 10 / Windows 11

---

## Contenido del Repositorio

Este repositorio contiene las tres actividades desarrolladas durante el Laboratorio #2 de Herramientas de Programación Aplicada III.

Las aplicaciones incluidas son:

1. **Actividad #1 - Clase y Método:** creación de una clase `LibroCalificacion` y utilización del método `MostrarMensaje()`.

2. **Actividad #2 - Método con Parámetro:** modificación del método `MostrarMensaje` para recibir el nombre de un curso.

3. **Actividad #3 - Variables de Instancia y Propiedades:** implementación de una variable privada, propiedad `NombreCurso`, descriptores `get` y `set` y creación de diferentes objetos de la clase.

---

# Problema #1 - Clase LibroCalificacion y Método MostrarMensaje

## Descripción

La primera actividad consiste en crear una aplicación de consola que utiliza una clase llamada `LibroCalificacion`.

Dentro de esta clase se creó un método público llamado:

```csharp
MostrarMensaje()
```

El método tiene como función mostrar en la consola un mensaje de bienvenida al libro de calificaciones.

Posteriormente, desde el método `Main`, se crea un objeto de la clase utilizando:

```csharp
LibroCalificacion MyLibro = new LibroCalificacion();
```

Luego se utiliza el objeto para llamar al método:

```csharp
MyLibro.MostrarMensaje();
```

---

### Elementos de C# utilizados

- Clase `LibroCalificacion`
- Método `Main`
- Método `MostrarMensaje()`
- Modificador de acceso `public`
- Palabra reservada `void`
- Operador `new`
- Creación de objetos
- Operador punto `.`
- `Console.WriteLine()`

---

### Funcionamiento

Cuando inicia el programa se crea un objeto de la clase:

```csharp
LibroCalificacion MyLibro = new LibroCalificacion();
```

Posteriormente se llama al método:

```csharp
MyLibro.MostrarMensaje();
```

El resultado mostrado en consola es:

```text
Bienvenido al libro de calificaciones
```

Esta actividad permite observar cómo una clase puede contener métodos y cómo es necesario crear un objeto para utilizar las operaciones definidas dentro de ella.

---

## Resultado - Problema #1

A continuación se muestra la ejecución correspondiente al primer programa:

<img width="333" height="172" alt="image" src="https://github.com/user-attachments/assets/28a524bb-b911-4d3d-986b-c29cacf61b23" />


---

# Problema #2 - Método con Parámetro

## Descripción

En la segunda actividad se modificó la clase utilizada anteriormente para permitir que el método `MostrarMensaje` reciba información.

El método fue definido de la siguiente manera:

```csharp
public void MostrarMensaje(string nombreCurso)
```

El parámetro:

```csharp
string nombreCurso
```

permite que el método reciba el nombre de un curso y posteriormente lo utilice dentro del mensaje mostrado en la consola.

Desde el método `Main`, el programa solicita al usuario ingresar el nombre del curso mediante:

```csharp
Console.ReadLine();
```

La información ingresada se almacena en la variable:

```csharp
string nombreDelCurso
```

Finalmente, el contenido de esta variable se envía al método utilizando:

```csharp
MyLibro.MostrarMensaje(nombreDelCurso);
```

---

## Elementos de C# utilizados

En este problema se utilizaron:

- Clase `MiLibroCalificaciones`
- Método `Main`
- Método con parámetro
- Tipo de dato `string`
- Parámetros
- Argumentos
- `Console.WriteLine()`
- `Console.ReadLine()`
- Marcador de posición `{0}`
- Salto de línea `\n`
- Creación de objetos mediante `new`
- Operador punto `.`

---

## Marcador de posición

En esta actividad se utilizó:

```text
{0}
```

como marcador de posición dentro de `Console.WriteLine`.

El marcador `{0}` se reemplaza con el primer valor indicado después del texto.

Por ejemplo:

```csharp
Console.WriteLine(
    "¡Bienvenido al libro de calificaciones para: \n{0} !",
    nombreCurso
);
```

El contenido almacenado en `nombreCurso` reemplaza automáticamente a `{0}`.

---

## Ejemplo de funcionamiento

El programa solicita:

```text
Por favor ingrese el nombre del curso:
```

El usuario puede escribir:

```text
Herramientas de Programación Aplicada III
```

El valor ingresado se almacena en:

```csharp
nombreDelCurso
```

y posteriormente se envía como argumento al método:

```csharp
MyLibro.MostrarMensaje(nombreDelCurso);
```

La salida será similar a:

```text
¡Bienvenido al libro de calificaciones para:
Herramientas de Programación Aplicada III !
```

---

## Resultado - Problema #2

A continuación se muestra la ejecución correspondiente al segundo programa:

<img width="336" height="113" alt="image" src="https://github.com/user-attachments/assets/25ec0a02-36c0-4cd3-88a7-d3524918de91" />


---

# Problema #3 - Variables de Instancia y Propiedades

## Descripción

En la tercera actividad se modificó nuevamente la clase `LibroCalificaciones` para permitir que cada objeto pueda almacenar su propio nombre de curso.

Para esto se creó una variable de instancia privada:

```csharp
private string nombreCurso;
```

Esta variable almacena el nombre correspondiente a cada objeto de la clase.

Debido a que la variable fue declarada como `private`, no puede ser modificada directamente desde otras clases.

Para permitir el acceso controlado al valor se creó la propiedad:

```csharp
public string NombreCurso
```

La propiedad contiene los descriptores:

```csharp
get
```

y:

```csharp
set
```

---

## Variable de Instancia

La variable utilizada fue:

```csharp
private string nombreCurso;
```

Esta variable pertenece a cada objeto creado a partir de la clase.

Por lo tanto, diferentes objetos pueden almacenar diferentes nombres de curso.

---

## Propiedad NombreCurso

Para manipular la variable privada se utilizó la siguiente propiedad:

```csharp
public string NombreCurso
{
    get
    {
        return nombreCurso;
    }

    set
    {
        nombreCurso = value;
    }
}
```

El descriptor:

```csharp
get
```

permite obtener el contenido de `nombreCurso`.

El descriptor:

```csharp
set
```

permite asignar un nuevo valor a la variable de instancia.

---

## Constructor

En esta actividad también se utiliza un constructor para asignar un nombre al curso en el momento de crear el objeto.

```csharp
public LibroCalificaciones(string nombre)
{
    nombreCurso = nombre;
}
```

Esto permite crear objetos indicando directamente el nombre del curso.

Por ejemplo:

```csharp
LibroCalificaciones myLibro =
    new LibroCalificaciones("CS101 Programación en C#");
```

y:

```csharp
LibroCalificaciones myLibro2 =
    new LibroCalificaciones("CS102 Estructuras de Datos");
```

Cada objeto mantiene su propio valor de `nombreCurso`.

---

## Elementos de C# utilizados

Durante este ejercicio se aplicaron:

- Clase `LibroCalificaciones`
- Objetos
- Variables de instancia
- Modificador `private`
- Modificador `public`
- Encapsulamiento
- Propiedades
- Descriptor `get`
- Descriptor `set`
- Palabra reservada `value`
- Constructor
- Operador `new`
- Método `Main`
- `Console.WriteLine()`
- `Console.ReadLine()`
- Marcadores de posición `{0}`

---

## Ejemplo de funcionamiento

Inicialmente se crean dos objetos:

```csharp
LibroCalificaciones myLibro =
    new LibroCalificaciones("CS101 Programación en C#");

LibroCalificaciones myLibro2 =
    new LibroCalificaciones("CS102 Estructuras de Datos");
```

Cada uno almacena un nombre de curso diferente.

El programa puede acceder a los nombres utilizando:

```csharp
myLibro.NombreCurso
```

y:

```csharp
myLibro2.NombreCurso
```

La salida inicial será similar a:

```text
El nombre del curso es: CS101 Programación en C#
El nombre del curso es: CS102 Estructuras de Datos
```

Posteriormente el programa solicita ingresar un nuevo nombre de curso:

```text
Escriba el nombre del curso:
```

El usuario puede introducir:

```text
Herramientas de Programación Aplicada III
```

Este valor se almacena utilizando la propiedad:

```csharp
myLibro.NombreCurso = elNombreCurso;
```

Luego el programa muestra el nuevo valor:

```text
El nombre del curso es: Herramientas de Programación Aplicada III
```

---

## Resultado - Problema #3

A continuación se muestra la ejecución correspondiente al tercer programa:

<img width="389" height="131" alt="image" src="https://github.com/user-attachments/assets/feded5b6-6447-4216-95c8-12c7de8180f7" />


---

# Resultados Obtenidos

Al finalizar el laboratorio se logró desarrollar correctamente tres aplicaciones de consola enfocadas en los fundamentos de Programación Orientada a Objetos en C#.

Mediante las actividades realizadas se pudo implementar:

- Creación de clases.
- Creación de objetos.
- Uso del operador `new`.
- Llamadas a métodos mediante objetos.
- Métodos con y sin parámetros.
- Uso de parámetros y argumentos.
- Entrada de datos mediante `Console.ReadLine()`.
- Salida de información mediante `Console.WriteLine()`.
- Uso de marcadores de posición.
- Variables de instancia.
- Modificadores de acceso `public` y `private`.
- Encapsulamiento de información.
- Propiedades.
- Descriptores `get` y `set`.
- Uso de la palabra reservada `value`.
- Creación y utilización de constructores.
- Almacenamiento independiente de información en diferentes objetos de una misma clase.

---

# Dificultades y Soluciones

Durante el desarrollo del laboratorio se presentaron algunos conceptos nuevos que requirieron especial atención.

### Creación de una clase separada

En las actividades fue necesario crear un nuevo archivo de clase dentro del proyecto y posteriormente utilizar esa clase desde `Program.cs`.

La clase se agregó desde el Explorador de Soluciones utilizando:

```text
Agregar > Nuevo elemento > Clase
```

Posteriormente se creó un objeto de dicha clase dentro del método `Main`.

---

### Métodos con parámetros

En la segunda actividad fue necesario modificar el método para que pudiera recibir información.

Se utilizó:

```csharp
public void MostrarMensaje(string nombreCurso)
```

El dato ingresado por el usuario se guardó en una variable y posteriormente se envió como argumento:

```csharp
MyLibro.MostrarMensaje(nombreDelCurso);
```

Esto permitió utilizar dentro del método el nombre de curso introducido durante la ejecución.

---

### Acceso a una variable privada

En la tercera actividad la variable:

```csharp
private string nombreCurso;
```

no podía ser accedida directamente desde otras clases debido al modificador `private`.

Para solucionar esto se utilizó la propiedad:

```csharp
NombreCurso
```

con los descriptores:

```csharp
get
```

y:

```csharp
set
```

Esto permitió obtener y modificar el valor de la variable de manera controlada.

---

### Diferentes valores en objetos de una misma clase

Al crear los objetos:

```csharp
myLibro
```

y:

```csharp
myLibro2
```

cada uno conserva su propia copia de la variable de instancia `nombreCurso`.

Esto permite que dos objetos creados a partir de la misma clase tengan información diferente sin afectar el contenido del otro.

---

# Referencias

Material utilizado para el desarrollo del laboratorio:

- Guía del Laboratorio #2 - Clases en C# - Herramientas de Programación Aplicada III.
- Material proporcionado por la Ing. Irina Fong.

---

# Información del Estudiante

**Nombre:** Maria Townshend
**Curso:** Herramientas de Programación Aplicada III
**Institución:** Universidad Tecnológica de Panamá  
**Facultad:** Facultad de Ingeniería de Sistemas Computacionales  
**Instructor:** Ing. Irina Fong  
