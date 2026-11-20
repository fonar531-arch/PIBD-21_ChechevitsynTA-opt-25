using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public interface IProductBatchRepository
    {
        IReadOnlyList<ProductBatch> GetAll();
        ProductBatch GetById(int id);
        void Add(ProductBatch batch);
        void Update(ProductBatch batch); void Delete(ProductBatch batch);
        void Delete(int id);
    }
}