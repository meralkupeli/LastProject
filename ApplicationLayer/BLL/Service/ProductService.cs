using ApplicationLayer.BLL.IService;
using ManagementDAL.Domain.Entity;
using ManagementDAL.IRepository;
using ManagementDAL.Model.Product;
using ManagementDAL.Repository.OrderRepository;
using ManagementDAL.Repository.ProductRepository;
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
        private readonly IOrderRepository<Order> orderRepository;
        private readonly IProductRepository<Product> productRepository;
        private readonly IOrderProductRepository<OrderProduct> orderProductRepository;

        //Dependecy İnjection
        public ProductService(IProductRepository<Product> productRepository,
          IOrderRepository<Order> orderRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
        }
        #endregion

        public void Add(CreateProductDto product)
        {
            var products = productRepository.GetProduct((int)product.ProductId);
            if (products == null)
            {
                var _product = new Product { Name = product.Name };
                productRepository.Add(_product);

                //productRepositoryKaydet
            }

        }



        public void Delete(DeleteProductDto product)
        {
            var _product = productRepository.GetProduct(product.Id);

            if (_product != null)
            {
                productRepository.Delete(_product);
            }
        }



        public ProductDto GetProduct(int id)
        {
            var _product = productRepository.GetProduct(id) as Product;

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
            var products = productRepository.GetProducts() as List<ProductDto>;

            return products.Select(x => new ProductDto
            {

                CreatedDate = x.CreatedDate,
                Name = x.Name,
                Id = x.Id
            }).ToList();
        }


        public void Update(UpdateProductDto product)
        {
            var _product = productRepository.GetProduct(product.Id);

            _product.Name = product.Name;
            _product.CreatedDate = DateTime.Now;

            productRepository.Update(_product);
        }

    }
}
