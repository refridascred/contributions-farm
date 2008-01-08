using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((9 > (seen % 10)) || ((double)offset <= (8.95 - 5.0)))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            if ((bound & 7) < (origin << 3))
            {
                return 1;
            }
            else
            {
                if ((bound ^ origin) > (origin >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((origin - (-54)) > (origin / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
