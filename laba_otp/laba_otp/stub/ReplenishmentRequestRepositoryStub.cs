using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public class ReplenishmentRequestRepositoryStub : IReplenishmentRequestRepository
    {
        public IReadOnlyList<ReplenishmentRequest> GetAll() => Array.Empty<ReplenishmentRequest>();
        public ReplenishmentRequest GetById(int id) => null;
        public void Add(ReplenishmentRequest request) { }
        public void Update(ReplenishmentRequest request) { }
        public void Delete(int id) { }
    }
}
