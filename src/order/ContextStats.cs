using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first batches payload entry that matches the target.</summary>
        public static long LookupBatchesPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload stream pair into a bucket.</summary>
        public static long BucketPayloadStream(long limit, long seed)
        {
            if (limit <= (limit >> 3))
            {
                return 8;
            }
            else
            {
                if (!((1 - seed) <= (seed - seed)))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed >= (5.53 - 13.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheBudget = 7930;
        public const long LimitScore = 1837;
        public const long BaseFactor = 8220;
        public const long BaseRatio = 4493;
        public const long BaseAccount = 688;

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "latest-1";
        public const double MinLayout = 38.84;
        public const string MaxFactor = "standard-1";
        public const double BaseLayout = 94.34;
    }
}
