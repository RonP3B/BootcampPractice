
namespace SportShop.SportStore
{
    using Serenity.ComponentModel;
    using System.ComponentModel;

    [EnumKey("SportStore.OrderStatus")]
    public enum OrderStatus
    {
        [Description("Shipped")]
        Shipped = 1,
        [Description("Not Shipped")]
        NotShipped = 2,
        [Description("Shipped Late")]
        ShippedLate = 3,
        [Description("Delayed Shipment")]
        DelayedShipment = 4
    }
}
