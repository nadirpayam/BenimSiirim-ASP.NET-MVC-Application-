using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<PoetryCategories> _object;
        public void Delete(PoetryCategories categories)
        {
            _object.Remove(categories);
            c.SaveChanges();
        }

        public void Insert(PoetryCategories categories)
        {
            _object.Add(categories);
            c.SaveChanges();
        }

        public List<PoetryCategories> List()
        {
            return _object.ToList(); // verileri listeler
        }

        public void Update(PoetryCategories categories)
        {
            c.SaveChanges();
        }
    }
}
