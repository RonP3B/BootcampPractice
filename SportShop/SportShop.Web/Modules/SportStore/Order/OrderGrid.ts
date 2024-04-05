
namespace SportShop.SportStore {

    @Serenity.Decorators.registerClass()
    export class OrderGrid extends Serenity.EntityGrid<OrderRow, any> {
        protected getColumnsKey() { return 'SportStore.Order'; }
        protected getDialogType() { return OrderDialog; }
        protected getIdProperty() { return OrderRow.idProperty; }
        protected getInsertPermission() { return OrderRow.insertPermission; }
        protected getLocalTextPrefix() { return OrderRow.localTextPrefix; }
        protected getService() { return OrderService.baseUrl; }

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

        protected getColumns() {
            var columns = super.getColumns();

            columns.splice(1, 0, {
                field: 'Print Invoice',
                name: '',
                format: ctx => '<a class="inline-action print-invoice" title="invoice">' +
                    '<i class="fa fa-file-pdf-o text-red"></i></a>',
                width: 24,
                minWidth: 24,
                maxWidth: 24
            });

            return columns;
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number) {
            super.onClick(e, row, cell);

            if (e.isDefaultPrevented()) return;

            const item = this.itemAt(row);
            let target = $(e.target);

            if (target.parent().hasClass('inline-action'))
                target = target.parent();

            if (target.hasClass('inline-action')) {
                e.preventDefault();

                if (target.hasClass('print-invoice')) {
                    SportShop.Common.ReportHelper.execute({
                        reportKey: 'SportStore.OrderDetail',
                        params: {
                            OrderID: item.OrderId
                        }
                    });
                }
            }
        }

        constructor(container: JQuery) {
            super(container);
        }
    }
}