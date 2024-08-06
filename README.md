# Proyecto Blackjack en C# con Principios SOLID

Este proyecto implementa un juego de Blackjack sencillo en C#, diseñado siguiendo los principios SOLID para asegurar que el código sea fácil de mantener y extender.

## Descripción del Juego

El juego permite a un usuario jugar Blackjack contra "la casa". El usuario puede continuar sacando cartas hasta que decida detenerse o se pase de 21, lo cual resulta en una pérdida automática. Si el jugador se detiene sin pasarse de 21, entonces la casa intentará alcanzar o superar un total de 17. Si la casa se pasa de 21, el jugador gana. Si no, se comparan los totales para determinar el ganador.

## Principios SOLID Aplicados

### Single Responsibility Principle (SRP)

- **`Generar_Cartas`**: Esta clase tiene la única responsabilidad de manejar la generación de valores de cartas. No participa en ninguna otra lógica de juego como la evaluación de las manos o la interacción con el usuario.
- **`Juegos`**: Gestiona la lógica del flujo del juego, determinando cuándo y cómo se juegan las manos y evaluando el resultado del juego.

### Open/Closed Principle (OCP)

- **Extensibilidad**: El juego puede ser fácilmente extendido con nuevas funcionalidades sin modificar el código existente. Por ejemplo, se podrían añadir nuevas variantes del juego o nuevas reglas para las cartas como bonificaciones o penalizaciones.

### Liskov Substitution Principle (LSP)

- Todas las clases se mantienen de forma que puedan ser extendidas y sus objetos sustituidos sin alterar el comportamiento correcto del programa. Por ejemplo, si se crea una subclase de `Generar_Cartas` que genere cartas de una manera diferente (como incluir jokers o reglas especiales), el juego debería poder funcionar sin cambios en la lógica de control.

### Interface Segregation Principle (ISP)

- **Interfaces simples**: Aunque en el ejemplo dado no se utilizan interfaces explícitas, el diseño está preparado para que se puedan introducir interfaces que separen grandes bloques de funcionalidad (como la interfaz para la gestión de entrada/salida y la lógica de juego), asegurando que los componentes solo dependan de las interfaces que utilizan.

### Dependency Inversion Principle (DIP)

- **`Generar_Cartas`** y **`Juegos`** están diseñados para ser dependientes de abstracciones (aunque en este ejemplo, las abstracciones no estén explícitamente definidas como interfaces o clases abstractas), no de detalles concretos, lo que facilita la prueba y la extensión del código.

## Cómo Usar

Para ejecutar el juego, simplemente compila el proyecto en un entorno .NET capaz de ejecutar aplicaciones de consola y ejecuta el archivo binario resultante. Las instrucciones para jugar se proporcionarán en la consola, y puedes interactuar con el juego mediante la entrada estándar.

## Requisitos

- .NET SDK
- Un IDE que soporte C# (como Visual Studio, VSCode con la extensión C# o Rider)

## Contribuciones

Las contribuciones son bienvenidas. Por favor, asegúrate de realizar tests unitarios para cualquier nueva funcionalidad o corrección que desees aportar.
