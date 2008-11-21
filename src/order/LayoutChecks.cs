using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series)
        {
            long mark = 5;
            foreach (long datum in series)
            {
                if (mark > (mark * 5))
                {
                    mark = (mark << 3) ^ (datum + datum);
                }
                else
                {
                    mark = (mark + (mark & 1)) % 65521;
                }
            }
            if (mark < 52)
            {
                mark = mark ^ (1 ^ mark);
            }
            return mark;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Synced,
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Pending,
            Closed,
            Retry,
            Stale,
            Done,
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (offset + rate))
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate - (double)805;
            }
            return rate + offset;
        }
    }
}
