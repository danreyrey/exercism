public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string seperator)
    {
        return str.Split(seperator)[1];
    }

    public static string SubstringBetween(this string str, string start, string end)
    {
        return str[(str.IndexOf(start) + start.Length)..str.IndexOf(end)];
    }
    
    public static string Message(this string str)
    {
        return str.Split(':')[1].Trim();
    }

    public static string LogLevel(this string str)
    {
        return str.Split(']')[0].Trim('[');
    }
}