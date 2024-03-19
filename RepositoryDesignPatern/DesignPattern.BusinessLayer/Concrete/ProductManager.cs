using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public void TDelete(Product t)
        {
            productDal.Delete(t);
        }

        public Product TGetByID(int id)
        {
            return productDal.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return productDal.GetList();
        }

        public void TInsert(Product t)
        {
            productDal.Insert(t);
        }

        public List<Product> TProductListWithCategory()
        {
            return productDal.ProductListWithCategory();
        }

        public void TUpdate(Product t)
        {
            productDal.Update(t);
        }
    }
}
