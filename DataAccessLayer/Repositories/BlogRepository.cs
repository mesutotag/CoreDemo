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

        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Blog Blog)
        {
            using var c = new Context();
            c.Remove(Blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Blog GetByİd(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Blog Blog)
        {
            using var c = new Context();
            c.Update(Blog);
            c.SaveChanges();
        }
    }
}   
