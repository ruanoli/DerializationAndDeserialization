namespace SerializacaoEDeserializacao.Models
{
    public class Sale
    {
        public Sale(int id, string product, decimal price, DateTime saleDate)
        {
            Id = id;
            Product = product;
            Price = price;
            SaleDate = saleDate;
        }
        public int Id { get; set; }
        public string? Product { get; set; }
        public decimal Price { get; set; }
        public DateTime SaleDate { get; set; }
    }
}