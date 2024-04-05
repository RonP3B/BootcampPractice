namespace SportShop.SportStore {
    export interface ProductForm {
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Brand: Serenity.StringEditor;
        Weight: Serenity.DecimalEditor;
        UnitPrice: Serenity.DecimalEditor;
        UnitsInStock: Serenity.IntegerEditor;
        Itbis: Serenity.DecimalEditor;
    }

    export class ProductForm extends Serenity.PrefixedContext {
        static formKey = 'SportStore.Product';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductForm.init)  {
                ProductForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(ProductForm, [
                    'Name', w0,
                    'Description', w0,
                    'Brand', w0,
                    'Weight', w1,
                    'UnitPrice', w1,
                    'UnitsInStock', w2,
                    'Itbis', w1
                ]);
            }
        }
    }
}

