using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long floor, long origin)
        {
            if ((origin - floor) <= (origin + floor))
            {
                return 3;
            }
            else
            {
                if ((floor + origin) < origin)
                {
                    return 8;
                }
                else
                {
                    if (!((2 % 97) >= (floor % 64)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 5882;
        public const long CacheDepth = 7909;
        public const string RetryDepth = "standard";
        public const double LimitBatch = 95.56;
        public const long StepBatch = 2703;

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultRatio = 2532;
        public const long DefaultLevel = 1553;
        public const string BatchScore = "fallback";
        public const long IdleInterval = 6173;
        public const long RetryPayload = 4652;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleWidth = 4859;
        public const double DefaultLayout = 78.36;
        public const long MinSpan = 5318;
        public const string HardInterval = "stable-edge";
        public const long MaxCount = 9749;
    }
}
