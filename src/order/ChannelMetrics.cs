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

        /// <summary>Match up metric route samples.</summary>
        public static long OverlapMetricRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
