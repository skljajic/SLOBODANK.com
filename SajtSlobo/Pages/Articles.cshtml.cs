using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SajtSlobo.Pages
{
    public class ArticlesModel : PageModel
    {
        private readonly ILogger<ArticlesModel> _logger;

        public ArticlesModel(ILogger<ArticlesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
