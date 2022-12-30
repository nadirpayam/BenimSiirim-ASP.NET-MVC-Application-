using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }

        public int CategoryID { get; set; } // PoetryCategory sınıfına foreign key bağlantısı için o sınıfın id'ini ekle

        public virtual PoetryCategories PCategory { get; set; } // bu satırı da ekleyince foreign key işlemi oluştu

        public ICollection<Poetry> _Poetry { get; set; }
    }
}
