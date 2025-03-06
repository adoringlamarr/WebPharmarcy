using Microsoft.AspNetCore.Mvc;
using WebPharmarcy.Api.Models;

namespace WebPharmarcy.Api
{
    [ApiController]

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
            p.id = GetNewId();
            Products.Add(p);
            return p;
        }

        private int GetNewId()
        {
            return 0;
        }

        //endpoint per rimuovere un prodotto dalla lista dato il suo id



    }
}
