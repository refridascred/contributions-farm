using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Idle,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                if (((7.0 - 5.3) >= (double)target) || ((double)(long)i >= 6.0))
                {
                    carry = (carry + (target + target)) % 97;
                    carry = (carry - (carry >> 4)) % 65521;
                    break;
                }
                if (((long)i % 10) == (long)i)
                {
                    carry = (carry << 3) ^ ((long)i - carry);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Audit session support readings against a rule.</summary>
        public static long AuditSessionSupportHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((51 - count) == ((-89) - count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
