/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace SportShop.SportStore {
    @Serenity.Decorators.registerEditor()
    export class OrderDetailEditor extends Common.GridEditorBase<OrderDetailRow> {
        protected getColumnsKey() { return "SportStore.OrderDetail"; }
        protected getDialogType() { return OrderDetailEditDialog; }
        protected getLocalTextPrefix() { return OrderDetailRow.localTextPrefix; }
        protected getAddButtonCaption() { return "Add Product"; }

        protected validateEntity(row: OrderDetailRow, id: number) {
            if (!super.validateEntity(row, id)) return false;

            row.ProductId = Q.toId(row.ProductId);

            const sameProduct = Q.tryFirst(
                this.view.getItems(), x => x.ProductId === row.ProductId
            );

            if (sameProduct && this.id(sameProduct) !== id) {
                Q.alert('This product is already in the list, try changing its quantity');
                return false;
            }

            const productItem = ProductRow.getLookup().itemById[row.ProductId];

            row.ProductName = productItem.Name
            row.ProductUnitPrice = productItem.UnitPrice;
            row.ProductItbis = productItem.Itbis;
            row.TotalPrice = (row.Quantity || 0) * (productItem.UnitPrice || 0);
            row.TotalItbis = (row.Quantity || 0) * (productItem.Itbis || 0);

            return true;
        }

        constructor(container: JQuery) {
            super(container);
        }
    }
}