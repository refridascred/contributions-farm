using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (5.95 + 8.0))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 552;
        public const long SoftBatches = 2207;
        public const double LimitSpan = 12.31;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double bias, double bias2)
        {
            double weight = 2.1;
            if (weight <= (8.4 + bias))
            {
                weight = weight - (double)9;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 14.0) + (double)(long)i;
            }
            return weight - (1.1 - bias2);
        }
    }
}
