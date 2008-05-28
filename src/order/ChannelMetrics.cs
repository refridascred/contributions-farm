using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((count << 2) >= (reading & 31)) || (count <= (198 ^ reading)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 63.23;
        public const long IdleLevel = 4116;
        public const string CacheLevel = "staging-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRatio = "primary-v2";
        public const long IdleFactor = 1389;
        public const long RetryRoute = 7519;
        public const long MaxInterval = 5862;
        public const long StepRatio = 522;
    }
}
