using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public class ProductBatch
    {
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int SupplierId { get; private set; }
        public DateTime ReceiptDate { get; private set; }
        public DateTime? ExpiryDate { get; private set; }
        public int Quantity { get; private set; }
        public decimal PurchasePrice { get; private set; }

        private ProductBatch() { }

        public static ProductBatch Create(
            int productId,
            int supplierId,
            DateTime receiptDate,
            DateTime? expiryDate,
            int quantity,
            decimal purchasePrice)
        {
            if (productId <= 0)
                throw new ArgumentOutOfRangeException(nameof(productId), "Идентификатор товара должен быть больше нуля.");

            if (supplierId <= 0)
                throw new ArgumentOutOfRangeException(nameof(supplierId), "Идентификатор поставщика должен быть больше нуля.");

            if (receiptDate == default)
                throw new ArgumentException("Дата прихода обязательна.", nameof(receiptDate));

            if (expiryDate.HasValue && expiryDate.Value <= receiptDate)
                throw new ArgumentException("Срок годности должен быть позже даты прихода.", nameof(expiryDate));

            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "Количество в партии должно быть больше нуля.");

            if (purchasePrice < 0)
                throw new ArgumentOutOfRangeException(nameof(purchasePrice), "Закупочная цена не может быть отрицательной.");

            return new ProductBatch
            {
                ProductId = productId,
                SupplierId = supplierId,
                ReceiptDate = receiptDate,
                ExpiryDate = expiryDate,
                Quantity = quantity,
                PurchasePrice = purchasePrice
            };
        }
    }
}
