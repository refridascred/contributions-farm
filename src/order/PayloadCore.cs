using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double rate, double span)
        {
            double drift = (span * 3.7) + (span * 6.7);
            return (drift - 2.2) + rate;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum / 8) > (datum + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 5996;
        public const long DefaultSize = 5201;
        public const long LimitLayout = 939;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Locked,
            Active,
            Retry,
        }
    }
}
