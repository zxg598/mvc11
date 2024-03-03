using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        /// <summary>
        /// 流派列表
        /// </summary>
        public SelectList? Genres { get; set; } 
        /// <summary>
        /// 所选电影流派
        /// </summary>
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
