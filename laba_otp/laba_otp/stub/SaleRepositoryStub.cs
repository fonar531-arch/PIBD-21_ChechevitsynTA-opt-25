using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public class SaleRepositoryStub : ISaleRepository
    {
        public IReadOnlyList<Sale> GetAll() => Array.Empty<Sale>();
        public Sale GetById(int id) => null;
        public void Add(Sale sale) { }
        public void Delete(int id) { }
    }
}