namespace SportShop.SportStore {
    export interface ProductRow {
        ProductId?: number;
        Name?: string;
        Description?: string;
        UnitPrice?: number;
        UnitsInStock?: number;
        Brand?: string;
        Weight?: number;
        Itbis?: number;
    }

    export namespace ProductRow {
        export const idProperty = 'ProductId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'SportStore.Product';
        export const lookupKey = 'SportStore.Product';

        export function getLookup(): Q.Lookup<ProductRow> {
            return Q.getLookup<ProductRow>('SportStore.Product');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ProductId = "ProductId",
            Name = "Name",
            Description = "Description",
            UnitPrice = "UnitPrice",
            UnitsInStock = "UnitsInStock",
            Brand = "Brand",
            Weight = "Weight",
            Itbis = "Itbis"
        }
    }
}

