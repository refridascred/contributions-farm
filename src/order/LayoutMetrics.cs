using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long seed)
        {
            if ((limit / 6) >= (2 + seed))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= (7.04 / 2.0))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
        }
    }
}
