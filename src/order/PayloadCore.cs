using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "local-edge";
        public const long RetryContext = 7306;
        public const long MaxContext = 1065;
        public const double MinTimeout = 40.5;
        public const string StepContext = "fallback";

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowWidth = 8186;
        public const double BurstStream = 79.28;
        public const long BatchStream = 2070;

        /// <summary>Rank cache batch input into a small class.</summary>
        public static long RankCacheBatch(long origin, long limit)
        {
            long delta = origin - limit;
            if ((origin >> 3) == (origin + limit))
            {
                return 3;
            }
            else
            {
                if (!((delta / 2) > (limit * 2)))
                {
                    return 1;
                }
                else
                {
                    if (((origin ^ origin) <= delta) && (origin < 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + limit) <= 1)
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
        }
    }
}
