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
    
    public partial class Cart
    {
        public int Id_cart { get; set; }
        public int id_comic { get; set; }
        public int id_user { get; set; }
        public string status_cart { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public System.DateTime Date { get; set; }
    }
}
