using ApplicationLayer.BLL.IService;
using ManagementDAL.Domain.Entity;
using ManagementDAL.IRepository;
using ManagementDAL.Model.Product;
using ManagementDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.BLL.Service
{
    public class ProductService : IProductService
    {
        #region Dependecy Injection
        private readonly Repository<Order> orderRepository;

        //Dependecy İnjection
        public ProductService(IRepository<Product> Repository,
          IRepository<Order> orderRepository)
        {
            this.Repository = Repository;
        }

        public IRepository<Product> Repository { get; }
        #endregion

        public void Add(CreateProductDto product)
        {
            var products = Repository.GetProduct((int)product.ProductId);
            if (products == null)
            {
                var _product = new Product { Name = product.Name };
               Repository.Add(_product);

                //productRepositoryKaydet
            }

        }



        public void Delete(DeleteProductDto product)
        {
            var _product = Repository.GetProduct(product.Id);

            if (_product != null)
            {
                Repository.Delete(_product);
            }
        }



        public ProductDto GetProduct(int id)
        {
            var _product = Repository.GetProduct(id) as Product;

            if (_product != null)
            {
                return new ProductDto
                {
                    CreatedDate = _product.CreateDate,
                    Name = _product.Name,
                };
            }

            return null;
        }

        public List<ProductDto> GetProducts()
        {
            var products = Repository.GetProducts() as List<ProductDto>;

            return products.Select(x => new ProductDto
            {

                CreatedDate = x.CreatedDate,
                Name = x.Name,
                Id = x.Id
            }).ToList();
        }


        public void Update(UpdateProductDto product)
        {
            var _product = Repository.GetProduct(product.Id);

            _product.Name = product.Name;
            _product.CreatedDate = DateTime.Now;

            Repository.Update(_product);
        }

    }
}
