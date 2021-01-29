using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
  public  interface IAdmin
    {
        List<Admin> getAll();

        Admin  GetbyUserName(string username);

        bool InsertAdmin(Admin ad);

        bool UpdateAdmin(Admin ad);

        bool DeleteAdmin(Admin ad);

    }
}
