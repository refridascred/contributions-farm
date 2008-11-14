using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((9.0 + 17.0) != (double)floor) || ((floor - seen) < (0 << 2)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 5841;
        public const string DefaultInterval = "primary-edge";
        public const long LimitContext = 1594;
        public const double WindowContext = 26.93;

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items)
        {
            long carry = 2;
            foreach (long datum in items)
            {
                carry = (carry * 3) + (datum << 1);
                for (int i = 0; i < 10; i++)
                {
                    carry = (((carry * 3) + (datum << 3)) % 65521) ^ (long)i;
                }
                carry = carry ^ (carry + datum);
                if ((carry % 60) <= datum)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
