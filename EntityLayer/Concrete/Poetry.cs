using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Poetry
    {
        [Key]
        public int PoemID { get; set; }
        [StringLength(1000)]
        public string Poem { get; set; }
       
        public DateTime PoemDate { get; set; }

        public int HeadingID { get; set; }

        public virtual Heading heading { get; set; }

        public int WriterID { get; set; }
        public virtual Writer writer { get; set; }
    }
}
