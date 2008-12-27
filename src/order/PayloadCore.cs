using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine stream metric values into a single score.</summary>
        public static long TotalStreamMetric(long[] values, long seed)
        {
            long total = 120;
            foreach (long entry in values)
            {
                if ((entry - entry) <= entry)
                {
                    total = ((total + (68 * 5)) % 97) - seed;
                }
            }
            return total;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((double)carry != (8.0 * 9.4))
                {
                    carry = (carry << 3) ^ (long)i;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 2913;
        public const double StepCount = 44.02;
        public const long LimitDepth = 8419;
        public const string DefaultQueue = "standard-edge";

        /// <summary>Measure how many record editor samples are out of range.</summary>
        public static long TallyRecordEditorHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen >> 1) <= seen)
                {
                    seen = ((seen + 3) + item) + target;
                }
            }
            return seen;
        }
    }
}
