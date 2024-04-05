namespace SportShop.SportStore {
    export interface OrderDetailForm {
        ProductId: Serenity.LookupEditor;
        Quantity: Serenity.IntegerEditor;
    }

    export class OrderDetailForm extends Serenity.PrefixedContext {
        static formKey = 'SportStore.OrderDetail';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrderDetailForm.init)  {
                OrderDetailForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(OrderDetailForm, [
                    'ProductId', w0,
                    'Quantity', w1
                ]);
            }
        }
    }
}

