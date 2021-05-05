using WebStore.Domain.Entities;


namespace WebStore.Infrastructure.Interfaces
{
    public interface ICartStore
    {
        Cart Cart { get; set; }
    }
}
