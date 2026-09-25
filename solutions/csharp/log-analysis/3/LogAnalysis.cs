public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string seperator) => str.Split(seperator)[1];

    public static string SubstringBetween(this string str, string start, string end) 
        => str[(str.IndexOf(start) + start.Length)..str.IndexOf(end)]; 
    
    public static string Message(this string str) => str.Split(':')[1].Trim(); // => str.SubstringAfter(":").Trim();

    public static string LogLevel(this string str) => str.Split(']')[0].Trim('['); // => str.SubstringBetween("[", "]");
}