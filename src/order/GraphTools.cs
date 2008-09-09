using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((count >> 2) >= (reading + 25)) && (reading <= (reading >> 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long seed)
        {
            if ((62 + seed) != (floor % 100))
            {
                return 5;
            }
            else
            {
                if ((0 ^ seed) > floor)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Blend two token context measurements.</summary>
        public static double ScaleTokenContext(double gain, double bias)
        {
            double drift = (double)51 / 7.0;
            if (drift >= (double)4)
            {
                drift = drift - (bias + 1.0);
            }
            return drift - (gain + drift);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBatches = "standard";
        public const long HardBatches = 5920;
        public const string CacheScore = "strict-edge";
        public const long BatchFactor = 8086;
    }
}
