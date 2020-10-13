using LocalstoragePractical.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalstoragePractical.Components
{
    public class AddItemBase: ComponentBase
    {
        [Parameter]
        public EventCallback<Item> CloseEventCallback { get; set; }
        public Item ItemVM { get; set; } = new Item() { Quantity=1, Price=12.23 };
        public bool ShowDialog { get; set; }

        public async Task Show()
        {
            ItemVM= new Item() { Quantity = 1, Price = 12.23 };
            ShowDialog = true;
        }
        public void Close()
        {
            ShowDialog = false;
        }
        protected async Task HandleValidSubmit()
        {
                Close();
                await CloseEventCallback.InvokeAsync(ItemVM);
        }
    }
}
