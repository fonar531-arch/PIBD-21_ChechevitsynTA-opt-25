using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public class ProductBatchRepositoryStub : IProductBatchRepository
    {
        public IReadOnlyList<ProductBatch> GetAll() => Array.Empty<ProductBatch>();
        public ProductBatch GetById(int id) => null;
        public void Add(ProductBatch batch) { }
        public void Delete(int id) { }
        public void Delete(ProductBatch batch) { }
        public void Update(ProductBatch batch) { }
    }
}