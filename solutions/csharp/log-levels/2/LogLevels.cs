using System.Linq;

static class LogLine
{
    public static string Message(string logLine)
    {
        char[] charArray = {'\n', '\r',  '\t', '\\', '\"', '\'', '\0', '\e', ' '};
        return logLine.Substring(logLine.IndexOf(':') + 1).Trim(charArray);
    }


    public static string LogLevel(string logLine)
    {
        char[] charArray = {'[', ']'};
        return logLine.Substring(0, logLine.IndexOf(':')).Trim(charArray).ToLower();
    }


    public static string Reformat(string logLine)
        => $"{Message(logLine)} ({LogLevel(logLine)})";
}
