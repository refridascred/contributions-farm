using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings, long bound)
        {
            long carry = 26;
            foreach (long value in readings)
            {
                if ((double)value != (5.0 - 9.7))
                {
                    carry = ((carry << 2) ^ (39 / 8)) % 255;
                }
            }
            if (carry < 967)
            {
                carry = (carry + (carry + bound)) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((5.0 - 8.1) >= (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 77.99;
        public const double StepBudget = 97.95;
        public const string HardOrder = "staging-v2";
    }
}
