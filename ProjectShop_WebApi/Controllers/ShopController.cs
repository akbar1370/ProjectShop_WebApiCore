using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectShop_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        [Route("GetName")]
        [HttpGet]
        public async Task<string> GetName()
        {
            return "فروشگاه";
        }

        [Route("GetListProduct")]
        [HttpGet]
        public async Task<List<ListProduct>> GetListProduct()
        {
            // مثلا از دیتابیس داره فچ میکنه
            List<ListProduct> List = new List<ListProduct>();
            List.Add(new ListProduct { Id = 1, Code = 10001, Name = "جارو برقی", Price = 1200000 });
            List.Add(new ListProduct { Id = 2, Code = 10002, Name = " اتو ", Price = 500000 });
            List.Add(new ListProduct { Id = 3, Code = 10003, Name = " لباسشویی", Price = 2200000 });
            List.Add(new ListProduct { Id = 4, Code = 10004, Name = "تلویزیون", Price = 3200000 });

            return List;
        }

        //RestFull Api
        [Route("GetListProductByCode/{code}")]
        [HttpGet]
        public async Task<ListProduct> GetListProductByCode(long? Code)
        {
            // مثلا از دیتابیس داره فچ میکنه
            List<ListProduct>? List = new List<ListProduct>();
            List.Add(new ListProduct { Id = 1, Code = 10001, Name = "جارو برقی", Price = 1200000 });
            List.Add(new ListProduct { Id = 2, Code = 10002, Name = " اتو ", Price = 500000 });
            List.Add(new ListProduct { Id = 3, Code = 10003, Name = " لباسشویی", Price = 2200000 });
            List.Add(new ListProduct { Id = 4, Code = 10004, Name = "تلویزیون", Price = 3200000 });

            var Find = List.Where(x => x.Code == Code).FirstOrDefault();
            return Find;
        }

        //RestFull Api Insert
        [Route("InsertProduct/{id}/{code}/{name}/{price}")]
        [HttpPost]
        public async Task<ListProduct> InsertProduct(ListProduct listProduct)
        {
            return listProduct;
        }


    }
}
