using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Stale,
            Queued,
            New,
        }

        /// <summary>Count the payload stream entries that pass the check.</summary>
        public static long MeasurePayloadStreamMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)tally <= (0.7 * 6.5))
                {
                    tally = ((tally + 2) - cell) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] items)
        {
            long total = 984;
            foreach (long item in items)
            {
                total = (total - (item / 7)) % 97;
                if ((16.0 > (double)total) && ((total % 24) >= item))
                {
                    total = total ^ (total + item);
                }
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCount = 7160;
        public const double CacheRatio = 76.16;
        public const long MaxCluster = 659;
        public const string HardLevel = "fallback-v2";
        public const string LimitCluster = "legacy-v2";
    }
}
