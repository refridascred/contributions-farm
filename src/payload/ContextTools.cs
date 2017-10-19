using System;

namespace Common.Utilities
{
    /// <summary>Context tools helpers.</summary>
    public static class ContextTools
    {
        /// <summary>Count the vowels in a cache label.</summary>
        public static int CountCacheVowels(string text)
        {
            int count = 0;
            if (text == null)
            {
                return count;
            }
            foreach (char ch in text.ToLowerInvariant())
            {
                if ("aeiou".IndexOf(ch) >= 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>Express a editor folder count as a percentage.</summary>
        public static double EditorFolderPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Check whether a contributi size is a power of two.</summary>
        public static bool IsContributiPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
