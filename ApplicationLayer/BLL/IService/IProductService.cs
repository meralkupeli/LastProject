using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementDAL.Model.Product;

namespace ApplicationLayer.BLL.IService
{
        public interface IProductService
        {
            List<ProductDto> GetProducts();

            ProductDto GetProduct(int id);

            void Add(CreateProductDto product);
            void Update(UpdateProductDto product);
            void Delete(DeleteProductDto product);
        }
}
