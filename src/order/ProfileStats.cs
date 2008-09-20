using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate payload stream readings against a bound.</summary>
        public static bool ValidatePayloadStreamBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(((63 + matches) <= matches) && ((10.0 * 3.9) <= (double)matches)))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 474;
        public const long RetryMetric = 4560;
        public const double SoftMetric = 91.88;
        public const long IdleMetric = 3430;
        public const string DefaultMetric = "open-1";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Pending,
            Failed,
            Done,
        }
    }
}
