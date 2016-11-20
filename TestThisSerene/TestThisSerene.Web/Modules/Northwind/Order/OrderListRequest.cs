using Serenity.Services;

namespace TestThisSerene.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}