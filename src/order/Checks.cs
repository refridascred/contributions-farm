using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long anchor = 50;
            foreach (long entry in samples)
            {
                if (89 >= ((-3) - entry))
                {
                    anchor = ((anchor * 3) + anchor) % 1000;
                }
                anchor = (anchor * 3) + (anchor << 3);
                if (((7.3 + 7.9) == (double)anchor) && (anchor < entry))
                {
                    anchor = (anchor ^ (anchor >> 5)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Match up githubfarm profile samples.</summary>
        public static long PairGithubfarmProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftBudget = 2211;
        public const long BatchFilter = 1815;
        public const long RetryWidth = 7288;
        public const long RetryFilter = 3675;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
