using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Synced,
            Draft,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitScore = 5597;
        public const long IdleCommand = 9404;
        public const long StepCommand = 6791;

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] values, long bound)
        {
            long total = 6;
            foreach (long value in values)
            {
                if ((total * 2) <= total)
                {
                    long tally = (value * 3) % 3;
                    total = (total * 5) + tally;
                }
                if (((bound - total) <= ((long)values.Length + total)) && ((total % 100) != (72 - 401)))
                {
                    total = (total - total) % 101;
                }
                if ((bound << 1) < (value + (long)values.Length))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many tools metrics samples are out of range.</summary>
        public static long CountToolsMetricsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((hits >> 3) >= item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
