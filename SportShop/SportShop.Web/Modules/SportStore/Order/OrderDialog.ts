
namespace SportShop.SportStore {

    @Serenity.Decorators.registerClass()
    export class OrderDialog extends Serenity.EntityDialog<OrderRow, any> {
        protected getFormKey() { return OrderForm.formKey; }
        protected getIdProperty() { return OrderRow.idProperty; }
        protected getLocalTextPrefix() { return OrderRow.localTextPrefix; }
        protected getNameProperty() { return OrderRow.nameProperty; }
        protected getService() { return OrderService.baseUrl; }
        protected getDeletePermission() { return OrderRow.deletePermission; }
        protected getInsertPermission() { return OrderRow.insertPermission; }
        protected getUpdatePermission() { return OrderRow.updatePermission; }

        protected save_submitHandler(callback: (response: Serenity.SaveResponse) => void) {
            Q.confirm("Are you sure you want to save this order?", () => {
                super.save_submitHandler(callback);
            });
        }

        protected onSaveSuccess() {
            Q.notifySuccess("The order was saved successfully", "Success saving");
        }

        protected form = new OrderForm(this.idPrefix);

    }
}