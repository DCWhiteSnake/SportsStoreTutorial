using System;

namespace SportsStore.Models.ViewModels
{
    // This view model is used to pass information
    // about the number of pages to the view model.
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        // This method uses the toal number of items to
        // get the total number of pages by some simple math.
        public int TotalPages =>
            (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
