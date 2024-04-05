using Serenity.Navigation;
using MyPages = SportShop.SportStore.Pages;

[assembly: NavigationLink(int.MaxValue, "Sport Shop/Customers", typeof(MyPages.CustomerController), icon: "fa-credit-card")]
[assembly: NavigationLink(int.MaxValue, "Sport Shop/Orders", typeof(MyPages.OrderController), icon: "fa-shopping-cart")]
[assembly: NavigationLink(int.MaxValue, "Sport Shop/Products", typeof(MyPages.ProductController), icon: "fa-cube")]
