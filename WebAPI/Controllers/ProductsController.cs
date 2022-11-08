using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class ProductsController : ControllerBase
    {
        //loosely coupled - gevşek bağlılık
        //Naming convention -- isimlendirme strandartı
        //Ioc container -inversion on control
        IProductService _productService;//field

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            //dependency chain -- bağımlılık zinciri
            IProductService productService = new ProductManager(new EfProductDal());//ıproductservice productmanager referansını tutabiliyor
            var result = _productService.GetAll();
            return result.Data;

        }
}