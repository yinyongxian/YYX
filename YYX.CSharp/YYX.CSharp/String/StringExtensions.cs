namespace YYX.CSharp.String
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmptyOrWhiteSpace(this string text)
        {
            return string.IsNullOrEmpty(text) ||
                   string.IsNullOrWhiteSpace(text);
        }
    }
}
