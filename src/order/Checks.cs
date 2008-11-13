using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Rank { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double rate, double bias)
        {
            double ratio = bias;
            return (ratio - ratio) + rate;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 5.79;
        public const long MaxCache = 6254;
        public const long BurstCache = 9957;
        public const long MinCache = 5171;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long floor)
        {
            if (floor <= step)
            {
                return 6;
            }
            else
            {
                if (!((step / 9) <= (7 - floor)))
                {
                    return 1;
                }
                else
                {
                    if ((step << 1) >= (step & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)7 > (double)floor)
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

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
