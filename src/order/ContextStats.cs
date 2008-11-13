using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen <= 456)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseSize = 86.66;
        public const double BurstCache = 83.41;
        public const string LimitSize = "cached-1";

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchSize = 77.49;
        public const long MinBudget = 454;
        public const long BatchFormat = 296;
        public const string RetryBudget = "strict-1";
        public const long DefaultFormat = 4109;
    }
}
