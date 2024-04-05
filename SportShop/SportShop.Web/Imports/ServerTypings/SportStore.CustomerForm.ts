namespace SportShop.SportStore {
    export interface CustomerForm {
        Name: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        Phone: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Gender: Serenity.EnumEditor;
        DateOfBirth: Serenity.DateEditor;
        Notes: Serenity.TextAreaEditor;
    }

    export class CustomerForm extends Serenity.PrefixedContext {
        static formKey = 'SportStore.Customer';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CustomerForm.init)  {
                CustomerForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EmailEditor;
                var w2 = s.EnumEditor;
                var w3 = s.DateEditor;
                var w4 = s.TextAreaEditor;

                Q.initFormType(CustomerForm, [
                    'Name', w0,
                    'Email', w1,
                    'Phone', w0,
                    'Address', w0,
                    'Gender', w2,
                    'DateOfBirth', w3,
                    'Notes', w4
                ]);
            }
        }
    }
}

