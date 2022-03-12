using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy_Management.Models
{
    interface ICategoryRepository
    {
        List<Category> GetCategories();
    }
}
