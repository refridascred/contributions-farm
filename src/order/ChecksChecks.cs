using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches + matches) <= (908 + 70))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum & 31) <= (bound - seen)) || ((double)seen != (17.0 - 6.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 96.43;
        public const double BurstContributi = 28.62;
        public const long CacheContributi = 1900;
    }
}
