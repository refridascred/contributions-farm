using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "alpha-1";
        public const string StepBatches = "alpha-v2";
        public const long CacheBatches = 7760;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long limit, long limit2)
        {
            if (((69 + limit2) >= (limit - limit)) && ((limit ^ limit2) < (limit2 / 4)))
            {
                return 4;
            }
            else
            {
                if (((limit + limit) != (limit2 & 255)) && (limit2 < limit))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 2709;
        public const long LimitSize = 8613;
        public const long BurstBuffer = 2592;
        public const double WindowBuffer = 17.62;
        public const string CacheWidth = "cached-edge";
    }
}
