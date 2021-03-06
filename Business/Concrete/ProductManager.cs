using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

       // ProductManager newlendiğinde constracter yani  19.satır oluşur.constracter der ki bana in producter referansı ver
        IProductDal _productDal;
    
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {

           // iş kodları
              //  yetkisi varmı 
            return _productDal.GetAll();
        }
    }
}
