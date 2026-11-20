using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public class SupplierRepositoryStub : ISupplierRepository
    {
        public IReadOnlyList<Supplier> GetAll() => Array.Empty<Supplier>();
        public Supplier GetById(int id) => null;
        public void Add(Supplier supplier) { }
        public void Update(Supplier supplier) { }
        public void Delete(int id) { }
    }
}