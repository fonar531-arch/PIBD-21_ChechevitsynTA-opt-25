using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public class Sale
    {
        public int Id { get; private set; }
        public DateTime SaleDate { get; private set; }


        private readonly List<SaleItem> _items = new List<SaleItem>();
        public IReadOnlyCollection<SaleItem> Items => _items.AsReadOnly();

        private Sale() { }

        public static Sale Create(DateTime saleDate)
        {
            if (saleDate == default)
                throw new ArgumentException("Дата продажи обязательна.", nameof(saleDate));

            return new Sale { SaleDate = saleDate };
        }
        public void AddItem(int saleId, int productBatchId, int quantity, decimal price)
        {
            var item = SaleItem.Create(saleId, productBatchId, quantity, price);
            _items.Add(item);
        }
        public decimal GetTotalAmount()
        {
            return _items.Sum(item => item.GetTotal());
        }
    }
}
