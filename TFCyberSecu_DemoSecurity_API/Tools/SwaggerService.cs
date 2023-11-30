using Microsoft.OpenApi.Models;

namespace TFCyberSecu_DemoSecurity_API.Tools
{
    public static class SwaggerService
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "API CrowdFunding",
                    Version = "v1",
                    Description = "Cette API permet de connecter des gens ensemble pour concrétiser de beaux projets !",
                });

                // Ajoute la définition de sécurité pour JWT (Bearer token)
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme",
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                });

                // Ajoute l'exigence de sécurité pour JWT
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        Array.Empty<string>()
                    }
                });
            });
        }
    }
}
