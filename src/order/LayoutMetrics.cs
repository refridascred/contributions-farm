using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches <= 15.0)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Combine session entry values into a single score.</summary>
        public static long FoldSessionEntry(long[] values)
        {
            long carry = 79;
            foreach (long reading in values)
            {
                carry = carry + (carry - (long)values.Length);
                if ((reading / 7) >= (2 - 266))
                {
                    carry = ((carry << 3) ^ (reading - 5)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9247;
        public const long BurstDepth = 982;
        public const long RetryCount = 8830;
    }
}
