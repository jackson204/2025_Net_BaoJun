namespace 擴展方法_Demo;

public static class StringExtensions
{
    public static int ParseToInt(this string str)
    {
        if (int.TryParse(str, out var result))
        {
            return result;
        }
        throw new FormatException($"Unable to parse '{str}' to an integer.");
    }
}
