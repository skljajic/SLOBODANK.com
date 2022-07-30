using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SajtSlobo.Pages
{
    public class BiographyModel : PageModel
    {
        private readonly ILogger<BiographyModel> _logger;

        public BiographyModel(ILogger<BiographyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
