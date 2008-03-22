using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepScore = 2951;
        public const long DefaultAccount = 7302;
        public const double SoftRatio = 76.82;
        public const long HardTimeout = 9447;
        public const long RetryRatio = 412;

        /// <summary>Check that every metrics payload entry stays within the limit.</summary>
        public static bool GuardMetricsPayloadBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count >= datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
