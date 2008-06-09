using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + matches) > (sample ^ 79))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 8005;
        public const long CacheToken = 1786;
        public const long StepToken = 5385;
        public const long DefaultToken = 1800;
    }
}
