using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ServiceReference1;
using wcfService;

namespace Razor.Pages
{
    public class PhotosModel : PageModel
    {
        public string[][] info;
        public void OnGet()
        {
           
        }
        public string[][] GetInfo()
        {
            Service1 service1 = new Service1();
            info = service1.GetDatabaseInfo();
            return info;
        }
    }
}