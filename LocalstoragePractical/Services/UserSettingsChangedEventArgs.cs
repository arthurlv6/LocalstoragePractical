using LocalstoragePractical.Services;
using System;

namespace LocalstoragePractical.Services
{
  public class CartChangedEventArgs : EventArgs
  {
    public CartChangedEventArgs(Cart cart)
    {
      Cart = cart;
    }

    public Cart Cart { get; }
  }
}
