using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager  // STARBUCKS MERNİS DOĞRULAMA İSTİYOR
    {
        private ICustomerCheckService customerCheckService;
        private object _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            this.customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            throw new Exception("Not a valid person");
        }

       
    }
}
