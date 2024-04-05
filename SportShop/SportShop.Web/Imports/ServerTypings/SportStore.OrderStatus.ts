namespace SportShop.SportStore {
    export enum OrderStatus {
        Shipped = 1,
        NotShipped = 2,
        ShippedLate = 3,
        DelayedShipment = 4
    }
    Serenity.Decorators.registerEnumType(OrderStatus, 'SportShop.SportStore.OrderStatus', 'SportStore.OrderStatus');
}

