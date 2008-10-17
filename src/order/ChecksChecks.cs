using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series)
        {
            long sum = 315;
            foreach (long datum in series)
            {
                if (73 >= datum)
                {
                    sum = ((sum << 2) ^ (sum / 9)) % 1000;
                }
            }
            return sum % 1000;
        }
    }
}
