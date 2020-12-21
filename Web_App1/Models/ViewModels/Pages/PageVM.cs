using Web_App1.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_App1.Models.ViewModels.Pages
{
    public class PageVM
    {
        public PageVM()
        {

        }

        public PageVM(PagesDTO row)
        {
            Id_comic = row.Id_comic;
            Title = row.Title;
            Publisher = row.Publisher;
            Artist = row.Artist;
            Author = row.Author;
            Genre = row.Genre;
            Language = row.Language;
            Cover = row.Cover;
            Pages = row.Pages;
            Year = row.Year;
            ISBN = row.ISBN;
            Old_Price = row.Old_Price;
            New_Price = row.New_Price;
            Image = row.Image;
            Quantity = row.Quantity;
            Description = row.Description;
        }

        public int Id_comic { get; set; }
       // [Required]
        //[StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        //[Required]
        //[StringLength(int.MaxValue, MinimumLength = 3)]
        //[AllowHtml]
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
        public string Description { get; set; }

    }

}