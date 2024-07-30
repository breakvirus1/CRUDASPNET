using System;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Birth.ViewModels
{
    public class PeopleViewModel
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public IFormFile ProfileImage { get; set; }
    }
}
