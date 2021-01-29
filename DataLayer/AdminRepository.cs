using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace DataLayer
{
    public class AdminRepository : IAdmin
    {
     public bool DeleteAdmin(Admin ad)
        {
            using (AdminEntities db = new AdminEntities())
            {
                db.Admins.Attach(ad);
                db.Admins.Remove(ad);
                int  a=  db.SaveChanges();
                return a > 0;

            }
        }

        public List<Admin> getAll()
        {
            using (AdminEntities db = new AdminEntities())
            {
                return db.Admins.ToList();


            }
        }

       public Admin GetbyUserName(string username)
        {
            using (AdminEntities db = new AdminEntities())
            {
                return db.Admins.Find(username);

            }
        }

       public bool InsertAdmin(Admin ad)
        {
            using (AdminEntities db = new AdminEntities())
            {
                
                db.Admins.Add(ad);
                int row=  db.SaveChanges();
                return row > 0;

            }
        }

        public bool UpdateAdmin(Admin ad)
        {
            using (AdminEntities db = new AdminEntities())
            {
                db.Admins.Attach(ad);
                db.Entry(ad).State = System.Data.Entity.EntityState.Modified;
                int row=db.SaveChanges();
                return row > 0;
            }
        }
    }
}
