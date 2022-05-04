using BusinessLogic.Logic;
using Core.Interfaces;

namespace WebApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration) {
            services.AddTransient<IProductoRepository, ProductoRepository>();
            return services;
        }
    }
}
