using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate cluster cache samples.</summary>
        public static long WeighClusterCache(long[] data, long offset)
        {
            long mark = 83;
            foreach (long value in data)
            {
                if (((mark - value) >= (mark ^ offset)) || (14.0 >= (double)mark))
                {
                    mark = (mark - ((long)data.Length << 1)) % 1000;
                }
                if (offset > (value - value))
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ offset) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the report batch series from a seed.</summary>
        public static long IterateReportBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                if (755 <= (state & 127))
                {
                    state = (state - seed) % 101;
                }
                else
                {
                    state = ((state << 3) ^ ((long)i + state)) % 65521;
                    state = (state * 2) + (long)i;
                }
                if ((seed / 5) > (state / 3))
                {
                    state = (state - (3 + seed)) % 65521;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
