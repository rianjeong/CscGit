using papaBobs.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papaBobs.Domain
{
    public class OrderManager
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            //validation
            if (orderDTO.Name.Trim().Length == 0)
                throw new Exception("name is required");

            if (orderDTO.Address.Trim().Length == 0)
                throw new Exception("Address is required");

            if (orderDTO.Zip.Trim().Length == 0)
                throw new Exception("zip is required");

            if (orderDTO.Phone.Trim().Length == 0)
                throw new Exception("Phone is required");

            orderDTO.OrderId = Guid.NewGuid();
            orderDTO.TotalCost = PizzaPriceManager.CalculateCost(orderDTO); 
            Persistence.OrderRepository.CreateOrder(orderDTO); 
        }

        public static void CompleteOrder(Guid orderId)
        {
            Persistence.OrderRepository.completeOrder(orderId); 


        }

        public static object GetOrders()
        {
            return Persistence.OrderRepository.GetOrders();
        }
    }
}
