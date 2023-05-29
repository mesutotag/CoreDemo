using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //entityleri tek tek tanımlamak yerini butun entityler için IGenericDal tanımladık
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetListAll();
        T GetById(int id);
    }
}
