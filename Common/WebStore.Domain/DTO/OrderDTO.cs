using System;
using System.Collections.Generic;
using WebStore.ViewModels;

namespace WebStore.Domain.DTO
{
    /// <summary>
    /// Инфо о заказе
    /// </summary>
    public class OrderDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        /// <summary>
        /// Дата заказа
        /// </summary>
        public DateTime Date { get; set; }
        public IEnumerable<OrderItemDTO> Items { get; set; }
    }
    /// <summary>
    /// Пункт заказа
    /// </summary>
    public class OrderItemDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    /// <summary>
    /// Модель процесса создания заказа
    /// </summary>
    public class CreateOrderModel
    {
        public OrderViewModel Order { get; set; }

        public IList<OrderItemDTO> Items { get; set; }
    }
}