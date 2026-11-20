using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public class ProductRepositoryStub : IProductRepository
    {
        public IReadOnlyList<Product> GetAll() => Array.Empty<Product>();
        public Product GetById(int id) => null;
        public void Add(Product product) { }
        public void Update(Product product) { }
        public void Delete(int id) { }
    }
}