/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace SportShop.SportStore {
    @Serenity.Decorators.registerClass()
    export class OrderDetailEditDialog extends Common.GridEditorDialog<OrderDetailRow> {
        protected getFormKey() { return OrderDetailForm.formKey; }
        protected getLocalTextPrefix() { return OrderDetailRow.localTextPrefix; }
        protected form: OrderDetailForm;

        constructor() {
            super();
            this.form = new OrderDetailForm(this.idPrefix);
        }
    }

}