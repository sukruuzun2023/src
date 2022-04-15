using API.Data.DataContext;
using API.Data.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context; // Bir Değişken olarak tanımladık
        public ProductsController(StoreContext context) // ctor yazarak constarak olusturduk 
        {
            _context = context; // tanımladığım store context store context mı ver

        }


        [HttpGet]
        public async Task< ActionResult<List<Product>>> GetProducts() // Senin geri dönüş tipin ActionResult olcak ama birden cok data dönceği için list olcak bu liste de product listesi olsun diyoruz
        {
            var data = await _context.Products.ToListAsync();
            return data;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id) // sem geri dönüş olarak Product içersinde bir id numarası al
        {
            return await _context.Products.FindAsync(id);  // bana context içersinde buldugun id numarasını göster
        }
    }
}
