using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a checks profile value against two limits.</summary>
        public static long BucketChecksProfile(long seed, long origin)
        {
            long bound = seed ^ origin;
            if (!((bound / 2) > 288))
            {
                return 2;
            }
            else
            {
                if ((20.0 <= (double)origin) || ((2.0 + 15.0) < (double)seed))
                {
                    return 1;
                }
                else
                {
                    if ((593 + origin) <= (seed + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed <= (3.0 - 9.77))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftTimeout = "fallback";
        public const long BatchDepth = 8859;
        public const long RetryLayout = 810;
        public const long IdleLayout = 6209;
    }
}
