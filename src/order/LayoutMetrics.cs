using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit contributi window readings against a rule.</summary>
        public static long AuditContributiWindowHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches >> 5) <= (matches - cell))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxTimeout = 4488;
        public const long WindowRatio = 5316;
        public const long BurstSupport = 5581;
        public const double HardSupport = 79.06;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
