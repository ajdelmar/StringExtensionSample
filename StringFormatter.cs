
using System.Text;

namespace StringExtensions
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public static class StringFormatter
    {

        //Code to improve
        /// <summary>
        /// Added 'this' keyword to make it an extension and made quote optional
        /// </summary>
        /// <param name="items">The list of strings</param>
        /// <param name="quote">Optional: This will wrap each item with the value</param>
        /// <returns></returns>
        public static string ToCommaSeparatedList(this string[] items, string? quote = null)
        {
            if (items == null || items.Length == 0)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            bool isFirstItemProcessed = false;
            for (int i = 0; i < items.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(items[i]))
                {
                    continue;
                }
                if (!isFirstItemProcessed)
                {
                    sb.Append(string.Format("{0}{1}{0}", quote, items[i]));
                    isFirstItemProcessed = true;
                }
                else
                {
                    sb.Append(string.Format(", {0}{1}{0}", quote, items[i]));
                }
            }

            return sb.ToString();
        }
    }
}
