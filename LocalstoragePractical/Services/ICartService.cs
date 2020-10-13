using System;

namespace LocalstoragePractical.Services
{
  public interface ICartService
  {
    Cart Cart { get; set; }

    event EventHandler<CartChangedEventArgs> CartChanged;

    void RaiseCartChanged();
  }
}