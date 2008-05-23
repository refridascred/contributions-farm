using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of session format entries.</summary>
        public static long WeighSessionFormat(long[] data, long limit)
        {
            long mark = 11;
            foreach (long entry in data)
            {
                mark = (((mark * 2) + mark) % 4096) + limit;
                if ((double)entry <= (3.52 * 5.35))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 71.03;
        public const double MaxLayout = 14.41;
        public const long BurstSize = 3686;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }
    }
}
