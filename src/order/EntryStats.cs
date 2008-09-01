using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Idle,
            Done,
            Pending,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8329;
        public const string DefaultSize = "strict";
        public const long CacheReport = 7670;

        /// <summary>Rank command stats input into a small class.</summary>
        public static long RankCommandStats(long offset, long limit)
        {
            long next = offset ^ limit;
            if (((0.67 - 7.42) > (double)next) || ((next >> 3) > ((-197) / 2)))
            {
                return 2;
            }
            else
            {
                if (next < (offset + (-5)))
                {
                    return 6;
                }
                else
                {
                    if (((limit * 5) < next) && ((double)limit > 7.6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double rate = (double)(68 + 28);
            if (rate > rate)
            {
                rate = (rate + scale) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (8.88 + rate)) + (double)(long)i;
            }
            return rate - (scale / 8.0);
        }
    }
}
