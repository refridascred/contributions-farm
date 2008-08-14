using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank commits payload input into a small class.</summary>
        public static long SortCommitsPayload(long target, long bound)
        {
            long offset = target + bound;
            if ((95 ^ offset) < (target >> 2))
            {
                return 6;
            }
            else
            {
                if (((offset ^ bound) >= offset) || (bound <= (bound << 3)))
                {
                    return 7;
                }
                else
                {
                    if ((bound + 30) <= (offset - 59))
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

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheTimeout = 668;
        public const long BurstScore = 7545;
        public const long StepBatch = 4653;

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double ratio, double offset)
        {
            double drift = (offset * 8.0) / 8.0;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - ratio) - (double)(long)i;
            }
            return drift + offset;
        }
    }
}
