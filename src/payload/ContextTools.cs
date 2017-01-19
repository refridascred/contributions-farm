using System;

namespace Common.Utilities
{
    /// <summary>Context tools helpers.</summary>
    public static class ContextTools
    {
        /// <summary>Count the vowels in a batch editor label.</summary>
        public static int CountBatchEditorVowels(string text)
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

        /// <summary>Check whether a record order size is a power of two.</summary>
        public static bool IsRecordOrderPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Check whether a catalog size is a power of two.</summary>
        public static bool IsCatalogPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
