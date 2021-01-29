using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;

namespace BusinessLayer
{
    public static class AdminService
    {
        static IAdmin repository;
        static AdminService()
        {
            repository = new AdminRepository();

        }

        public static List<Admin> GetAll()
        {
            return repository.getAll();

        }

        public static Admin GetByUserName(string userName)
        {
            return repository.GetbyUserName(userName);

        }
        public static bool InsertAdmin(Admin ad)
        {
            return repository.InsertAdmin(ad);
        }

        public static bool DeleteAdmin(Admin ad)
        {
            return repository.DeleteAdmin(ad);
        }

        public static bool UpdateAdmin(Admin ad)
        {
            return repository.UpdateAdmin(ad);

        }
    }
}
