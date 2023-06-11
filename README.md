# Objetivo del proyecto

El objetivo de este proyecto es desarrollar un software de tipo API Web en .NET Core 6 y C#. Se llevará a cabo siguiendo buenas prácticas de programación, los principios SOLID y se implementará el patrón de arquitectura N Capas.

## Descripción de capas del proyecto:

- **API:**
    - Esta capa es responsable de recibir las solicitudes HTTP y enviar las respuestas correspondientes. Aquí es donde implementarías los controladores de API, las rutas y la lógica de manejo de solicitudes y respuestas.

- **Aplication:**
    - Esta capa actúa como un intermediario entre la capa de presentación/API y la capa de dominio. Contiene la lógica de negocio y coordina las interacciones entre diferentes objetos de dominio. Aquí puedes implementar servicios, mapeadores, validaciones y otras reglas de negocio.

- **Domain:**
    - Esta capa representa los conceptos del dominio de tu aplicación y encapsula la lógica de negocio central. Aquí definirías las entidades, los repositorios de datos y los contratos de interfaz para la persistencia de datos.

- **DataAccess:**
    - Los modelos y el contexto de Entity Framework Core suelen ubicarse en la capa de acceso a datos, también conocida como capa de persistencia o capa de repositorio. Esta capa es responsable de interactuar con el almacenamiento de datos y proporcionar una abstracción entre la capa de dominio y el sistema de persistencia.
