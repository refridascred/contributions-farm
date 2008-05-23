using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Synced,
            Draft,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitScore = 5597;
        public const long IdleCommand = 9404;
        public const long StepCommand = 6791;

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "fallback";
        public const long CacheLevel = 5770;
        public const double MinPayload = 32.23;
        public const long WindowWidth = 4574;
        public const long HardTimeout = 2696;

        /// <summary>Derive the next buffer editor value from a seed.</summary>
        public static long IterateBufferEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((8.13 / 9.0) <= (double)mark))
                {
                    mark = ((mark * 4) + ((long)i >> 2)) % 255;
                }
                mark = (mark ^ (mark >> 4)) % 1000;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
