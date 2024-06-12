using WebApplication1.Models;

namespace WebApplication1.Repo
{
    public class GenericRepo<type> where type : class
    {
           egydynamicsContext db;


            public GenericRepo(egydynamicsContext db)
            {
                this.db = db;
            }


            public List<type> selectall()
            {
                return db.Set<type>().ToList();
            }
        //------------------------------------------------------
            public type selectbyid(int id)
            {
               return db.Set<type>().Find(id);
            }

        //-----------------------------------------------
        public void add(type entity)
        {
            db.Set<type>().Add(entity);

        }


        //--------------------------------------------------

        public void update(type entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        //------------------------------------------------------
        public void delete(int id)
        {
            type obj = db.Set<type>().Find(id);
            db.Set<type>().Remove(obj);
        }

    }
}
