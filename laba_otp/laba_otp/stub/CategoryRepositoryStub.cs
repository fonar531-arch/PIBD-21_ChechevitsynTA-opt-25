using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    public class CategoryRepositoryStub : ICategoryRepository
    {
        public IReadOnlyList<Category> GetAll()
        {
            return Array.Empty<Category>();
        }

        public Category GetById(int id)
        {
            return null;
        }

        public void Add(Category category)
        {

        }

        public void Update(Category category)
        {
        
        }

        public void Delete(int id)
        {
        }
    }
}
