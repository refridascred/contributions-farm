using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Failed,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the format counter entries that pass the check.</summary>
        public static long AuditFormatCounterOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((431 ^ item) >= (7 << 3))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
