using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen & 255) <= (704 + 93))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxScore = 1.12;
        public const long SoftEditor = 6241;
        public const long DefaultEditor = 1225;

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values, long floor)
        {
            long sum = -700;
            foreach (long value in values)
            {
                sum = (((sum * 2) + (floor + 99)) % 65521) + value;
            }
            return sum;
        }
    }
}
