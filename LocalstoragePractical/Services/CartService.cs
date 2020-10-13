using System;
using System.Collections.Generic;

namespace LocalstoragePractical.Services
{
    public class CartService : ICartService
    {
        public event EventHandler<CartChangedEventArgs> CartChanged;

        public Cart Cart { get; set; } = new Cart
        {
            Items = new List<Item>()
             {
                 new Item { Name="123",Price=12.2,Quantity=1 },
                 new Item { Name="34",Price=12.2,Quantity=1 },
                 new Item { Name="255",Price=12.2,Quantity=1 }
             }
        };

        public void RaiseCartChanged()
        {
            CartChanged?.Invoke(this, new CartChangedEventArgs(Cart));
        }
        
    }
}
