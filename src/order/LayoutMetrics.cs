using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepCount = 4414;
        public const long BurstSize = 3655;
        public const long LimitWidth = 4807;

        /// <summary>Classify a graph tools pair into a bucket.</summary>
        public static long BucketGraphTools(long origin, long step)
        {
            if (!((double)origin >= (double)730))
            {
                return 5;
            }
            else
            {
                if (((origin - origin) < step) && (2 < origin))
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
}
