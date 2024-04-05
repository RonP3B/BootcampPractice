namespace SportShop.SportStore {
    export interface CustomerRow {
        CustomerId?: number;
        Name?: string;
        Email?: string;
        Phone?: string;
        Address?: string;
        Gender?: CustomerGender;
        DateOfBirth?: string;
        Notes?: string;
    }

    export namespace CustomerRow {
        export const idProperty = 'CustomerId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'SportStore.Customer';
        export const lookupKey = 'SportStore.Customer';

        export function getLookup(): Q.Lookup<CustomerRow> {
            return Q.getLookup<CustomerRow>('SportStore.Customer');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            CustomerId = "CustomerId",
            Name = "Name",
            Email = "Email",
            Phone = "Phone",
            Address = "Address",
            Gender = "Gender",
            DateOfBirth = "DateOfBirth",
            Notes = "Notes"
        }
    }
}

