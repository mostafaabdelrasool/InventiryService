﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Domain.Models;

namespace Inventory.Application.Order.Event
{
    public interface IOrderSavedCommand
    {
        Task NotifyOrderSaved(List<OrderProductDetails> orderDetails);
    }
}