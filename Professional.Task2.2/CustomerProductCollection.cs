using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional.Task2._2
{
    internal class CustomerProductCollection
    {
        private Dictionary<string, HashSet<string>> customerToCategories = new();
        private Dictionary<string, HashSet<string>> categoryToCustomers = new();

        public void AddPurchase(string customer, string category)
        {
            if (!customerToCategories.ContainsKey(customer))
                customerToCategories[customer] = new HashSet<string>();
            customerToCategories[customer].Add(category);

            if (!categoryToCustomers.ContainsKey(category))
                categoryToCustomers[category] = new HashSet<string>();
            categoryToCustomers[category].Add(customer);
        }

        public IEnumerable<string> GetCategoriesByCustomer(string customer)
        {
            return customerToCategories.TryGetValue(customer, out var categories) ? categories : Enumerable.Empty<string>();
        }

        public IEnumerable<string> GetCustomersByCategory(string category)
        {
            return categoryToCustomers.TryGetValue(category, out var customers) ? customers : Enumerable.Empty<string>();
        }
    }
}
