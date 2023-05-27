using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal
    {

        List<Blog> ListAllBlog();
        void AddCategory(Blog category);
        void DeleteCategory(Blog category);
        void UpdateCategory(Blog category);

        Blog GetByİd(int id);

    }
}
