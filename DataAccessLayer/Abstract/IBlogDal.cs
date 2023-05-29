﻿using EntityLayer.Concrete;
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
        void AddCategory(Blog blog);
        void DeleteCategory(Blog blog);
        void UpdateCategory(Blog blog);

        Blog GetByİd(int id);

    }
}
