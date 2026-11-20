using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public class Supplier
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        private Supplier() { }

        public static Supplier Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название поставщика не может быть пустым.", nameof(name));

            return new Supplier { Name = name.Trim() };
        }

        public void UpdateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название поставщика не может быть пустым.", nameof(name));

            Name = name.Trim();
        }
    }
}
