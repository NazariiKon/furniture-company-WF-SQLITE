namespace FurnitureCompany
{
    public class Product
    {
        public Product()
        {
            
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long Count { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Desc { get; set; }
        public long ManufacturerId { get; set; }
        public long CategoryId { get; set; }
    }
}