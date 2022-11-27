using Microsoft.AspNetCore.Mvc;
using Nojiki.Models;

namespace Nojiki.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class KnivesController
    {
        [HttpPost]
        public void Add(Cart cart)
        {
            KnivesContext uc = new KnivesContext();
            uc.Carts.Add(cart);
            uc.SaveChanges();
        }
        [HttpGet]
        public IEnumerable<Cart> Get() => new KnivesContext().Carts;
        

    }
}
