using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= 852)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + count) != (count >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
