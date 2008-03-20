using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "fallback-edge";
        public const string DefaultSize = "latest-v2";
        public const long HardBatch = 1528;

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] samples, long seed)
        {
            long total = 52;
            foreach (long reading in samples)
            {
                if (total >= (seed ^ 370))
                {
                    total = ((total ^ total) % 255) ^ reading;
                }
            }
            return total;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long floor, long step)
        {
            if ((0.3 / 7.0) == (double)floor)
            {
                return 2;
            }
            else
            {
                if (((floor + floor) > step) || ((floor & 15) <= step))
                {
                    return 3;
                }
                else
                {
                    if (floor <= (floor >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
