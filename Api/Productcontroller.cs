using Microsoft.AspNetCore.Mvc;
using WebPharmarcy.Api.Models;

namespace WebPharmarcy.Api
{
    /*[ApiController]

    public class Productcontroller : Controller
    {
        public List<Product> Products;
        public Productcontroller()
        {
            Products = new List<Product>();
            Product p1 = new Product()
            {
                name = "Flumicil",
                category = Categorys.tosse,
                description = "description tosse grassa",
                id = 1,
                price = 11.22m,
                scadenza = new DateTime(2025, 4, 23)
            };
            Product p2 = new Product()
            {
                name = "Nurofen",
                category = Categorys.tosse,
                description = "description tosse grassa",
                id = 2,
                price = 11.22m,
                scadenza = new DateTime(2026, 4, 2)
            };
            Product p3 = new Product()
            {
                name = "Rischiarill",
                category = Categorys.tosse,
                description = "description tosse grassa",
                id = 3,
                price = 11.22m,
                scadenza = new DateTime(2026, 5, 20)
            };
            Product p4 = new Product()
            {
                name = "Nurofen",
                category = Categorys.tosse,
                description = "description tosse grassa",
                id = 4,
                price = 11.22m,
                scadenza = new DateTime(2025, 5, 25)
            };


            Products.Add(p1);
            Products.Add(p2);
            Products.Add(p3);
            Products.Add(p4);

        }


        [HttpGet, Route("Products")]
        public List<Product> getProducts()

        {
            return this.Products;
        }
        [HttpGet, Route("Product/{id}")]
        public Product getProduct(int id)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Product p = Products[i];
                if (p.id == id) { return p; }


            }
            return null;

        }
        [HttpPost, Route("Product")]
        public Product postProduct([FromBody] Product p)
        {
            //sarebbe interessante implementare un pezzetto di codice che vada ad assegnare un id univoco fornito al prodotto che abbiamo assegnato
            p.id = NewId;
            Products.Add(p);
            return p;
        }

        private int NewId => 0;
    }


        //endpoint per rimuovere un prodotto dalla lista dato il suo id

        namespace ProductRemovalExample
    {
        class Program
        {
            // Classe del Prodotto
            public class Product
            {
                public string ProductId { get; set; }
                public string Name { get; set; }
                public decimal Price { get; set; }

                public Product(string productId, string name, decimal price)
                {
                    ProductId = productId;
                    Name = name;
                    Price = price;
                }
            }

            static void Main(string[] args)
            {
                // Lista di prodotti
                List<Product> products = new List<Product>
            {
                new Product("1", "Product 1", 11.22m),
                new Product("2", "Product 2", 11.22m),
                new Product("3", "Product 3", 11.22m),
                new Product("4", "Product 4", 11.22m)
            };

                // Visualizza la lista dei prodotti iniziali
                Console.WriteLine("Initial Product List:");
                DisplayProducts(products);

                // ID del prodotto da rimuovere
                string productIdToRemove = "2";

                // Rimuovi il prodotto dalla lista usando Remove()
                Product productToRemove = products.FirstOrDefault(p => p.ProductId == productIdToRemove);
                if (productToRemove != null)
                {
                    products.Remove(productToRemove);
                    Console.WriteLine($"\nProduct with ID {productIdToRemove} has been removed.");
                }
                else
                {
                    Console.WriteLine("\nProduct not found.");
                }

                // Visualizza la lista dei prodotti dopo la rimozione
                Console.WriteLine("\nUpdated Product List:");
                DisplayProducts(products);
            }

            // Metodo per visualizzare la lista dei prodotti
            static void DisplayProducts(List<Product> products)
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"ID: {product.ProductId}, Name: {product.Name}, Price: {product.Price:3}");
                }
            }
        }

    }*/
}

