using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.DTO;
using WebStore.Infrastructure.Interfaces;
using WebStore.Interfaces;


namespace WebStore.ServiceHosting.Controllers
{
    /// <summary>
    /// Упрравление заказами
    /// </summary>
    [Route(WebAPI.Orders)]
    [ApiController]
    public class OrdersApiController : ControllerBase, IOrderService
    {
        private readonly IOrderService _OrderService;

        public OrdersApiController(IOrderService OrderService) => _OrderService = OrderService;

        /// <summary>
        /// Получение всех заказов пользователя
        /// </summary>
        /// <param name="UserName">Имя юзера</param>
        /// <returns>Перечень заказов</returns>
        [HttpGet("user/{UserName}")]
        public async Task<IEnumerable<OrderDTO>> GetUserOrders(string UserName) =>
            await _OrderService.GetUserOrders(UserName);
        /// <summary>
        /// Получение заказа по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<OrderDTO> GetOrderById(int id) => await _OrderService.GetOrderById(id);

        /// <summary>
        /// Создание нового заказа
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="OrderModel"></param>
        /// <returns></returns>
        [HttpPost("{UserName}")]
        public async Task<OrderDTO> CreateOrder(string UserName, [FromBody] CreateOrderModel OrderModel) =>
            await _OrderService.CreateOrder(UserName, OrderModel);
    }
}