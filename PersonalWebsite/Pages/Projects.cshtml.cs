using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PersonalWebsite.Pages
{
    public class ProjectsModel : PageModel
    {
        private readonly ILogger<AboutModel> _logger;
        public ProjectEntry[] projects = new ProjectEntry[3];

        public ProjectsModel(ILogger<AboutModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            projects[0] = new ProjectEntry("Spotify Playlist Analyzer",
                "Analyzes Spotify playlist attributes",
                new string[] { "awk", "html", "css" },
                "Spring 2020",
                "www.spotify.com");
            projects[1] = new ProjectEntry("Realm Tracker",
                "Tracker for multiple players' stats in Realm Royale",
                new string[] { "awk", "html", "css" },
                "Spring 2020",
                "www.realmtracker.com");
            projects[2] = new ProjectEntry("Vetris",
                "Game similar to Tetris using voice",
                new string[] { "javascript", "html" },
                "Spring 2020",
                "www.tetris.com");
        }
    }
}
