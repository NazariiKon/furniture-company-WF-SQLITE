namespace FurnitureCompany
{
    public class Order
    {
        public Order()
        {
            
        }

        public Int64 Id { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public Int64 Status { get; set; }
        public Int64 ClientId { get; set; }
        public Int64 WorkerId { get; set; }
        public string Info { get; set; }
        public string Price { get; set; }

    }

}