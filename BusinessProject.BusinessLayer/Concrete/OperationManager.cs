using BusinessProject.BusinessLayer.Abstract;
using BusinessProject.DataAccessLayer.Abstract;
using BusinessProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.BusinessLayer.Concrete
{
    public class OperationManager : IOperationService
    {
        private readonly IOperationDal _operationDal;

        public OperationManager(IOperationDal operationDal)
        {
            _operationDal = operationDal;
        }

        public void TDelete(Operation t)
        {
            _operationDal.Delete(t);
        }

        public Operation TGetByID(int id)
        {
           return _operationDal.GetByID(id);
        }

        public List<Operation> TGetList()
        {
           return _operationDal.GetList();
        }

        public void TInsert(Operation t)
        {
            _operationDal.Insert(t);
        }

        public void TUpdate(Operation t)
        {
            _operationDal.Update(t);
        }
    }
}
