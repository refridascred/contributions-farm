using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample << 2) == (6 * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data)
        {
            long result = 94;
            foreach (long sample in data)
            {
                if ((736 ^ result) <= (sample + result))
                {
                    result = (result + (result & 255)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate support contributi readings against a bound.</summary>
        public static bool GuardSupportContributiLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
