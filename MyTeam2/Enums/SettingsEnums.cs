namespace MyTeam2.Enums
{
    public enum LinkOpenOption
    {
        InAppBrowser,
        DeviceBrowser
    }

    public static class LinkOpenOptionDisplay
    {
        public static readonly Dictionary<LinkOpenOption, string> Names = new()
            {
                { LinkOpenOption.InAppBrowser, "Μέσα στην εφαρμογή" },
                { LinkOpenOption.DeviceBrowser, "Σε browser" }
            };
    }

    public enum ThemeOption
    {
        Modern,
        Minimal
    }
}
