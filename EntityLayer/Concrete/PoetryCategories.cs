using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PoetryCategories
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(20)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; } // ilişkili tablolarda silme işlemi kullanmayız durumu aktif veya pasif yapma işlemi kullanırız

        public ICollection<Heading> Headings { get; set; } // foreign key işlemlerine başlangıç
    } 
}
