﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papaBobs.Persistence
{
    public class PizzaPriceRepository
    {
        public static DTO.PizzaPriceDTO GetPizzaPrices()
        {
            var db = new papaBobsDbEntities();
            var prices = db.PizzaPrices.First();
            var dto = convertToDTO(prices);
            return dto; 
        }

        private static DTO.PizzaPriceDTO convertToDTO(PizzaPrice pizzaPrice)
        {
            var dto = new DTO.PizzaPriceDTO();
            dto.SmallSizeCost = pizzaPrice.SmallSizeCost;
            dto.MediumSizeCost = pizzaPrice.MediumSizeCost;
            dto.LargeSizeCost = pizzaPrice.LargeSizeCost;
            dto.ThickCrustCost = pizzaPrice.ThickCrustCost;
            dto.ThinCrustCost = pizzaPrice.ThinCrustCost;
            dto.RegularCrustCost = pizzaPrice.RegularCrustCost;
            dto.SausageCost = pizzaPrice.SausageCost;
            dto.PepperoniCost = pizzaPrice.PepperoniCost;
            dto.OnionCost = pizzaPrice.OnionCost;
            dto.GreenPepperCost = pizzaPrice.GreenPepperCost;

            return dto; 

            
        }
    }
}
