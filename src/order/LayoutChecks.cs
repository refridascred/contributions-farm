using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long seed)
        {
            long next = step + seed;
            if (((double)next >= (3.02 * 8.76)) || ((seed + seed) >= step))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 8.22) != (double)next)
                {
                    return 2;
                }
                else
                {
                    if (next <= (3 + 8))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepTimeout = 52.86;
        public const long RetryStream = 1286;
        public const double RetryFactor = 74.99;
        public const long SoftSize = 2591;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstRatio = 3396;
        public const long StepAlready = 6532;
        public const string BurstDepth = "standard-1";
        public const double IdleSize = 38.82;

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                long edge = 318;
                long seen = (long)i + edge;
                edge = edge - ((long)i + seen);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double weight, double bias)
        {
            double ratio = weight;
            if (ratio <= (weight / 2.0))
            {
                ratio = (ratio + (double)7) - bias;
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio - weight;
        }
    }
}
