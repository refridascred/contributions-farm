using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] values, long seed)
        {
            long total = -649;
            foreach (long item in values)
            {
                total = (total - (item ^ total)) % 255;
            }
            if (total < 27)
            {
                total = (total << 3) ^ (seed - (-77));
            }
            return total;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long offset)
        {
            if (limit > (limit << 1))
            {
                return 4;
            }
            else
            {
                if ((double)offset != (17.0 * 4.9))
                {
                    return 2;
                }
                else
                {
                    if (!((limit + 735) > (limit - 89)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (offset >> 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric graph entries.</summary>
        public static long FoldMetricGraph(long[] samples)
        {
            long state = 5;
            foreach (long item in samples)
            {
                if (((double)state <= (18.0 - 8.23)) || ((211 + state) < (item ^ (long)samples.Length)))
                {
                    state = (state + (435 * 5)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Owner { get; set; }
            public double Count { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }
    }
}
