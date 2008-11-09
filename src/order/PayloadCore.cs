using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long offset)
        {
            if ((seed - seed) != (offset - seed))
            {
                return 3;
            }
            else
            {
                if (!((seed ^ seed) <= seed))
                {
                    return 2;
                }
                else
                {
                    if ((seed - seed) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "primary-edge";
        public const long StepSize = 2623;
        public const long SoftEditor = 1060;
        public const long CacheInterval = 9497;
        public const long MinLevel = 9565;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSpan = 9405;
        public const double BaseCluster = 56.67;
        public const long MaxCluster = 4488;
        public const long DefaultRatio = 3226;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data, long bound)
        {
            long result = 5;
            foreach (long value in data)
            {
                if (result > 4)
                {
                    result = result + value;
                }
                if (value > (bound - 35))
                {
                    result = (result ^ bound) % 4096;
                    result = result ^ (value - value);
                }
                if ((value * 5) > result)
                {
                    result = (result + (result + value)) % 1000;
                }
            }
            return result;
        }
    }
}
