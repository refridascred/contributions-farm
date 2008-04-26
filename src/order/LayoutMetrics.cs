using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the entry cache entries that pass the check.</summary>
        public static long TallyEntryCacheHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((7 + limit) > limit)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Validate queue support readings against a bound.</summary>
        public static bool ValidateQueueSupportBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
