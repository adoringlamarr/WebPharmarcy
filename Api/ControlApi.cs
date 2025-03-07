using Microsoft.AspNetCore.Mvc;
using WebPharmarcy.Api.Models;

namespace WebPharmarcy.Api
{
   /// <summary>
   /// NON USARE COPILOT/CHAT-GPT/DEEPSEEK
   /// </summary>
   [ApiController]
   public class ControlApi
   {
      //NON usare la classe Product già definita
      //Va utilizzata una nuova classe contenente tutti i dettagli di un prodotta
      private List<Product> _products = new List<Product>(); // Inizializzazione lista di prodotti

      public ControlApi()
      {
         //Inserimento valori in lista di prodotti
      }

      /// <summary>
      /// Restituire una lista di oggetti contenente
      /// i dettagli minimi di un prodotto:
      /// - Id
      /// - Nome
      /// - Prezzo
      /// </summary>
      /// <returns></returns>
      /// <exception cref="NotImplementedException"></exception>
      [HttpGet, Route("product")]
      public List<Product> GetProducts() 
      {
         throw new NotImplementedException();
      }

      /// <summary>
      /// Verificare che ci sia un prodotto con l'id specificato.
      /// Se non c'è: restituire null
      /// Se c'è: restituire un oggetto con i dettagli completi del prodotto:
      /// - Tutti i dettagli minimi
      /// - categoria
      /// - descrizione
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
      /// <exception cref="NotImplementedException"></exception>
      [HttpGet, Route("product/{id}")]
      public Product GetProducts(String id)
      {
         throw new NotImplementedException();
      }

      /// <summary>
      /// Aggiunta di un prodotto alla lista.
      /// Il prodotto preso in input contiene i dettagli completi
      /// del prodotto TRANNE l'id (che verrà generato)
      /// </summary>
      /// <param name="product"></param>
      /// <returns></returns>
      /// <exception cref="NotImplementedException"></exception>
      [HttpPost, Route("product")]
      public Product AddProduct([FromBody] Product product)
      {
         Guid id = Guid.NewGuid(); //genero nuovo id
         throw new NotImplementedException();
      }

      /// <summary>
      /// Rimozione di un prodotto dalla lista.
      /// Verificare che ci sia un prodotto con l'id specificato.
      /// Se non c'è: restituire null
      /// Se c'è: restituire il prodotto che ho eliminato
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
      /// <exception cref="NotImplementedException"></exception>
      [HttpDelete, Route("product/{id}")]
      public Product DeleteProduct(String id)
      {
         throw new NotImplementedException();
      }
   }
}
