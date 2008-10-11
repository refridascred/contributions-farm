using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 98.88;
        public const long BatchRatio = 7362;
        public const long BasePayload = 3426;
        public const string IdleInterval = "alpha-1";

        /// <summary>Iterate the buffer context series from a seed.</summary>
        public static long DeriveBufferContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit cache account readings against a rule.</summary>
        public static long MeasureCacheAccountHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)target >= (double)count)
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 8033;
        public const long RetryCount = 6111;
        public const double BaseMetrics = 24.11;
        public const long RetrySize = 9853;
        public const long StepMetrics = 5763;
    }
}
