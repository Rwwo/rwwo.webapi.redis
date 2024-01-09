using Microsoft.EntityFrameworkCore;
using rwwo.webapi.redis.Data;
using rwwo.webapi.redis.Persistence.Interfaces;
using rwwo.webapi.redis.Persistence.Repository;
using StackExchange.Redis;
using System.Runtime.CompilerServices;

namespace rwwo.webapi.redis
{
    public static class InfraModule
    {
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IBasketRepository, BasketRepository>();

            // redis connection config 
            builder.Services.AddSingleton<IConnectionMultiplexer>(opt =>
            {
                var redisUrl = builder.Configuration.GetConnectionString("Redis");
                return ConnectionMultiplexer.Connect(redisUrl);
            });

            builder.Services.AddDbContext<StoreContext>(options =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
        }

    }
}
