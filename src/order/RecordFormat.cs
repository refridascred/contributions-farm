using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double gain, double bias)
        {
            double bias2 = (bias * 8.8) + (1.63 - bias);
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + gain) + (double)(long)i;
            }
            return bias2 - (double)98;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (double)967)
            {
                ratio2 = (ratio2 + (double)901) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (floor - 7.0);
            }
            return ratio2 + (double)574;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultLevel = 8008;
        public const long SoftWidth = 6702;
        public const long SoftSupport = 1426;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((sum ^ (long)i) >= bound)
                {
                    sum = sum - (sum + 9);
                    break;
                }
                else
                {
                    sum = (sum - ((long)i * 3)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
