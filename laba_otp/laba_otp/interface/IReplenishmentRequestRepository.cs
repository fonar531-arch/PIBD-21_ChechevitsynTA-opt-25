using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public interface IReplenishmentRequestRepository
    {
        IReadOnlyList<ReplenishmentRequest> GetAll();
        ReplenishmentRequest GetById(int id);
        void Add(ReplenishmentRequest request);
        void Update(ReplenishmentRequest request);
        void Delete(int id);
    }
}