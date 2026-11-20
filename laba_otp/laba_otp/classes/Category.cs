using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        private Category() { }

        public static Category Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название категории не может быть пустым.", nameof(name));

            return new Category { Name = name.Trim() };
        }

        public void UpdateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название категории не может быть пустым.", nameof(name));

            Name = name.Trim();
        }
    }
}
