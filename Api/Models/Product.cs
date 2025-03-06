namespace WebPharmarcy.Api.Models
{
    public class Product

    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public Categorys category { get; set; }
        public DateTime scadenza { get; set;}
       
    }
}
