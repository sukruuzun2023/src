using API.Core.DbModels;
using API.Infranstructure.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly Context _context;
        public ProductsController(Context context)
        {
            _context = context;
        }
       [HttpGet]
       public ActionResult<Product> GetProduct(int id)
        {
            return _context.Products.Find(id);
        }
    }
}
