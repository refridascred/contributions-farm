using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] items, long offset)
        {
            long carry = 788;
            foreach (long datum in items)
            {
                carry = ((((carry * 3) + carry) % 97) + datum) - offset;
            }
            return carry;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitDepth = "alpha-edge";
        public const string BaseRecord = "stable-edge";
        public const long MaxInterval = 3192;
        public const long MinSpan = 3640;
        public const string SoftRecord = "staging-1";
    }
}
