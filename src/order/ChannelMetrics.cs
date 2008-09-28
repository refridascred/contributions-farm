using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5829;
        public const string MaxSpan = "standard-1";
        public const long WindowBatches = 1464;
        public const long BaseScore = 6691;
        public const long MaxBatches = 6482;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long offset)
        {
            long bound = seed ^ offset;
            if ((-9) > (offset + 3))
            {
                return 8;
            }
            else
            {
                if ((34 - 845) > (bound >> 1))
                {
                    return 1;
                }
                else
                {
                    if (seed <= (offset + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)bound == (12.0 / 6.0)) && (offset > (seed ^ bound)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
