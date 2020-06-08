using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PersonalWebsite.Pages
{
    public class ConstructionModel : PageModel
    {
        private readonly ILogger<ConstructionModel> _logger;
        public string PageType;

        public ConstructionModel(ILogger<ConstructionModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string pagetype)
        {
            PageType = pagetype;
        }
    }
}
