using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    public class Customer :  EntityBase, ILoggable
    {

        public Customer() : this(0)
        {



        }
        public Customer(int customerId)
        {
            customerId = customerId;
            AddressList = new List<Address>();

        }

        public List<Address> AddressList { get; set; }

        public int CostumerID { get; set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {

                string fullName = LastName;
                //IsNullOrWhiteSpace: Dizenin boş olup olmadığını ,boşluk karakterleri içerip içermediğini kontrol etmek için kullanılır.
                //diziye bir değer atanmamışsa veya null değeri atanmışsa null olacaktır.

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += " , ";
                    }

                    fullName += FirstName;
                }


                return fullName;
            }
        }
        public static int InstanceCount { get; set; }


        private string _lastName;








        //static değiştirici sınıfın bir nesnesi yerine sınıfa ait olan bir üye bildirir.
        // static üyeler bir nesne değişkeni ile değil sınıf adı kullanılarak erişilir( customer.blabla) gibi...
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;


            }
        }

        //public string Log()
        //{
        //    var logString = CostumerID + " : " +
        //        FullName + " : " +
        //        "Email:" + EmailAddress + " : " +
        //        "status" + EntityState.ToString();
        //    return logString;
        //}
        public string Log() =>
           $"{CostumerID}:{FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
        public override string ToString() => FullName;


        public override bool Validate()
        {
            var isValid = true;
            if (!string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (!string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;

        }

     
    }

}

