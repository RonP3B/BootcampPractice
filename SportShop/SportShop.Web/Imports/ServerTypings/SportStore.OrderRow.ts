namespace SportShop.SportStore {
    export interface OrderRow {
        OrderId?: number;
        CustomerId?: number;
        OrderDate?: string;
        DeadlineDate?: string;
        ShippedDate?: string;
        ShipAddress?: string;
        CustomerName?: string;
        CustomerEmail?: string;
        CustomerPhone?: string;
        CustomerAddress?: string;
        CustomerGender?: number;
        CustomerDateOfBirth?: string;
        CustomerNotes?: string;
        OrderStatus?: OrderStatus;
        DetailList?: OrderDetailRow[];
    }

    export namespace OrderRow {
        export const idProperty = 'OrderId';
        export const nameProperty = 'ShipAddress';
        export const localTextPrefix = 'SportStore.Order';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'SportStore:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            OrderId = "OrderId",
            CustomerId = "CustomerId",
            OrderDate = "OrderDate",
            DeadlineDate = "DeadlineDate",
            ShippedDate = "ShippedDate",
            ShipAddress = "ShipAddress",
            CustomerName = "CustomerName",
            CustomerEmail = "CustomerEmail",
            CustomerPhone = "CustomerPhone",
            CustomerAddress = "CustomerAddress",
            CustomerGender = "CustomerGender",
            CustomerDateOfBirth = "CustomerDateOfBirth",
            CustomerNotes = "CustomerNotes",
            OrderStatus = "OrderStatus",
            DetailList = "DetailList"
        }
    }
}

