using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next cache context value from a seed.</summary>
        public static long SeriesCacheContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((entry - 33) != (tally << 1)))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
