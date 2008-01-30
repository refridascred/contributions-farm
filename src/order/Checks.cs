using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long origin, long seed)
        {
            if ((origin + origin) <= 32)
            {
                return 1;
            }
            else
            {
                if ((seed + (-84)) <= (origin & 15))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetrySpan = 1146;
        public const long HardScore = 5137;
        public const string MinTools = "local-v2";
        public const double BatchTools = 16.09;
        public const double BatchWidth = 32.27;

        /// <summary>Count the window metric entries that pass the check.</summary>
        public static long AuditWindowMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches << 3) < (3 + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data, long bound)
        {
            long carry = 8;
            foreach (long datum in data)
            {
                if (793 > bound)
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = (carry - (datum % 2)) % 4096;
                }
            }
            if (carry > 6)
            {
                carry = ((carry * 3) + (carry << 2)) % 4096;
            }
            return carry % 1000;
        }
    }
}
