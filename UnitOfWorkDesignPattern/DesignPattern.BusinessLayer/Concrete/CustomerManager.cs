using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal customerDal;
        private readonly IUnitOfWorkDal unitOfWorkDal;

        public CustomerManager(ICustomerDal customerDal, IUnitOfWorkDal unitOfWorkDal)
        {
            this.customerDal = customerDal;
            this.unitOfWorkDal = unitOfWorkDal;
        }

        public void TDelete(Customer t)
        {
            customerDal.Delete(t);
            unitOfWorkDal.Save();
        }

        public Customer TGetByID(int id)
        {
            return customerDal.GetByID(id);
        }

        public List<Customer> TGetList()
        {
            return customerDal.GetList();
        }

        public void TInsert(Customer t)
        {
            customerDal.Insert(t);
            unitOfWorkDal.Save();
        }

        public void TMultiUpdate(List<Customer> t)
        {
            customerDal.MultiUpdate(t);
            unitOfWorkDal.Save();
        }

        public void TUpdate(Customer t)
        {
            customerDal.Update(t);
            unitOfWorkDal.Save();
        }
    }
}
