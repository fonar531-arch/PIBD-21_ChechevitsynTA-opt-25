using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public class SaleItem
    {
        public int Id { get; private set; }
        public int SaleId { get; private set; }
        public int ProductBatchId { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }

        private SaleItem() { }

        public static SaleItem Create(
            int saleId,
            int productBatchId,
            int quantity,
            decimal unitPrice)
        {
            if (saleId == 0)
                throw new ArgumentOutOfRangeException(nameof(saleId), "Идентификатор продажи должен быть больше нуля.");

            if (productBatchId <= 0)
                throw new ArgumentOutOfRangeException(nameof(productBatchId), "Идентификатор партии товара должен быть больше нуля.");

            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "Количество должно быть больше нуля.");

            if (unitPrice < 0)
                throw new ArgumentOutOfRangeException(nameof(unitPrice), "Цена продажи не может быть отрицательной.");

            return new SaleItem
            {
                SaleId = saleId,
                ProductBatchId = productBatchId,
                Quantity = quantity,
                UnitPrice = unitPrice
            };
        }

        public decimal GetTotal()
        {
            return Quantity * UnitPrice;
        }
    }
}
