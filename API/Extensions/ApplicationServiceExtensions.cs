namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        /*
         * Métodos de extensión (extension methods) son una característica que permite agregar
         * nuevos métodos a una clase existente sin modificar directamente su código fuente.
         * 
         * Este cambio se realizo debido que es una buena práctica separar el código de nuestro archivo program.cs
         * en bloques y tener un código más legible.
         */
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()    // WithOrigins("url")
                        .AllowAnyMethod()   // WithMethods("GET", "POST")
                        .AllowAnyHeader()); // WithHeaders("accept","content-type")
            });
    }
}
