using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository {  get; set; }
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        public Customer Retrieve(int customerId)
        {    // İstenilen kimlikte müşteri sınıfı geçişinin örneğini oluşturun

           Customer customer = new Customer( customerId);  

            //tanımlanan müşteriyi getiren kod.

            //doldurulmuş bir müşteriyi döndürmek için geçici olarak sabit kodlnmış değerlerdir. 
                
                if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "frodo";
                customer.LastName = "baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
