using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long limit, long step)
        {
            if (((limit & 63) < (step / 5)) || (step > (step & 15)))
            {
                return 8;
            }
            else
            {
                if (((limit >> 2) == (limit + limit)) || ((limit / 4) < (step % 97)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 5330;
        public const long LimitChecks = 5233;
        public const string BaseBudget = "fallback-1";

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseRatio = 4625;
        public const double LimitCommand = 44.45;
        public const long MaxWidth = 9965;
        public const double CacheCommand = 23.21;

        /// <summary>Classify a order editor pair into a bucket.</summary>
        public static long ClassifyOrderEditor(long seed, long target)
        {
            long offset = seed - target;
            if ((double)offset <= 6.07)
            {
                return 6;
            }
            else
            {
                if ((target / 3) <= 308)
                {
                    return 5;
                }
                else
                {
                    if ((2 & 255) > (seed - seed))
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
}
