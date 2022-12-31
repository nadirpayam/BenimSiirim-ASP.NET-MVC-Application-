using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    interface ICategoryDal
    {
        //CRUD
        List<PoetryCategories> List();

        void Insert(PoetryCategories categories);

        void Update(PoetryCategories categories);

        void Delete(PoetryCategories categories);
    }
}
