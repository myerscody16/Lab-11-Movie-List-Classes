using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab11_Movie_List
{
    class Movie
    {
        #region Fields
        private string Title { get; set; }
        private string Category { get; set; }
        #endregion
        #region Constructors
        public Movie(string title, string category)
        {
            this.Title = title;
            this.Category = category;
        }
        public string GetTitle()//allows for the use of private variables across classes
        {
            return this.Title;
        }
        public string GetCategory()//allows for the use of private variables across classes
        {
            return this.Category;
        }
        #endregion
    }
}