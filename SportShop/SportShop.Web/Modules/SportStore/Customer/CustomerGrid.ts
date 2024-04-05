
namespace SportShop.SportStore {

    @Serenity.Decorators.registerClass()
    export class CustomerGrid extends Serenity.EntityGrid<CustomerRow, any> {
        protected getColumnsKey() { return 'SportStore.Customer'; }
        protected getDialogType() { return CustomerDialog; }
        protected getIdProperty() { return CustomerRow.idProperty; }
        protected getInsertPermission() { return CustomerRow.insertPermission; }
        protected getLocalTextPrefix() { return CustomerRow.localTextPrefix; }
        protected getService() { return CustomerService.baseUrl; }

        protected getButtons() {
            var buttons = super.getButtons();

            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: OrderService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: true
            }));

            buttons.push(Common.PdfExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit()
            }));

            return buttons;
        }

        constructor(container: JQuery) {
            super(container);
        }
    }
}