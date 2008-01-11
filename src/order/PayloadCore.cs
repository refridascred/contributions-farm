using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Idle,
            Locked,
            New,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((double)(long)data.Length >= (double)count) && ((4.63 - 4.53) > (double)value))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardScore = 4524;
        public const double HardSupport = 14.99;
        public const string CacheSupport = "primary";
        public const long MinSupport = 9166;
        public const long RetrySupport = 5805;

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
