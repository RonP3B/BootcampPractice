
namespace SportShop.SportStore {
    @Serenity.Decorators.registerClass()
    export class CustomerDialog extends Serenity.EntityDialog<CustomerRow, any> {
        protected getFormKey() { return CustomerForm.formKey; }
        protected getIdProperty() { return CustomerRow.idProperty; }
        protected getLocalTextPrefix() { return CustomerRow.localTextPrefix; }
        protected getNameProperty() { return CustomerRow.nameProperty; }
        protected getService() { return CustomerService.baseUrl; }
        protected getDeletePermission() { return CustomerRow.deletePermission; }
        protected getInsertPermission() { return CustomerRow.insertPermission; }
        protected getUpdatePermission() { return CustomerRow.updatePermission; }

        protected form = new CustomerForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();
            this.ordersGrid.customerID = this.entityId;
        }

        protected save_submitHandler(callback: (response: Serenity.SaveResponse) => void) {
            Q.confirm("Are you sure you want to save this customer?", () => {
                super.save_submitHandler(callback);
            });
        }

        protected onSaveSuccess() {
            Q.notifySuccess("The customer was saved successfully", "Success saving");
        }

        private readonly ordersGrid: CustomerOrderGrid;

        constructor() {
            super();
            this.ordersGrid = new CustomerOrderGrid(this.byId("OrderGrid"));
            this.tabs.on('tabsactivate', (e, i) => { this.arrange(); });
        }
    }
}