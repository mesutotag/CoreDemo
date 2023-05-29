using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {


        public void AddCategory(Blog Blog)
        {
            using var c = new Context();
            c.Add(Blog);
            c.SaveChanges();
        }

        public void DeleteCategory(Blog Blog)
        {
            using var c = new Context();
            c.Remove(Blog);
            c.SaveChanges();
        }

        public Blog GetByİd(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public void UpdateCategory(Blog Blog)
        {
            using var c = new Context();
            c.Update(Blog);
            c.SaveChanges();
        }
    }
}   
