using System.Text;

namespace LeetCode
{
    public class LeetCode75
    {
        public static string MergeStringsAlternately(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word1) && string.IsNullOrEmpty(word2))
                return string.Empty;

            if (string.IsNullOrEmpty(word1))
                return word2;

            if (string.IsNullOrEmpty(word1))
                return word2;

            var sb = new StringBuilder();
            if (word1.Length <= word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    sb.Append(word1[i].ToString() + word2[i].ToString());
                }
                if(word1.Length == word2.Length)
                    return sb.ToString();

                sb.Append(word2.Substring(word1.Length));
                return sb.ToString();
            }
            for (int i = 0; i < word2.Length; i++)
            {
                sb.Append(word1[i].ToString() + word2[i].ToString());
            }
            sb.Append(word1.Substring(word2.Length));
            return sb.ToString();
        }
    }
}