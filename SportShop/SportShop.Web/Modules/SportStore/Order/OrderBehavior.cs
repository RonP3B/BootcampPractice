using Serenity;
using Serenity.Data;
using Serenity.Services;

namespace SportShop.Modules.SportStore
{
    public class OrderBehavior : IImplicitBehavior, IRetrieveBehavior, IListBehavior
    {
        private Int32Field fldCustomerId;

        public bool ActivateFor(Row row)
        {
            var customerOrderRow = row as ICustomerOrderRow;
            if (customerOrderRow == null) return false;
            fldCustomerId = customerOrderRow.CustomerIdField;
            return true;
        }

        public void OnPrepareQuery(IRetrieveRequestHandler handler, SqlQuery query)
        {
            QueryOrdersByCustomerId(query);
        }

        public void QueryOrdersByCustomerId(SqlQuery query)
        {
            var user = (UserDefinition)Authorization.UserDefinition;
            if (user.CustomerId == -1) return;
            query.Where(fldCustomerId == user.CustomerId);
        }


        public void OnPrepareQuery(IListRequestHandler handler, SqlQuery query)
        {
            QueryOrdersByCustomerId(query);
        }

        public void OnAfterExecuteQuery(IRetrieveRequestHandler handler) { }
        public void OnAfterExecuteQuery(IListRequestHandler handler) { }
        public void OnApplyFilters(IListRequestHandler handler, SqlQuery query) { }
        public void OnBeforeExecuteQuery(IRetrieveRequestHandler handler) { }
        public void OnBeforeExecuteQuery(IListRequestHandler handler) { }
        public void OnReturn(IRetrieveRequestHandler handler) { }
        public void OnReturn(IListRequestHandler handler) { }
        public void OnValidateRequest(IRetrieveRequestHandler handler) { }
        public void OnValidateRequest(IListRequestHandler handler) { }
    }
}