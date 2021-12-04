using car4.kz.Data.Interfaces;
using car4.kz.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car4.kz.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void creatOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDBContent.order.Add(order);

            var items = shopCart.listShopItems;

            foreach(var el in items)
            {
                var OrderDetail = new OrderDetail()
                {
                    CarID = el.car.id,
                    orderID = order.id,
                    price = el.car.price
                };
                appDBContent.OrderDetail.Add(OrderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
