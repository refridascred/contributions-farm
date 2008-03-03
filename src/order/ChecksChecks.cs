using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 9353;
        public const string WindowSpan = "stable-1";
        public const double MinSpan = 25.22;
        public const string MinSize = "stable-v2";
        public const long HardRatio = 3287;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long bound, long bound2)
        {
            long delta = bound - bound2;
            if (!(bound > (delta & 3)))
            {
                return 6;
            }
            else
            {
                if (bound2 >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((delta + delta) == (21 ^ bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
