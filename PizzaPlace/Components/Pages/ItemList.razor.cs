using Microsoft.AspNetCore.Components;

namespace PizzaPlace.Components.Pages
{
    public partial class ItemList<TItem>
    {
        [Parameter]
        public RenderFragment? Header { get; set; }

        [Parameter]
        public RenderFragment? Footer { get; set; }
        [Parameter]
        public RenderFragment<TItem> RowTemplate { get; set; } = default!;
        [Parameter]
        public IEnumerable<TItem> Items { get; set; } = default!;
    }
}
