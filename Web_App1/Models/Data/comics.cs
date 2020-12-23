using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_App1.Models.Data
{
    [Table("comics")]
    public class comics
    {
        [Key]
        public int Id_comic { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Artist { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Cover { get; set; }
        public short Pages { get; set; }
        public short Year { get; set; }
        public string ISBN { get; set; }
        public decimal Old_Price { get; set; }
        public decimal New_Price { get; set; }
        public string Image { get; set; }
        public Nullable<short> Quantity { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string Slug { get; set; }

        //[ForeignKey("CategoryId")]
       // public virtual CategoryDTO Category { get; set; }

    }        
}