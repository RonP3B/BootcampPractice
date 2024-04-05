
namespace SportShop.SportStore {
    @Serenity.Decorators.registerClass()
    export class CustomerOrderGrid extends Serenity.EntityGrid<OrderRow, any>
    {
        protected getColumnsKey() { return "SportStore.CustomerOrder"; }
        protected getIdProperty() { return OrderRow.idProperty; }
        protected getLocalTextPrefix() { return OrderRow.localTextPrefix; }
        protected getService() { return OrderService.baseUrl; }
        protected getButtons() { return null; }
        protected getInitialTitle() { return null; }
        protected getGridCanLoad() { return this.customerID != null; }

        private _customerID: number;

        get customerID() { return this._customerID; }

        set customerID(value: number) {
            if (this._customerID != value) {
                this._customerID = value;
                this.setEquality(OrderRow.Fields.CustomerId, value);
                this.refresh();
            }
        }

        constructor(container: JQuery) {
            super(container);
        }
    }
}