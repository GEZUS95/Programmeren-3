using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace ReservationSystemLogic
{
    public class CustomerService
    {
        CustomerDAO dao = new CustomerDAO();

        public List<Customer> GetAll()
        {
            return dao.GetAll();
        }

        public Customer GetById(int customerId)
        {
            return dao.GetById(customerId);
        }
    }
}
