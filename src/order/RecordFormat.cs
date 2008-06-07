using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 5718;
        public const long BaseSchema = 250;
        public const double BurstTimeout = 93.4;
        public const double LimitDepth = 78.6;
        public const long HardSpan = 3539;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items)
        {
            long carry = 934;
            foreach (long value in items)
            {
                if (carry <= (value * 5))
                {
                    carry = (carry ^ (value - value)) % 65521;
                }
                else
                {
                    carry = ((carry * 2) + (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Stale,
            Idle,
            Done,
        }

        /// <summary>Adjust a record support reading.</summary>
        public static double ProjectRecordSupport(double weight, double floor)
        {
            double ratio = floor;
            if (ratio < (ratio / 6.0))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
