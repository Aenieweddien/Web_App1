//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_App1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class comics
    {
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
        public Nullable<float> Old_Price { get; set; }
        public Nullable<float> New_Price { get; set; }
        public string Image { get; set; }
        public Nullable<short> Quantity { get; set; }
    }
}
