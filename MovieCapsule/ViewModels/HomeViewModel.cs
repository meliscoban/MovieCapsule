using Microsoft.AspNetCore.Mvc.Rendering;
using MovieCapsule.Models;
using MovieCapsule.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCapsule.ViewModels
{
    public class HomeViewModel
    {
        public List<Movie> Movies { get; set; }

        public List<SelectListItem> Genres { get; set; }

        public int? SelectedGenreId { get; set; }
    }
}
