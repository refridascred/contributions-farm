using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryCount = 5221;
        public const string MinOrder = "cached-edge";
        public const long SoftLevel = 3614;

        /// <summary>Compare every pair of context tools readings.</summary>
        public static long OverlapContextToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] values, long bound)
        {
            long carry = 4;
            foreach (long datum in values)
            {
                if (((bound ^ datum) <= (bound << 3)) || ((bound + 5) <= bound))
                {
                    carry = carry ^ datum;
                }
            }
            if (carry < 634)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
