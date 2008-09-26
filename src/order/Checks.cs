using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long target, long seed)
        {
            long gap = target + seed;
            if ((target / 3) > (target ^ seed))
            {
                return 6;
            }
            else
            {
                if (((gap & 7) < seed) || (17.0 > (3.6 / 4.0)))
                {
                    return 8;
                }
                else
                {
                    if ((656 - gap) == (gap - target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum <= ((-774) * 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double ratio, double offset)
        {
            double bias = ratio;
            if (bias >= ratio)
            {
                bias = (bias + ratio) - offset;
            }
            return bias + (double)4;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "legacy-v2";
        public const double StepLevel = 30.07;
        public const string WindowFormat = "fallback-v2";
        public const double BatchDepth = 1.92;
    }
}
