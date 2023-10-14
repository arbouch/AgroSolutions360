using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
 
public static class SwaggerConfiguration
{
    public static void ConfigureSwagger(this IServiceCollection services)
    {
        // Add Swagger services
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });
        });
    }
}
