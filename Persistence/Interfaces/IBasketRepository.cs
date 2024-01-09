using rwwo.webapi.redis.Models;

namespace rwwo.webapi.redis.Persistence.Interfaces
{
    public interface IBasketRepository
    {
        Task<UserBasket> GetBasketAsync(string basketId);
        Task<UserBasket> UpdateOrCreateBasketAsync(UserBasket basket);
        Task<bool> DeleteBasketAsync(string basketId);
    }
}
