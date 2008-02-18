using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate format order readings against a bound.</summary>
        public static bool CheckFormatOrderRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
