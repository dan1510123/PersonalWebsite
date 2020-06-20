using System;

namespace PersonalWebsite.Pages
{
    public class ProjectEntry
    {
        public string projectName;
        public string description;
        public string[] languages;
        public string timePeriod;
        public string link;
        public ProjectEntry(string projectName, string description,
            string[] languages, string timePeriod, string link)
        {
            this.projectName = projectName;
            this.description = description;
            this.languages = languages;
            this.timePeriod = timePeriod;
            this.link = link;
        }
    }
}
