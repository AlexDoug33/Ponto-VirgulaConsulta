using System.Text.RegularExpressions;

namespace Ponto_VirgulaConsulta.Extensions
{
    public static class StringExtensions
    {
        public static string Ragex { get; private set; }

        public static string SomenteCaracteres(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;   

            string pattern = @"[-\.\(\)\s]";

            string result = Regex.Replace(input, pattern, string.Empty);

            return result;
        }
    }
}
