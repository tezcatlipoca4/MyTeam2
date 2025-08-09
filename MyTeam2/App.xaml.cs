using MyTeam2.Models.MyTeam2.Models;
using System.Data;

namespace MyTeam2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var teamInfo = InitializeTeamInfo();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }

        private List<TeamInfo> InitializeTeamInfo()
        {
            var teamInfo = new List<TeamInfo>();

            teamInfo.Add(new TeamInfo
            {
                TeamName = "aek",
                TeamLabel = "ΑΕΚ",
                Sites = new List<TeamSiteInfo>
                {
                    new TeamSiteInfo { SiteName = "AEK365", Url = "https://www.aek365.org/articles.php?id=10" },
                    new TeamSiteInfo { SiteName = "Contra", Url = "http://www.contra.gr/aek" },
                    new TeamSiteInfo { SiteName = "Gazzetta", Url = "https://www.gazzetta.gr/teams/aek" },
                    new TeamSiteInfo { SiteName = "NovaSports", Url = "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16673&languageID=1" },
                    new TeamSiteInfo { SiteName = "OnSports", Url = "https://www.onsports.gr/omades/aek" },
                    new TeamSiteInfo { SiteName = "SDNA", Url = "http://www.sdna.gr/teams/aek" },
                    new TeamSiteInfo { SiteName = "Sport24", Url = "http://www.sport24.gr/football/omades/aek/?widget=rssfeed&view=feed&contentId=174866" },
                    new TeamSiteInfo { SiteName = "SportFM", Url = "http://www.sport-fm.gr/tag/aek" },
                    new TeamSiteInfo { SiteName = "SportDog", Url = "http://sportdog.gr/tag/ΑΕΚ" },
                    new TeamSiteInfo { SiteName = "Sportime", Url = "http://www.sportime.gr/tag/aek/feed/" },
                    new TeamSiteInfo { SiteName = "To10", Url = "https://www.to10.gr/team/aek/" },
                    new TeamSiteInfo { SiteName = "A-sports", Url = "https://www.A-sports.gr/articles_categories-182/" },
                    new TeamSiteInfo { SiteName = "Kingsport", Url = "https://www.kingsport.gr/category/super-league1/aek-fc/" },
                }
            });

            teamInfo.Add(new TeamInfo
            {
                TeamName = "aris",
                TeamLabel = "Άρης",
                Sites = new List<TeamSiteInfo>
                {
                    new TeamSiteInfo { SiteName = "ArisFC", Url = "http://arisfc.com.gr/index.php/enimerosi?format=feed&type=rss" },
                    new TeamSiteInfo { SiteName = "Contra", Url = "http://www.contra.gr/aris" },
                    new TeamSiteInfo { SiteName = "Gazzetta", Url = "https://www.gazzetta.gr/teams/aris" },
                    new TeamSiteInfo { SiteName = "NovaSports", Url = "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16817&languageID=1" },
                    new TeamSiteInfo { SiteName = "OnSports", Url = "https://www.onsports.gr/omades/aris" },
                    new TeamSiteInfo { SiteName = "Planetaris", Url = "https://planetaris.gr" },
                    new TeamSiteInfo { SiteName = "SDNA", Url = "http://www.sdna.gr/teams/aris" },
                    new TeamSiteInfo { SiteName = "Sport24", Url = "http://www.sport24.gr/football/omades/aris/?widget=rssfeed&view=feed&contentId=174866" },
                    new TeamSiteInfo { SiteName = "SportFM", Url = "http://www.sport-fm.gr/tag/aris" },
                    new TeamSiteInfo { SiteName = "Sportime", Url = "http://www.sportime.gr/tag/aris-fc/feed/" },
                    new TeamSiteInfo { SiteName = "ThesSports", Url = "https://thessports.gr/category/soccer/αρησ/feed/" },
                    new TeamSiteInfo { SiteName = "SportDog", Url = "http://sportdog.gr/tag/Αρης" },
                    new TeamSiteInfo { SiteName = "AllAboutAris", Url = "https://allaboutaris.gr/roi-eidiseon/" },
                    new TeamSiteInfo { SiteName = "PressAris", Url = "https://www.pressaris.gr/feed/" }
                }
            });

            teamInfo.Add(new TeamInfo
            {
                TeamName = "paok",
                TeamLabel = "ΠΑΟΚ",
                Sites = new List<TeamSiteInfo>
                {
                    new TeamSiteInfo { SiteName = "Contra", Url = "http://www.contra.gr/paok" },
                    new TeamSiteInfo { SiteName = "Gazzetta", Url = "https://www.gazzetta.gr/teams/paok" },
                    new TeamSiteInfo { SiteName = "InPAOK", Url = "https://inpaok.com/feed" },
                    new TeamSiteInfo { SiteName = "NovaSports", Url = "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16657&languageID=1" },
                    new TeamSiteInfo { SiteName = "OnSports", Url = "https://www.onsports.gr/omades/paok" },
                    new TeamSiteInfo { SiteName = "PAOK24", Url = "https://www.paok24.com/roh" },
                    new TeamSiteInfo { SiteName = "PAOKFC", Url = "https://www.paokfc.gr/category/nea/feed/" },
                    new TeamSiteInfo { SiteName = "SDNA", Url = "http://www.sdna.gr/teams/paok" },
                    new TeamSiteInfo { SiteName = "Sport24", Url = "http://www.sport24.gr/football/omades/paok/?widget=rssfeed&view=feed&contentId=174866" },
                    new TeamSiteInfo { SiteName = "SportDog", Url = "http://sportdog.gr/tag/ΠΑΟΚ" },
                    new TeamSiteInfo { SiteName = "SportFM", Url = "http://www.sport-fm.gr/tag/paok" },
                    new TeamSiteInfo { SiteName = "Sportime", Url = "http://www.sportime.gr/tag/paok/feed/" },
                    new TeamSiteInfo { SiteName = "ThesSports", Url = "https://thessports.gr/category/soccer/παοκ/feed/" },
                    new TeamSiteInfo { SiteName = "To10", Url = "https://www.to10.gr/team/paok/" },
                    new TeamSiteInfo { SiteName = "Metrosport", Url = "https://www.metrosport.gr/paok" },
                    new TeamSiteInfo { SiteName = "A-sports", Url = "https://www.A-sports.gr/articles_categories-158/" },
                    new TeamSiteInfo { SiteName = "Kingsport", Url = "https://www.kingsport.gr/category/super-league1/paok-fc/" }
                }
            });

            teamInfo.Add(new TeamInfo
            {
                TeamName = "panathinaikos",
                TeamLabel = "Παναθηναϊκός",
                Sites = new List<TeamSiteInfo>
                {
                    new TeamSiteInfo { SiteName = "Contra", Url = "http://www.contra.gr/panathinaikos" },
                    new TeamSiteInfo { SiteName = "Gazzetta", Url = "https://www.gazzetta.gr/teams/panathinaikos" },
                    new TeamSiteInfo { SiteName = "NewsPAO", Url = "http://www.newsPAO.gr/feed/" },
                    new TeamSiteInfo { SiteName = "NovaSports", Url = "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16625&languageID=1" },
                    new TeamSiteInfo { SiteName = "OnSports", Url = "https://www.onsports.gr/omades/panathinaikos" },
                    new TeamSiteInfo { SiteName = "SDNA", Url = "http://www.sdna.gr/teams/panathinaikos" },
                    new TeamSiteInfo { SiteName = "Sport24", Url = "http://www.sport24.gr/football/omades/panathinaikos/?widget=rssfeed&view=feed&contentId=174866" },
                    new TeamSiteInfo { SiteName = "SportFM", Url = "http://www.sport-fm.gr/tag/pao" },
                    new TeamSiteInfo { SiteName = "Sportime", Url = "http://www.sportime.gr/tag/panathinaikos/feed/" },
                    new TeamSiteInfo { SiteName = "SportDog", Url = "http://sportdog.gr/tag/Παναθηναϊκός" }
                }
            });

            teamInfo.Add(new TeamInfo
            {
                TeamName = "osfp",
                TeamLabel = "Ολυμπιακός",
                Sites = new List<TeamSiteInfo>
                {
                    new TeamSiteInfo { SiteName = "Contra", Url = "http://www.contra.gr/olympiacos" },
                    new TeamSiteInfo { SiteName = "Gavros", Url = "https://www.gavros.gr/timeline/" },
                    new TeamSiteInfo { SiteName = "Gazzetta", Url = "https://www.gazzetta.gr/teams/olympiacos" },
                    new TeamSiteInfo { SiteName = "NovaSports", Url = "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16641&languageID=1" },
                    new TeamSiteInfo { SiteName = "OlympiacosFC", Url = "https://www.olympiacos.org/all-news/" },
                    new TeamSiteInfo { SiteName = "OnSports", Url = "https://www.onsports.gr/omades/olympiakos" },
                    new TeamSiteInfo { SiteName = "SDNA", Url = "http://www.sdna.gr/teams/olympiakos" },
                    new TeamSiteInfo { SiteName = "Sport24", Url = "http://www.sport24.gr/football/omades/olympiakos/?widget=rssfeed&view=feed&contentId=174866" },
                    new TeamSiteInfo { SiteName = "SportFM", Url = "http://www.sport-fm.gr/tag/olympiakos" },
                    new TeamSiteInfo { SiteName = "Sportime", Url = "http://www.sportime.gr/tag/olympiakos/feed/" },
                    new TeamSiteInfo { SiteName = "SportDog", Url = "http://sportdog.gr/tag/Ολυμπιακός" }
                }
            });

            return teamInfo;
        }
        
        //Δημιουργία πίνακα με τις πληροφορίες και τα url των ιστοσελίδων
        //private void FillTeamInfoDataTable(DataTable table)
        //{
        //    //Σε περίπτωση που ο χρήστης βγήκε με την χρήση του back button δεν χρειάζεται να τρέξουμε ξανά την μέθοδο τα στοιχεία υπάρχουν ήδη
        //    if (table.Rows.Count > 0) return;

        //    table.Columns.Add("teamName", typeof(string));
        //    table.Columns.Add("teamLabel", typeof(string));
        //    table.Columns.Add("siteName", typeof(string));
        //    table.Columns.Add("rssType", typeof(string));
        //    table.Columns.Add("url", typeof(string));

        //    // AEK
        //    table.Rows.Add("aek", "ΑΕΚ", "AEK365", "Html", "https://www.aek365.org/articles.php?id=10");
        //    table.Rows.Add("aek", "ΑΕΚ", "Contra", "Html", "http://www.contra.gr/aek");
        //    table.Rows.Add("aek", "ΑΕΚ", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/aek");
        //    table.Rows.Add("aek", "ΑΕΚ", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16673&languageID=1");
        //    table.Rows.Add("aek", "ΑΕΚ", "OnSports", "Html", "https://www.onsports.gr/omades/aek");
        //    table.Rows.Add("aek", "ΑΕΚ", "SDNA", "Html", "http://www.sdna.gr/teams/aek");
        //    table.Rows.Add("aek", "ΑΕΚ", "Sport24", "Html", "http://www.sport24.gr/football/omades/aek/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("aek", "ΑΕΚ", "SportFM", "Html", "http://www.sport-fm.gr/tag/aek");
        //    table.Rows.Add("aek", "ΑΕΚ", "SportDog", "Html", "http://sportdog.gr/tag/ΑΕΚ");
        //    table.Rows.Add("aek", "ΑΕΚ", "Sportime", "RSS", "http://www.sportime.gr/tag/aek/feed/");

        //    // ARIS
        //    table.Rows.Add("aris", "Άρης", "ArisFC", "RSS", "http://arisfc.com.gr/index.php/enimerosi?format=feed&type=rss");
        //    table.Rows.Add("aris", "Άρης", "Contra", "Html", "http://www.contra.gr/aris");
        //    table.Rows.Add("aris", "Άρης", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/aris");
        //    table.Rows.Add("aris", "Άρης", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16817&languageID=1");
        //    table.Rows.Add("aris", "Άρης", "OnSports", "Html", "https://www.onsports.gr/omades/aris");
        //    table.Rows.Add("aris", "Άρης", "Planetaris", "Html", "https://planetaris.gr");
        //    table.Rows.Add("aris", "Άρης", "SDNA", "Html", "http://www.sdna.gr/teams/aris");
        //    table.Rows.Add("aris", "Άρης", "Sport24", "Html", "http://www.sport24.gr/football/omades/aris/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("aris", "Άρης", "SportFM", "Html", "http://www.sport-fm.gr/tag/aris");
        //    table.Rows.Add("aris", "Άρης", "Sportime", "RSS", "http://www.sportime.gr/tag/aris-fc/feed/");
        //    table.Rows.Add("aris", "Άρης", "ThesSports", "Html", "https://thessports.gr/category/soccer/αρησ/feed/");
        //    table.Rows.Add("aris", "Άρης", "SportDog", "Html", "http://sportdog.gr/tag/Αρης");

        //    //1.4
        //    table.Rows.Add("aris", "Άρης", "AllAboutAris", "Html", "https://allaboutaris.gr/roi-eidiseon/");
        //    table.Rows.Add("aris", "Άρης", "PressAris", "Html", "https://www.pressaris.gr/feed/");



        //    // ATROMITOS
        //    table.Rows.Add("atromitos", "Ατρόμητος", "AtromitosFC", "RSS", "http://www.atromitosfc.gr/el/news-el/news-el.feed?type=rss");
        //    table.Rows.Add("atromitos", "Ατρόμητος", "Contra", "Html", "http://www.contra.gr/atromitos");
        //    table.Rows.Add("atromitos", "Ατρόμητος", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/atromitos-athinon");
        //    table.Rows.Add("atromitos", "Ατρόμητος", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=17073&languageID=1");
        //    table.Rows.Add("atromitos", "Ατρόμητος", "OnSports", "Html", "https://www.onsports.gr/omades/atromitos");
        //    table.Rows.Add("atromitos", "Ατρόμητος", "SDNA", "Html", "http://www.sdna.gr/teams/atromitos/podosfairo");
        //    table.Rows.Add("atromitos", "Ατρόμητος", "Sport24", "Html", "http://www.sport24.gr/football/omades/Atromitos/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("atromitos", "Ατρόμητος", "SportFM", "Html", "http://www.sport-fm.gr/tag/atromitos");
        //    table.Rows.Add("atromitos", "Ατρόμητος", "Sportime", "RSS", "http://www.sportime.gr/tag/atromitos-athinon/feed/");
        //    table.Rows.Add("atromitos", "Ατρόμητος", "SportDog", "Html", "http://sportdog.gr/tag/Ατρόμητος");

        //    // GENERAL
        //    //table.Rows.Add("general", "Γενικές Ειδήσεις", "Contra", "Html", "http://www.contra.gr/latest/?widget=rssfeed&view=feed&contentId=1169269");
        //    table.Rows.Add("general", "Γενικές Ειδήσεις", "Gazzetta", "Html", "https://www.gazzetta.gr/latest-news");
        //    table.Rows.Add("general", "Γενικές Ειδήσεις", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=999&id=1&languageID=1");
        //    table.Rows.Add("general", "Γενικές Ειδήσεις", "OnSports", "RSS", "https://www.onsports.gr/latest-news?format=feed");
        //    table.Rows.Add("general", "Γενικές Ειδήσεις", "SDNA", "RSS", "http://www.sdna.gr/news");
        //    table.Rows.Add("general", "Γενικές Ειδήσεις", "Sport24", "Html", "http://www.sport24.gr/latest/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("general", "Γενικές Ειδήσεις", "SportFM", "Html", "http://www.sport-fm.gr/archive/latest/");
        //    table.Rows.Add("general", "Γενικές Ειδήσεις", "Sportime", "RSS", "http://www.sportime.gr/feed/");
        //    table.Rows.Add("general", "Γενικές Ειδήσεις", "SportDog", "Html", "http://sportdog.gr/latest");

        //    // IRAKLIS
        //    table.Rows.Add("iraklis", "Ηρακλής", "Contra", "Html", "http://www.contra.gr/iraklis");
        //    table.Rows.Add("iraklis", "Ηρακλής", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/iraklis");
        //    table.Rows.Add("iraklis", "Ηρακλής", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16737&languageID=1");
        //    table.Rows.Add("iraklis", "Ηρακλής", "OnSports", "Html", "https://www.onsports.gr/omades/iraklis");
        //    table.Rows.Add("iraklis", "Ηρακλής", "SDNA", "Html", "http://www.sdna.gr/teams/iraklis");
        //    table.Rows.Add("iraklis", "Ηρακλής", "Sport24", "Html", "http://www.sport24.gr/football/omades/iraklis/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("iraklis", "Ηρακλής", "SportFM", "Html", "http://www.sport-fm.gr/tag/iraklis");
        //    table.Rows.Add("iraklis", "Ηρακλής", "Sportime", "RSS", "http://www.sportime.gr/tag/iraklis/feed/");
        //    table.Rows.Add("iraklis", "Ηρακλής", "SportDog", "Html", "http://sportdog.gr/tag/iraklis");
        //    table.Rows.Add("iraklis", "Ηρακλής", "ThesSports", "Html", "https://thessports.gr/category/soccer/ηρακλησ/feed/");


        //    // OSFP
        //    table.Rows.Add("osfp", "Ολυμπιακός", "Contra", "Html", "http://www.contra.gr/olympiacos");
        //    table.Rows.Add("osfp", "Ολυμπιακός", "Gavros", "Html", "https://www.gavros.gr/timeline/");
        //    table.Rows.Add("osfp", "Ολυμπιακός", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/olympiacos");
        //    table.Rows.Add("osfp", "Ολυμπιακός", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16641&languageID=1");
        //    table.Rows.Add("osfp", "Ολυμπιακός", "OlympiacosFC", "Html", "https://www.olympiacos.org/all-news/");
        //    table.Rows.Add("osfp", "Ολυμπιακός", "OnSports", "Html", "https://www.onsports.gr/omades/olympiakos");
        //    table.Rows.Add("osfp", "Ολυμπιακός", "SDNA", "Html", "http://www.sdna.gr/teams/olympiakos");
        //    table.Rows.Add("osfp", "Ολυμπιακός", "Sport24", "Html", "http://www.sport24.gr/football/omades/olympiakos/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("osfp", "Ολυμπιακός", "SportFM", "Html", "http://www.sport-fm.gr/tag/olympiakos");
        //    table.Rows.Add("osfp", "Ολυμπιακός", "Sportime", "RSS", "http://www.sportime.gr/tag/olympiakos/feed/");
        //    table.Rows.Add("osfp", "Ολυμπιακός", "SportDog", "Html", "http://sportdog.gr/tag/Ολυμπιακός");


        //    // PANATHINAIKOS
        //    table.Rows.Add("panathinaikos", "Παναθηναϊκός", "Contra", "Html", "http://www.contra.gr/panathinaikos");
        //    table.Rows.Add("panathinaikos", "Παναθηναϊκός", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/panathinaikos");
        //    table.Rows.Add("panathinaikos", "Παναθηναϊκός", "NewsPAO", "RSS", "http://www.newsPAO.gr/feed/");
        //    table.Rows.Add("panathinaikos", "Παναθηναϊκός", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16625&languageID=1");
        //    table.Rows.Add("panathinaikos", "Παναθηναϊκός", "OnSports", "Html", "https://www.onsports.gr/omades/panathinaikos");
        //    table.Rows.Add("panathinaikos", "Παναθηναϊκός", "SDNA", "Html", "http://www.sdna.gr/teams/panathinaikos");
        //    table.Rows.Add("panathinaikos", "Παναθηναϊκός", "Sport24", "Html", "http://www.sport24.gr/football/omades/panathinaikos/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("panathinaikos", "Παναθηναϊκός", "SportFM", "Html", "http://www.sport-fm.gr/tag/pao");
        //    table.Rows.Add("panathinaikos", "Παναθηναϊκός", "Sportime", "RSS", "http://www.sportime.gr/tag/panathinaikos/feed/");
        //    table.Rows.Add("panathinaikos", "Παναθηναϊκός", "SportDog", "Html", "http://sportdog.gr/tag/Παναθηναϊκός");


        //    // PAOK
        //    table.Rows.Add("paok", "ΠΑΟΚ", "Contra", "Html", "http://www.contra.gr/paok");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/paok");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "InPAOK", "RSS", "https://inpaok.com/feed");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16657&languageID=1");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "OnSports", "Html", "https://www.onsports.gr/omades/paok");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "PAOK24", "Html", "https://www.paok24.com/roh");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "PAOKFC", "RSS", "https://www.paokfc.gr/category/nea/feed/");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "SDNA", "Html", "http://www.sdna.gr/teams/paok");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "Sport24", "Html", "http://www.sport24.gr/football/omades/paok/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "SportDog", "Html", "http://sportdog.gr/tag/ΠΑΟΚ");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "SportFM", "Html", "http://www.sport-fm.gr/tag/paok");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "Sportime", "RSS", "http://www.sportime.gr/tag/paok/feed/");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "ThesSports", "Html", "https://thessports.gr/category/soccer/παοκ/feed/");


        //    // PANIONIOS 1.1
        //    table.Rows.Add("panionios", "Πανιώνιος", "Contra", "Html", "http://www.contra.gr/panionios");
        //    table.Rows.Add("panionios", "Πανιώνιος", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/panionios");
        //    table.Rows.Add("panionios", "Πανιώνιος", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16705&languageID=1");
        //    table.Rows.Add("panionios", "Πανιώνιος", "SDNA", "Html", "http://www.sdna.gr/teams/panionios");
        //    table.Rows.Add("panionios", "Πανιώνιος", "OnSports", "Html", "https://www.onsports.gr/omades/panionios");
        //    table.Rows.Add("panionios", "Πανιώνιος", "PanioniaIdea", "RSS", "https://panionia-idea.gr/feed/");
        //    table.Rows.Add("panionios", "Πανιώνιος", "PanioniosFC", "RSS", "https://www.panioniosfc.gr/feed/");
        //    table.Rows.Add("panionios", "Πανιώνιος", "Sport24", "Html", "http://www.sport24.gr/football/omades/panionios/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("panionios", "Πανιώνιος", "SportDog", "Html", "http://sportdog.gr/tag/Πανιώνιος");
        //    table.Rows.Add("panionios", "Πανιώνιος", "SportFM", "Html", "http://www.sport-fm.gr/tag/panionios");
        //    table.Rows.Add("panionios", "Πανιώνιος", "Sportime", "RSS", "http://www.sportime.gr/tag/panionios/feed/");


        //    // AEL 1.1
        //    table.Rows.Add("ael", "ΑΕΛ", "AELole", "RSS", "http://www.aelole.gr/feeds/posts/default?alt=rss");
        //    table.Rows.Add("ael", "ΑΕΛ", "Contra", "Html", "http://www.contra.gr/ael");
        //    table.Rows.Add("ael", "ΑΕΛ", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/ael");
        //    table.Rows.Add("ael", "ΑΕΛ", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=17137&languageID=1");
        //    table.Rows.Add("ael", "ΑΕΛ", "OnSports", "Html", "https://www.onsports.gr/omades/larisa");
        //    table.Rows.Add("ael", "ΑΕΛ", "SDNA", "Html", "http://www.sdna.gr/teams/ael/podosfairo");
        //    table.Rows.Add("ael", "ΑΕΛ", "Sport24", "Html", "http://www.sport24.gr/football/omades/ael/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("ael", "ΑΕΛ", "SportDog", "Html", "http://sportdog.gr/tag/ΑΕΛ");
        //    table.Rows.Add("ael", "ΑΕΛ", "SportFM", "Html", "http://www.sport-fm.gr/tag/larisa");
        //    table.Rows.Add("ael", "ΑΕΛ", "Sportime", "RSS", "http://www.sportime.gr/tag/ael/feed/");


        //    // XANTHI 1.1
        //    //table.Rows.Add("xanthi", "Ξάνθη", "Contra", "Html", "http://www.contra.gr/ksanthi/?widget=rssfeed&view=feed");
        //    table.Rows.Add("xanthi", "Ξάνθη", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/xanthi");
        //    table.Rows.Add("xanthi", "Ξάνθη", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16753&languageID=1");
        //    table.Rows.Add("xanthi", "Ξάνθη", "OnSports", "Html", "https://www.onsports.gr/omades/ksanthi");
        //    table.Rows.Add("xanthi", "Ξάνθη", "SDNA", "Html", "http://www.sdna.gr/teams/xanthi/podosfairo");
        //    table.Rows.Add("xanthi", "Ξάνθη", "Sport24", "Html", "http://www.sport24.gr/football/omades/skodaxanthi/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("xanthi", "Ξάνθη", "SportDog", "Html", "http://sportdog.gr/tag/Ξάνθη");
        //    table.Rows.Add("xanthi", "Ξάνθη", "SportFM", "Html", "http://www.sport-fm.gr/tag/xanthi");
        //    table.Rows.Add("xanthi", "Ξάνθη", "Sportime", "RSS", "http://www.sportime.gr/tag/xanthi/feed/");
        //    table.Rows.Add("xanthi", "Ξάνθη", "SportsAddict", "Html", "https://sportsaddict.gr/tag/ao-xanthi/");
        //    table.Rows.Add("xanthi", "Ξάνθη", "XanthiSport", "RSS", "http://xanthi-sport.gr/category/xanthi-fc/feed/");

        //    // OFI 1.1
        //    table.Rows.Add("ofi", "ΟΦΗ", "Contra", "Html", "http://www.contra.gr/ofi");
        //    table.Rows.Add("ofi", "ΟΦΗ", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/ofi");
        //    table.Rows.Add("ofi", "ΟΦΗ", "Gentikoule", "RSS", "https://www.gentikoule.gr/feed");
        //    table.Rows.Add("ofi", "ΟΦΗ", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16769&languageID=1");
        //    table.Rows.Add("ofi", "ΟΦΗ", "OnSports", "Html", "https://www.onsports.gr/omades/ofi");
        //    table.Rows.Add("ofi", "ΟΦΗ", "SDNA", "Html", "http://www.sdna.gr/teams/ofi/podosfairo");
        //    table.Rows.Add("ofi", "ΟΦΗ", "Sport24", "Html", "http://www.sport24.gr/football/omades/ofi/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("ofi", "ΟΦΗ", "SportDog", "Html", "http://sportdog.gr/tag/ΟΦΗ");
        //    table.Rows.Add("ofi", "ΟΦΗ", "SportFM", "Html", "http://www.sport-fm.gr/tag/ofi");
        //    table.Rows.Add("ofi", "ΟΦΗ", "Sportime", "RSS", "http://www.sportime.gr/tag/ofi-team/feed/");


        //    // LAMIA 1.1
        //    //table.Rows.Add("lamia", "Λαμία", "Contra", "Html", "http://www.contra.gr/lamia");
        //    table.Rows.Add("lamia", "Λαμία", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/lamia");
        //    table.Rows.Add("lamia", "Λαμία", "Lamia1964", "RSS", "http://www.lamia1964.gr/feed/");
        //    table.Rows.Add("lamia", "Λαμία", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=48481&languageID=1");
        //    table.Rows.Add("lamia", "Λαμία", "OnSports", "Html", "https://www.onsports.gr/omades/lamia");
        //    table.Rows.Add("lamia", "Λαμία", "SDNA", "Html", "http://www.sdna.gr/teams/lamia");
        //    table.Rows.Add("lamia", "Λαμία", "Sport24", "Html", "http://www.sport24.gr/football/omades/Lamia/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("lamia", "Λαμία", "SportDog", "Html", "http://sportdog.gr/tag/Λαμία");
        //    table.Rows.Add("lamia", "Λαμία", "SportFM", "Html", "http://www.sport-fm.gr/tag/lamia");
        //    table.Rows.Add("lamia", "Λαμία", "Sportime", "RSS", "http://www.sportime.gr/tag/lamia/feed/");
        //    table.Rows.Add("lamia", "Λαμία", "Lamiara", "RSS", "https://lamiara.gr/roi-idiseon/feed");

        //    // Απ. Σμύρνης 1.3
        //    //table.Rows.Add("apSmyrnis", "Απόλλων Σμύρνης", "Contra", "Html", "https://www.contra.gr/Soccer/Hellas/Superleague/asterastr?widget=rssfeed&view=feed");
        //    table.Rows.Add("apSmyrnis", "Απόλλων Σμύρνης", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/apollon-smyrnis");
        //    table.Rows.Add("apSmyrnis", "Απόλλων Σμύρνης", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=504754&languageID=1");
        //    table.Rows.Add("apSmyrnis", "Απόλλων Σμύρνης", "OnSports", "Html", "https://www.onsports.gr/omades/apollon-smyrnis");
        //    table.Rows.Add("apSmyrnis", "Απόλλων Σμύρνης", "SDNA", "Html", "http://www.sdna.gr/teams/apollon-smyrnis/podosfairo");
        //    table.Rows.Add("apSmyrnis", "Απόλλων Σμύρνης", "Sport24", "Html", "http://www.sport24.gr/football/omades/apollonon-smirnis/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("apSmyrnis", "Απόλλων Σμύρνης", "SportDog", "Html", "http://sportdog.gr/tag/Απόλλων Σμύρνης");
        //    table.Rows.Add("apSmyrnis", "Απόλλων Σμύρνης", "SportFM", "Html", "http://www.sport-fm.gr/tag/apollon");
        //    table.Rows.Add("apSmyrnis", "Απόλλων Σμύρνης", "Sportime", "RSS", "http://www.sportime.gr/tag/apollon-smyrnis/feed/");

        //    // Αστ. Τρίπολης 1.3
        //    //table.Rows.Add("asterasTrip", "Αστέρας Τρίπολης", "Contra", "Html", "https://www.contra.gr/Soccer/Hellas/Superleague/apollonsmirnis?widget=rssfeed&view=feed");
        //    table.Rows.Add("asterasTrip", "Αστέρας Τρίπολης", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/asteras-tripolis");
        //    table.Rows.Add("asterasTrip", "Αστέρας Τρίπολης", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=91089&languageID=1");
        //    table.Rows.Add("asterasTrip", "Αστέρας Τρίπολης", "OnSports", "Html", "https://www.onsports.gr/omades/asteras-tripolis");
        //    table.Rows.Add("asterasTrip", "Αστέρας Τρίπολης", "SDNA", "Html", "http://www.sdna.gr/teams/asteras-tripolis/podosfairo");
        //    table.Rows.Add("asterasTrip", "Αστέρας Τρίπολης", "Sport24", "Html", "http://www.sport24.gr/football/omades/asterastripolis/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("asterasTrip", "Αστέρας Τρίπολης", "SportDog", "Html", "http://sportdog.gr/tag/Αστέρας Τρίπολης");
        //    table.Rows.Add("asterasTrip", "Αστέρας Τρίπολης", "SportFM", "Html", "http://www.sport-fm.gr/tag/asteras-tripolis");
        //    table.Rows.Add("asterasTrip", "Αστέρας Τρίπολης", "Sportime", "RSS", "http://www.sportime.gr/tag/asteras-tripolis/feed/");

        //    // Λεβαδειακός 1.3
        //    //table.Rows.Add("levadeiakos", "Λεβαδειακός", "Contra", "Html", "https://www.contra.gr/Soccer/Hellas/Superleague/levadiakos?widget=rssfeed&view=feed");
        //    table.Rows.Add("levadeiakos", "Λεβαδειακός", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/lebadeiakos");
        //    table.Rows.Add("levadeiakos", "Λεβαδειακός", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=16993&languageID=1");
        //    table.Rows.Add("levadeiakos", "Λεβαδειακός", "OnSports", "Html", "https://www.onsports.gr/omades/levadeiakos");
        //    table.Rows.Add("levadeiakos", "Λεβαδειακός", "SDNA", "Html", "http://www.sdna.gr/teams/lebadeiakos");
        //    table.Rows.Add("levadeiakos", "Λεβαδειακός", "Sport24", "Html", "http://www.sport24.gr/football/omades/levadiakos/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("levadeiakos", "Λεβαδειακός", "SportDog", "Html", "http://sportdog.gr/tag/Λεβαδειακός");
        //    table.Rows.Add("levadeiakos", "Λεβαδειακός", "SportFM", "Html", "http://www.sport-fm.gr/tag/levadiakos");
        //    table.Rows.Add("levadeiakos", "Λεβαδειακός", "Sportime", "RSS", "http://www.sportime.gr/tag/levadeiakos/feed/");

        //    // Παναιτωλικός 1.3
        //    //table.Rows.Add("panaitwlikos", "Παναιτωλικός", "Contra", "Html", "https://www.contra.gr/Soccer/Hellas/Superleague/panaitolikos?widget=rssfeed&view=feed");
        //    table.Rows.Add("panaitwlikos", "Παναιτωλικός", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/panaitolikos");
        //    table.Rows.Add("panaitwlikos", "Παναιτωλικός", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=47025&languageID=1");
        //    table.Rows.Add("panaitwlikos", "Παναιτωλικός", "OnSports", "Html", "https://www.onsports.gr/omades/panaitolikos");
        //    table.Rows.Add("panaitwlikos", "Παναιτωλικός", "SDNA", "Html", "http://www.sdna.gr/teams/panaitolikos/podosfairo");
        //    table.Rows.Add("panaitwlikos", "Παναιτωλικός", "Sport24", "Html", "http://www.sport24.gr/football/omades/Panaitolikos/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("panaitwlikos", "Παναιτωλικός", "SportDog", "Html", "http://sportdog.gr/tag/Παναιτωλικός");
        //    table.Rows.Add("panaitwlikos", "Παναιτωλικός", "SportFM", "Html", "http://www.sport-fm.gr/tag/panaitolikos");
        //    table.Rows.Add("panaitwlikos", "Παναιτωλικός", "Sportime", "RSS", "http://www.sportime.gr/tag/panaitolikos/feed/");

        //    // ΠΑΣ Γιάννινα 1.3
        //    //table.Rows.Add("pasGiannina", "ΠΑΣ Γιάννινα", "Contra", "Html", "https://www.contra.gr/Soccer/Hellas/Superleague/pasgiannina?widget=rssfeed&view=feed");
        //    table.Rows.Add("pasGiannina", "ΠΑΣ Γιάννινα", "Gazzetta", "Html", "https://www.gazzetta.gr/teams/pas-giannina");
        //    table.Rows.Add("pasGiannina", "ΠΑΣ Γιάννινα", "NovaSports", "RSS", "http://www.novasports.gr/sys/novasports/RssFeed/GetFeed?type=2&id=17089&languageID=1");
        //    table.Rows.Add("pasGiannina", "ΠΑΣ Γιάννινα", "OnSports", "Html", "https://www.onsports.gr/omades/pas-giannina");
        //    table.Rows.Add("pasGiannina", "ΠΑΣ Γιάννινα", "SDNA", "Html", "http://www.sdna.gr/teams/pas-giannina/podosfairo");
        //    table.Rows.Add("pasGiannina", "ΠΑΣ Γιάννινα", "Sport24", "Html", "http://www.sport24.gr/football/omades/PasGiannina/?widget=rssfeed&view=feed&contentId=174866");
        //    table.Rows.Add("pasGiannina", "ΠΑΣ Γιάννινα", "SportDog", "Html", "http://sportdog.gr/tag/ΠΑΣ Γιάννινα");
        //    table.Rows.Add("pasGiannina", "ΠΑΣ Γιάννινα", "SportFM", "Html", "http://www.sport-fm.gr/tag/pas");
        //    table.Rows.Add("pasGiannina", "ΠΑΣ Γιάννινα", "Sportime", "RSS", "http://www.sportime.gr/tag/pas-giannina/feed/");


        //    //1.5 To10 Added

        //    table.Rows.Add("aek", "ΑΕΚ", "To10", "Html", "https://www.to10.gr/team/aek/");
        //    table.Rows.Add("ael", "ΑΕΛ", "To10", "Html", "https://www.to10.gr/team/larisa/");
        //    table.Rows.Add("apSmyrnis", "Απόλλων Σμύρνης", "To10", "Html", "https://www.to10.gr/team/apollon-smyrnis/");
        //    table.Rows.Add("aris", "Άρης", "To10", "Html", "https://www.to10.gr/team/aris/");
        //    table.Rows.Add("asterasTrip", "Αστέρας Τρίπολης", "To10", "Html", "https://www.to10.gr/team/asteras-tripolis/");
        //    table.Rows.Add("atromitos", "Ατρόμητος", "To10", "Html", "https://www.to10.gr/team/atromitos/");
        //    table.Rows.Add("general", "Γενικές Ειδήσεις", "To10", "Html", "https://www.to10.gr/blog-view/");
        //    table.Rows.Add("iraklis", "Ηρακλής", "To10", "Html", "https://www.to10.gr/team/iraklis/");
        //    table.Rows.Add("lamia", "Λαμία", "To10", "Html", "https://www.to10.gr/team/lamia/");
        //    table.Rows.Add("levadeiakos", "Λεβαδειακός", "To10", "Html", "https://www.to10.gr/team/levadiakos/");
        //    table.Rows.Add("ofi", "ΟΦΗ", "To10", "Html", "https://www.to10.gr/team/ofi/");
        //    table.Rows.Add("osfp", "Ολυμπιακός", "To10", "Html", "https://www.to10.gr/team/olympiacos/");
        //    table.Rows.Add("panaitwlikos", "Παναιτωλικός", "To10", "Html", "https://www.to10.gr/team/panetolikos/");
        //    table.Rows.Add("panathinaikos", "Παναθηναϊκός", "To10", "Html", "https://www.to10.gr/team/panathinaikos/");
        //    table.Rows.Add("panionios", "Πανιώνιος", "To10", "Html", "https://www.to10.gr/team/panionios/");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "To10", "Html", "https://www.to10.gr/team/paok/");
        //    table.Rows.Add("pasGiannina", "ΠΑΣ Γιάννινα", "To10", "Html", "https://www.to10.gr/team/pas-giannina/");
        //    table.Rows.Add("xanthi", "Ξάνθη", "To10", "Html", "https://www.to10.gr/team/xanthi/");

        //    //1.5.6 Metrosport added

        //    table.Rows.Add("aris", "Άρης", "Metrosport", "Html", "https://www.metrosport.gr/aris");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "Metrosport", "Html", "https://www.metrosport.gr/paok");

        //    //1.5.7 A-sports added

        //    table.Rows.Add("aek", "ΑΕΚ", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-182/");
        //    table.Rows.Add("ael", "ΑΕΛ", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-216/");
        //    table.Rows.Add("aris", "Άρης", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-213/");
        //    table.Rows.Add("apSmyrnis", "Απόλλων Σμύρνης", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-87/");
        //    table.Rows.Add("asterasTrip", "Αστέρας Τρίπολης", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-164/");
        //    table.Rows.Add("atromitos", "Ατρόμητος", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-165/");
        //    table.Rows.Add("lamia", "Λαμία", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-224/");
        //    table.Rows.Add("levadeiakos", "Λεβαδειακός", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-169/");
        //    table.Rows.Add("ofi", "ΟΦΗ", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-168/");
        //    table.Rows.Add("osfp", "Ολυμπιακός", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-170/");
        //    table.Rows.Add("panaitwlikos", "Παναιτωλικός", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-174/");
        //    table.Rows.Add("panathinaikos", "Παναθηναϊκός", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-157/");
        //    table.Rows.Add("panionios", "Πανιώνιος", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-161/");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-158/");
        //    table.Rows.Add("pasGiannina", "ΠΑΣ Γιάννινα", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-159/");
        //    table.Rows.Add("xanthi", "Ξάνθη", "A-sports", "Html", "https://www.A-sports.gr/articles_categories-172/");

        //    //1.5.7 Kingsport.gr added

        //    table.Rows.Add("aek", "ΑΕΚ", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/aek-fc/");
        //    table.Rows.Add("ael", "ΑΕΛ", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/ael-fc/");
        //    table.Rows.Add("aris", "Άρης", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/aris-fc/");
        //    table.Rows.Add("apSmyrnis", "Απόλλων Σμύρνης", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/apollon-smyrnis-fc/");
        //    table.Rows.Add("asterasTrip", "Αστέρας Τρίπολης", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/asteras-tripolis-fc/");
        //    table.Rows.Add("atromitos", "Ατρόμητος", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/atromitos-fc/");
        //    table.Rows.Add("lamia", "Λαμία", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/lamia/");
        //    table.Rows.Add("levadeiakos", "Λεβαδειακός", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/levadeiakos-fc/");
        //    table.Rows.Add("ofi", "ΟΦΗ", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/ofi-fc/");
        //    table.Rows.Add("osfp", "Ολυμπιακός", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/olympiacos-fc/");
        //    table.Rows.Add("panaitwlikos", "Παναιτωλικός", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/panetolikos-fc/");
        //    table.Rows.Add("panathinaikos", "Παναθηναϊκός", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/panathinaikos/");
        //    table.Rows.Add("panionios", "Πανιώνιος", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/pgss/");
        //    table.Rows.Add("paok", "ΠΑΟΚ", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/paok-fc/");
        //    table.Rows.Add("pasGiannina", "ΠΑΣ Γιάννινα", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/pas-giannina/");
        //    table.Rows.Add("xanthi", "Ξάνθη", "Kingsport", "Html", "https://www.kingsport.gr/category/super-league1/xanthi/");

        //}

    }
}