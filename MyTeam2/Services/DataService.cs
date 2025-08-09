using MyTeam2.Models;
using MyTeam2.Services.Interfaces;

namespace MyTeam2.Services
{
    public class DataService : ITeamService
    {
        private readonly List<Site> _sites;
        private readonly List<Team> _teams;

        private const string LogoDirectoryPrefix = "";

        public DataService()
        {
            _sites = InitializeSites();
            _teams = InitializeTeamInfo();
        }

        public List<Team> GetAllTeamsInfo() => _teams;

        private List<Site> InitializeSites()
        {
            return new List<Site>
            {
                new Site
                {
                    SiteName = "AEK365",
                    BaseUrl = "https://www.aek365.org/",
                    TeamUrlLocator = "articles.php?id=10",
                    LogoPath = $"{LogoDirectoryPrefix}aek365.png",
                },
                new Site
                {
                    SiteName = "Contra",
                    BaseUrl = "http://www.contra.gr/",
                    TeamUrlLocator = "",
                    LogoPath = $"{LogoDirectoryPrefix}contra.png"
                },
                new Site
                {
                    SiteName = "Gazzetta",
                    BaseUrl = "https://www.gazzetta.gr/",
                    TeamUrlLocator = "teams/",
                    LogoPath = $"{LogoDirectoryPrefix}gazzetta.png"
                },
                new Site
                {
                    SiteName = "OnSports",
                    BaseUrl = "https://www.onsports.gr/",
                    TeamUrlLocator = "omades/",
                    LogoPath = $"{LogoDirectoryPrefix}onsports.png"
                },
                // TODO: Add more sites as needed...
            };
        }


