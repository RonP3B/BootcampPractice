
namespace SportShop.SportStore {

    @Serenity.Decorators.registerClass()
    export class ProductGrid extends Serenity.EntityGrid<ProductRow, any> {
        protected getColumnsKey() { return 'SportStore.Product'; }
        protected getDialogType() { return ProductDialog; }
        protected getIdProperty() { return ProductRow.idProperty; }
        protected getInsertPermission() { return ProductRow.insertPermission; }
        protected getLocalTextPrefix() { return ProductRow.localTextPrefix; }
        protected getService() { return ProductService.baseUrl; }

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