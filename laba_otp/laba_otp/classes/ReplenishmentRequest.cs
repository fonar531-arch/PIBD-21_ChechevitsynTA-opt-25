using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public class ReplenishmentRequest
    {
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public DateTime RequestDate { get; private set; }
        public int Quantity { get; private set; }
        public RequestStatus Status { get; private set; }


        private ReplenishmentRequest() { }

        public static ReplenishmentRequest Create(
            int productId,
            DateTime requestDate,
            int quantity,
            RequestStatus status = RequestStatus.New)
        {
            if (productId <= 0)
                throw new ArgumentOutOfRangeException(nameof(productId), "Идентификатор товара должен быть больше нуля.");

            if (requestDate == default)
                throw new ArgumentException("Дата заявки обязательна.", nameof(requestDate));

            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "Количество для пополнения должно быть больше нуля.");

            return new ReplenishmentRequest
            {
                ProductId = productId,
                RequestDate = requestDate,
                Quantity = quantity,
                Status = status
            };
        }

        public void ChangeStatus(RequestStatus status)
        {
            Status = status;
        }
    }
}
