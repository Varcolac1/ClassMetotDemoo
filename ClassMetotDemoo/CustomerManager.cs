using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemoo
{
    internal class CustomerManager
    {
        List<Customer> customers = new List<Customer>();    
        internal void Add(Customer customer)
        {
            Console.WriteLine("Customer has been added: "+ customer.FirstName+" "+customer.LastName);
            customers.Add(customer);
        }
        internal void Delete(Customer customer)
        {
            Console.WriteLine("Customer has been deleted: " + customer.FirstName + " " + customer.LastName);
            customers.Remove(customer);
        }
        internal void List()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id+" "+customer.FirstName+" "+ customer.LastName);
            }
        }
    }
}
