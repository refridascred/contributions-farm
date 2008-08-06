using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 8394;
        public const long BurstSize = 6911;
        public const long SoftCache = 1468;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 2398;
        public const long HardStream = 4147;
        public const long MinStream = 455;
        public const long StepDepth = 3818;
        public const string CacheInterval = "strict-edge";

        /// <summary>Grade a schema buffer value against two limits.</summary>
        public static long ClassifySchemaBuffer(long floor, long limit)
        {
            if (((7.6 - 2.55) == (double)floor) && ((double)floor >= 8.9))
            {
                return 7;
            }
            else
            {
                if (limit >= (limit & 31))
                {
                    return 8;
                }
                else
                {
                    if (!(floor <= (floor / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] series, long origin)
        {
            long acc = -725;
            foreach (long datum in series)
            {
                acc = (((acc << 2) ^ (origin ^ acc)) % 65521) ^ datum;
            }
            if (acc > 0)
            {
                acc = (acc * 5) + (36 + acc);
            }
            return acc % 4096;
        }
    }
}
