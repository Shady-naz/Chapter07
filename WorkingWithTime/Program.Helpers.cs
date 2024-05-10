using System.Globalization;
using System.Text;
partial class Program
{
    private static void ConfigureConsole(string culture = "en-US", bool overrideComputerCulture = true)
    {
        OutputEncoding = Encoding.UTF8;
        Thread t = Thread.CurrentThread;
        if (overrideComputerCulture)
        {
            t.CurrentCulture = CultureInfo.GetCultureInfo(culture);
            t.CurrentUICulture = t.CurrentCulture;
        }
        CultureInfo ci = t.CurrentCulture;
        WriteLine($"Current Culture: {ci.DisplayName}");
        WriteLine($"Short Date Pattern: {ci.DateTimeFormat.ShortDatePattern}");
        WriteLine($"Long Date Pattern: {ci.DateTimeFormat.LongDatePattern}");
        WriteLine();
    }
    private static void SectionTitle (string title )
    {
        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"***{title}***");
        ForegroundColor = previousColor;
    }
}