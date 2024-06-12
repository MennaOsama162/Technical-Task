using WebApplication1.Models;
using WebApplication1.Repo;

namespace WebApplication1.UnitOfWork
{
    public class UnitWork
    {
        egydynamicsContext db;
        GenericRepo<Employee> employeeRepository;
       


        public UnitWork(egydynamicsContext db)
        {
            this.db = db;
        }

        public GenericRepo<Employee> EmployeeRepository
        {
            get
            {
                if (employeeRepository == null)
                {
                    employeeRepository = new GenericRepo<Employee>(db);
                }
                return employeeRepository;
            }
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

    }
}
