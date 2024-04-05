namespace SportShop.SportStore {
    export interface OrderDetailRow {
        OrderDetailId?: number;
        OrderId?: number;
        ProductId?: number;
        Quantity?: number;
        OrderCustomerId?: number;
        OrderOrderDate?: string;
        OrderDeadlineDate?: string;
        OrderShippedDate?: string;
        OrderShipAddress?: string;
        ProductName?: string;
        ProductDescription?: string;
        ProductUnitPrice?: number;
        ProductUnitsInStock?: number;
        ProductBrand?: string;
        ProductWeight?: number;
        ProductItbis?: number;
        TotalPrice?: number;
        TotalItbis?: number;
    }

    export namespace OrderDetailRow {
        export const idProperty = 'OrderDetailId';
        export const localTextPrefix = 'SportStore.OrderDetail';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'SportStore:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            OrderDetailId = "OrderDetailId",
            OrderId = "OrderId",
            ProductId = "ProductId",
            Quantity = "Quantity",
            OrderCustomerId = "OrderCustomerId",
            OrderOrderDate = "OrderOrderDate",
            OrderDeadlineDate = "OrderDeadlineDate",
            OrderShippedDate = "OrderShippedDate",
            OrderShipAddress = "OrderShipAddress",
            ProductName = "ProductName",
            ProductDescription = "ProductDescription",
            ProductUnitPrice = "ProductUnitPrice",
            ProductUnitsInStock = "ProductUnitsInStock",
            ProductBrand = "ProductBrand",
            ProductWeight = "ProductWeight",
            ProductItbis = "ProductItbis",
            TotalPrice = "TotalPrice",
            TotalItbis = "TotalItbis"
        }
    }
}

