namespace SportShop.SportStore {
    export interface OrderForm {
        OrderDate: Serenity.DateEditor;
        DeadlineDate: Serenity.DateEditor;
        ShippedDate: Serenity.DateEditor;
        CustomerId: Serenity.LookupEditor;
        ShipAddress: Serenity.StringEditor;
        DetailList: OrderDetailEditor;
    }

    export class OrderForm extends Serenity.PrefixedContext {
        static formKey = 'SportStore.Order';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrderForm.init)  {
                OrderForm.init = true;

                var s = Serenity;
                var w0 = s.DateEditor;
                var w1 = s.LookupEditor;
                var w2 = s.StringEditor;
                var w3 = OrderDetailEditor;

                Q.initFormType(OrderForm, [
                    'OrderDate', w0,
                    'DeadlineDate', w0,
                    'ShippedDate', w0,
                    'CustomerId', w1,
                    'ShipAddress', w2,
                    'DetailList', w3
                ]);
            }
        }
    }
}

