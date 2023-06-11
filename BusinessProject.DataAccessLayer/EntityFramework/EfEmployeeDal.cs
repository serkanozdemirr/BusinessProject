using BusinessProject.DataAccessLayer.Abstract;
using BusinessProject.DataAccessLayer.Concrete;
using BusinessProject.DataAccessLayer.Repositories;
using BusinessProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.DataAccessLayer.EntityFramework
{
    public class EfEmployeeDal : GenericRepository<Employee>, IEmployeeDal
    {
    }
}
