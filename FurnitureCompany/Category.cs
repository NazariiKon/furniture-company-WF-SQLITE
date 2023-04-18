namespace FurnitureCompany
{
    public class Category
    {
        public Category()
        {

        }
        public Category(long id, string name, string desc)
        {
            this.Id = id;
            this.Name = name;
            this.Desc = desc;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public List<Product> Products { get; set; }
    }
}