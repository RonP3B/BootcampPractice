
namespace SportShop.SportStore
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Reporting;
    using System;
    using System.Collections.Generic;

    [Report("SportStore.OrderDetail")]
    [ReportDesign("~/Modules/SportStore/OrderDetail/OrderDetailReport.cshtml")]
    [RequiredPermission("SportStore:General")]//ojo
    public class OrderDetailReport : IReport
    {
        public Int32 OrderId { get; set; }

        public object GetData()
        {
            var data = new OrderDetailReportData();

            using (var connection = SqlConnections.NewFor<OrderRow>())
            {
                var o = OrderRow.Fields;

                data.Order = connection.TryById<OrderRow>(this.OrderId, q => q
                     .SelectTableFields()
                     .Select(o.OrderDate)
                     .Select(o.CustomerName)
                     .Select(o.CustomerEmail)
                     .Select(o.CustomerPhone)
                     .Select(o.ShipAddress)) ?? new OrderRow();

                var od = OrderDetailRow.Fields;
                data.Details = connection.List<OrderDetailRow>(q => q
                    .SelectTableFields()
                    .Select(od.ProductName)
                    .Select(od.ProductUnitPrice)
                    .Select(od.ProductItbis)
                    .Select(od.Quantity)
                    .Select(od.TotalPrice)
                    .Select(od.TotalItbis)
                    .Where(od.OrderId == this.OrderId));

                var c = CustomerRow.Fields;
                data.Customer = connection.TryFirst<CustomerRow>(c.CustomerId == (int)data.Order.CustomerId)
                    ?? new CustomerRow();
            }

            return data;
        }
    }

    public class OrderDetailReportData
    {
        public OrderRow Order { get; set; }
        public List<OrderDetailRow> Details { get; set; }
        public CustomerRow Customer { get; set; }
    }
}