using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace otp_lab_25
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int CategoryId { get; private set; }
        public ProductType Type { get; private set; }
        public decimal Price { get; private set; }
        public int StockNorm { get; private set; }
        public StorageConditions StorageConditions { get; private set; }

        private Product() { }

        public static Product Create(
            string name,
            int categoryId,
            ProductType type,
            decimal price,
            int stockNorm,
            StorageConditions storageConditions)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название товара не может быть пустым.", nameof(name));

            if (categoryId <= 0)
                throw new ArgumentOutOfRangeException(nameof(categoryId), "Идентификатор категории должен быть больше нуля.");

            if (price < 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Цена не может быть отрицательной.");

            if (stockNorm < 0)
                throw new ArgumentOutOfRangeException(nameof(stockNorm), "Норма остатка не может быть отрицательной.");

            if (type == ProductType.VetDrug && storageConditions == StorageConditions.None)
                throw new ArgumentException("Для ветеринарного препарата должны быть указаны условия хранения.", nameof(storageConditions));

            return new Product
            {
                Name = name.Trim(),
                CategoryId = categoryId,
                Type = type,
                Price = price,
                StockNorm = stockNorm,
                StorageConditions = storageConditions
            };
        }

        public void Update(
            string name,
            int categoryId,
            ProductType type,
            decimal price,
            int stockNorm,
            StorageConditions storageConditions)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название товара не может быть пустым.", nameof(name));

            if (categoryId <= 0)
                throw new ArgumentOutOfRangeException(nameof(categoryId), "Идентификатор категории должен быть больше нуля.");

            if (price < 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Цена не может быть отрицательной.");

            if (stockNorm < 0)
                throw new ArgumentOutOfRangeException(nameof(stockNorm), "Норма остатка не может быть отрицательной.");

            if (type == ProductType.VetDrug && storageConditions == StorageConditions.None)
                throw new ArgumentException("Для ветеринарного препарата должны быть указаны условия хранения.", nameof(storageConditions));

            Name = name.Trim();
            CategoryId = categoryId;
            Type = type;
            Price = price;
            StockNorm = stockNorm;
            StorageConditions = storageConditions;
        }
    }
}
