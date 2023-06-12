# Objetivo del proyecto

El objetivo de este proyecto es desarrollar un software de tipo API Web en .NET Core 6 y C#. Se llevará a cabo siguiendo buenas prácticas de programación, los principios SOLID y se implementará el patrón de arquitectura N Capas.

# Descripción de capas del proyecto:

- **API:**
    - Esta capa es responsable de recibir las solicitudes HTTP y enviar las respuestas correspondientes. Aquí es donde implementarías los controladores de API, las rutas y la lógica de manejo de solicitudes y respuestas.

- **Aplication:**
    - Esta capa actúa como un intermediario entre la capa de presentación/API y la capa de dominio. Contiene la lógica de negocio y coordina las interacciones entre diferentes objetos de dominio. Aquí puedes implementar servicios, mapeadores, validaciones y otras reglas de negocio.

- **Domain:**
    - Esta capa representa los conceptos del dominio de tu aplicación y encapsula la lógica de negocio central. Aquí definirías las entidades, los repositorios de datos y los contratos de interfaz para la persistencia de datos.

- **DataAccess:**
    - Los modelos y el contexto de Entity Framework Core suelen ubicarse en la capa de acceso a datos, también conocida como capa de persistencia o capa de repositorio. Esta capa es responsable de interactuar con el almacenamiento de datos y proporcionar una abstracción entre la capa de dominio y el sistema de persistencia.

# Aplicación de principios SOLID
- **S (Single responsibility principle - Principio de responsabilidad única)**
    - Una clase, componente o micro servicio debe ser responsable de una sola cosa, es decir, que esté desacoplada del resto de las funcionalidades.
    - **Justificación**: En este proyecto este principio se justifica dividiendo las entidades de la base de datos y los modelos del sistema. Estos ultimos siendo representaciónes de las entidades donde podremos aplicar lógica de negocio. Adenás, creamos las clases servicios, que contendrán operaciones de la base de datos, librando de esta responsabilidad a los controladores y los modelos.
- **O (Open/closed principle - Principio de abierto/cerrado)**
    - Este principio establece que las entidades, clases, modulos, funcionalidad, deben estar abiertos para su extensión pero cerrados para su modificación.
    - **Justificación**: Aún no se ha aplicado este principio en el código.
- **L (Liskov substitution principle - Principio de sustitución de Liskov)**
    - Cada clase que hereda de otra clase, puede usarse como su padre sin conocer la diferencia entre ellas.
    - **Justificación**: Aún no se ha aplicado este principio en el código.
- **I (Interface segregation principle - Principio de segregación de la interfaz)**
    - Este principio establece que los clientes no deberían verse forzados a depender de interfaces que no usan. Dicho de otra manera, cuando un cliente implementa una interfaz cuya funcionalidad no usa este cliente pero otros sí usan, este cliente se verá afectado por cambios que realicen en la interfaz.
    - **Justificación**: En este proyecto se aplica este principio creando una interfaz única para cada servicio y sus funciones.
- **D (Dependency inversion principle - Principio de inversión de la dependencia)**
    - Este principio establece que las dependencias deben estar en las abstracciónes, es decir, los módulos de alto nivel no deberian depender de los de bajo nivel, ambos deberian depender de abstracciones.
    - **Justificación**: En este proyecto se aplica este principio cuando la inyección de dependencias se hace a mediante la interfaz que implementa los métodos a uno o más servicios, así en caso de que se requiera cambiar el servicio no afectará la implementación de este, sino que solo se tendrá que modificar su comportamiento, ya que la clase que la implemente dependerá de la abstracción y no del servicio como tal.
