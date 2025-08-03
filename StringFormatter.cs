using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{
    /*
    Improvements made in the block of code as I saw fit in C#.
      - Fixed typo in method name from "ToCommaSepatatedList" to "ToCommaSeparatedList"
      - renamed the method parameter "quote" to "wrapper" for clarity
      - made wrapper parameter optional with a default value of ", shortening the method signature
      - added null or empty check for items array to avoid unnecessary processing
      - renamed variable "qry" to "stringBuilder" for clarity following camelCase naming conventions
      - refactored and simplified string append and format logic
    */
    public class StringFormatter
    {
        public static string ToCommaSeparatedList(string[] items, string wrapper = "\"")
        {
            if (items == null || items.Length == 0)
                return string.Empty;

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < items.Length; i++)
            {
                if (i > 0) stringBuilder.Append(", ");
                stringBuilder.Append(string.Format("{0}{1}{0}", wrapper, items[i]));
            }

            return stringBuilder.ToString();
        }

        //if performance is not a concern, we can use System.Linq to simplify the method using the following;
        /*
        public static string ToCommaSeparatedList(string[] items, string wrapper = "\"")
        {
            if (items == null || items.Length == 0)
                return string.Empty;

            return string.Join(", ", items.Select(item => string.Format("{0}{1}{0}", wrapper, item)));
        }
        */
    }
}