        private List<Team> InitializeTeamInfo()
        {
            var teamInfo = new List<Team>();

            // AEK
            teamInfo.Add(new Team
            {
                Name = "aek",
                Label = "ΑΕΚ",
                Sites = new List<TeamSiteInfo>
                {
                    //new TeamSiteInfo { SiteName = "AEK365", Url = "https://www.aek365.org/articles.php?id=10" },
                    //new TeamSiteInfo { SiteName = "Contra", Url = "http://www.contra.gr/aek" },
                    //new TeamSiteInfo { SiteName = "Gazzetta", Url = "https://www.gazzetta.gr/teams/aek" },
                    //new TeamSiteInfo { SiteName = "NovaSports", Url = "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16673&languageID=1" },
                    //new TeamSiteInfo { SiteName = "OnSports", Url = "https://www.onsports.gr/omades/aek" },
                    //new TeamSiteInfo { SiteName = "SDNA", Url = "http://www.sdna.gr/teams/aek" },
                    //new TeamSiteInfo { SiteName = "Sport24", Url = "http://www.sport24.gr/football/omades/aek/?widget=rssfeed&view=feed&contentId=174866" },
                    //new TeamSiteInfo { SiteName = "SportFM", Url = "http://www.sport-fm.gr/tag/aek" },
                    //new TeamSiteInfo { SiteName = "SportDog", Url = "http://sportdog.gr/tag/ΑΕΚ" },
                    //new TeamSiteInfo { SiteName = "Sportime", Url = "http://www.sportime.gr/tag/aek/feed/" },
                    //new TeamSiteInfo { SiteName = "To10", Url = "https://www.to10.gr/team/aek/" },
                    //new TeamSiteInfo { SiteName = "A-sports", Url = "https://www.A-sports.gr/articles_categories-182/" },
                    //new TeamSiteInfo { SiteName = "Kingsport", Url = "https://www.kingsport.gr/category/super-league1/aek-fc/" },
                    new TeamSiteInfo
                    {
                        Site = _sites.First(s => s.SiteName == "AEK365")
                    },
                    new TeamSiteInfo
                    {
                        Site = _sites.First(s => s.SiteName == "Contra"),
                        TeamUrl = "aek"
                    },
                    new TeamSiteInfo
                    {
                        Site = _sites.First(s => s.SiteName == "Gazzetta"),
                        TeamUrl = "aek"
                    },
                    new TeamSiteInfo
                    {
                        Site = _sites.First(s => s.SiteName == "OnSports"),
                        TeamUrl = "aek"
                    },
                }
            });

            // Aris
            teamInfo.Add(new Team
            {
                Name = "aris",
                Label = "Άρης",
                Sites = new List<TeamSiteInfo>
                {
                    //new TeamSiteInfo { SiteName = "ArisFC", Url = "http://arisfc.com.gr/index.php/enimerosi?format=feed&type=rss" },
                    //new TeamSiteInfo { SiteName = "Contra", Url = "http://www.contra.gr/aris" },
                    //new TeamSiteInfo { SiteName = "Gazzetta", Url = "https://www.gazzetta.gr/teams/aris" },
                    //new TeamSiteInfo { SiteName = "NovaSports", Url = "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16817&languageID=1" },
                    //new TeamSiteInfo { SiteName = "OnSports", Url = "https://www.onsports.gr/omades/aris" },
                    //new TeamSiteInfo { SiteName = "Planetaris", Url = "https://planetaris.gr" },
                    //new TeamSiteInfo { SiteName = "SDNA", Url = "http://www.sdna.gr/teams/aris" },
                    //new TeamSiteInfo { SiteName = "Sport24", Url = "http://www.sport24.gr/football/omades/aris/?widget=rssfeed&view=feed&contentId=174866" },
                    //new TeamSiteInfo { SiteName = "SportFM", Url = "http://www.sport-fm.gr/tag/aris" },
                    //new TeamSiteInfo { SiteName = "Sportime", Url = "http://www.sportime.gr/tag/aris-fc/feed/" },
                    //new TeamSiteInfo { SiteName = "ThesSports", Url = "https://thessports.gr/category/soccer/αρησ/feed/" },
                    //new TeamSiteInfo { SiteName = "SportDog", Url = "http://sportdog.gr/tag/Αρης" },
                    //new TeamSiteInfo { SiteName = "AllAboutAris", Url = "https://allaboutaris.gr/roi-eidiseon/" },
                    //new TeamSiteInfo { SiteName = "PressAris", Url = "https://www.pressaris.gr/feed/" }
                }
            });

            // PAOK
            teamInfo.Add(new Team
            {
                Name = "paok",
                Label = "ΠΑΟΚ",
                Sites = new List<TeamSiteInfo>
                {
                    //new TeamSiteInfo { SiteName = "Contra", Url = "http://www.contra.gr/paok" },
                    //new TeamSiteInfo { SiteName = "Gazzetta", Url = "https://www.gazzetta.gr/teams/paok" },
                    //new TeamSiteInfo { SiteName = "InPAOK", Url = "https://inpaok.com/feed" },
                    //new TeamSiteInfo { SiteName = "NovaSports", Url = "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16657&languageID=1" },
                    //new TeamSiteInfo { SiteName = "OnSports", Url = "https://www.onsports.gr/omades/paok" },
                    //new TeamSiteInfo { SiteName = "PAOK24", Url = "https://www.paok24.com/roh" },
                    //new TeamSiteInfo { SiteName = "PAOKFC", Url = "https://www.paokfc.gr/category/nea/feed/" },
                    //new TeamSiteInfo { SiteName = "SDNA", Url = "http://www.sdna.gr/teams/paok" },
                    //new TeamSiteInfo { SiteName = "Sport24", Url = "http://www.sport24.gr/football/omades/paok/?widget=rssfeed&view=feed&contentId=174866" },
                    //new TeamSiteInfo { SiteName = "SportDog", Url = "http://sportdog.gr/tag/ΠΑΟΚ" },
                    //new TeamSiteInfo { SiteName = "SportFM", Url = "http://www.sport-fm.gr/tag/paok" },
                    //new TeamSiteInfo { SiteName = "Sportime", Url = "http://www.sportime.gr/tag/paok/feed/" },
                    //new TeamSiteInfo { SiteName = "ThesSports", Url = "https://thessports.gr/category/soccer/παοκ/feed/" },
                    //new TeamSiteInfo { SiteName = "To10", Url = "https://www.to10.gr/team/paok/" },
                    //new TeamSiteInfo { SiteName = "Metrosport", Url = "https://www.metrosport.gr/paok" },
                    //new TeamSiteInfo { SiteName = "A-sports", Url = "https://www.A-sports.gr/articles_categories-158/" },
                    //new TeamSiteInfo { SiteName = "Kingsport", Url = "https://www.kingsport.gr/category/super-league1/paok-fc/" }
                }
            });

            // Panathinaikos
            teamInfo.Add(new Team
            {
                Name = "panathinaikos",
                Label = "Παναθηναϊκός",
                Sites = new List<TeamSiteInfo>
                {
                    //new TeamSiteInfo { SiteName = "Contra", Url = "http://www.contra.gr/panathinaikos" },
                    //new TeamSiteInfo { SiteName = "Gazzetta", Url = "https://www.gazzetta.gr/teams/panathinaikos" },
                    //new TeamSiteInfo { SiteName = "NewsPAO", Url = "http://www.newsPAO.gr/feed/" },
                    //new TeamSiteInfo { SiteName = "NovaSports", Url = "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16625&languageID=1" },
                    //new TeamSiteInfo { SiteName = "OnSports", Url = "https://www.onsports.gr/omades/panathinaikos" },
                    //new TeamSiteInfo { SiteName = "SDNA", Url = "http://www.sdna.gr/teams/panathinaikos" },
                    //new TeamSiteInfo { SiteName = "Sport24", Url = "http://www.sport24.gr/football/omades/panathinaikos/?widget=rssfeed&view=feed&contentId=174866" },
                    //new TeamSiteInfo { SiteName = "SportFM", Url = "http://www.sport-fm.gr/tag/pao" },
                    //new TeamSiteInfo { SiteName = "Sportime", Url = "http://www.sportime.gr/tag/panathinaikos/feed/" },
                    //new TeamSiteInfo { SiteName = "SportDog", Url = "http://sportdog.gr/tag/Παναθηναϊκός" }
                }
            });

            // Osfp
            teamInfo.Add(new Team
            {
                Name = "osfp",
                Label = "Ολυμπιακός",
                Sites = new List<TeamSiteInfo>
                {
                    //new TeamSiteInfo { SiteName = "Contra", Url = "http://www.contra.gr/olympiacos" },
                    //new TeamSiteInfo { SiteName = "Gavros", Url = "https://www.gavros.gr/timeline/" },
                    //new TeamSiteInfo { SiteName = "Gazzetta", Url = "https://www.gazzetta.gr/teams/olympiacos" },
                    //new TeamSiteInfo { SiteName = "NovaSports", Url = "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16641&languageID=1" },
                    //new TeamSiteInfo { SiteName = "OlympiacosFC", Url = "https://www.olympiacos.org/all-news/" },
                    //new TeamSiteInfo { SiteName = "OnSports", Url = "https://www.onsports.gr/omades/olympiakos" },
                    //new TeamSiteInfo { SiteName = "SDNA", Url = "http://www.sdna.gr/teams/olympiakos" },
                    //new TeamSiteInfo { SiteName = "Sport24", Url = "http://www.sport24.gr/football/omades/olympiakos/?widget=rssfeed&view=feed&contentId=174866" },
                    //new TeamSiteInfo { SiteName = "SportFM", Url = "http://www.sport-fm.gr/tag/olympiakos" },
                    //new TeamSiteInfo { SiteName = "Sportime", Url = "http://www.sportime.gr/tag/olympiakos/feed/" },
                    //new TeamSiteInfo { SiteName = "SportDog", Url = "http://sportdog.gr/tag/Ολυμπιακός" }
                }
            });

            return teamInfo;
        }
    }
}
