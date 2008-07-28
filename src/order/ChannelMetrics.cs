using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a cache buffer pair into a bucket.</summary>
        public static long SortCacheBuffer(long seed, long target)
        {
            long cur = seed ^ target;
            if (((6.6 + 9.0) == (double)seed) || ((seed + 0) == (target + 990)))
            {
                return 3;
            }
            else
            {
                if (((9.1 * 7.0) < (double)seed) || (4.0 > (double)cur))
                {
                    return 8;
                }
                else
                {
                    if (!(cur <= (cur >> 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)cur > 4.79) && (cur > target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)9 < (double)offset)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
