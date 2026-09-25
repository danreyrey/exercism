using System.Linq;

static class LogLine
{
    public static string Message(string logLine)
    {
        char[] charArray = {'\n', '\r',  '\t', '\\', '\"', '\'', '\0', '\e', ' '};
        return logLine.Substring(logLine.IndexOf(':') + 1).Trim(charArray);

        // logLine = logLine[(logLine.IndexOf(':') + 1)..].Trim().Trim('!');
		// logLineCopy = logLineCopy[1..(logLineCopy.IndexOf(']'))].ToLower();
		
		// logLine = logLine.Split(':')[1].Trim().Trim('!');
		// logLineCopy = logLineCopy.Split(']')[0].Trim('[').ToLower();
		
		// char[] arr = logLine.ToCharArray();
		// Array.Reverse(arr);
		// string rev = new string(arr);
    }

    public static string LogLevel(string logLine)
    {
        char[] charArray = {'[', ']'};
        return logLine.Substring(0, logLine.IndexOf(':')).Trim(charArray).ToLower();
    }

    public static string Reformat(string logLine)
        => $"{Message(logLine)} ({LogLevel(logLine)})";
}
