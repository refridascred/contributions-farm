using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseScore = 3448;
        public const string CacheSize = "latest-edge";
        public const double WindowBatch = 78.63;

        /// <summary>Classify a queue payload pair into a bucket.</summary>
        public static long SortQueuePayload(long limit, long step)
        {
            if ((limit << 2) > (limit + step))
            {
                return 8;
            }
            else
            {
                if ((double)step >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((limit + step) >= ((-2) >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Active,
            New,
            Failed,
            Draft,
        }
    }
}
