using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public interface ISaleRepository
    {
        IReadOnlyList<Sale> GetAll();
        Sale GetById(int id);
        void Add(Sale sale);
        void Delete(int id);
    }
}