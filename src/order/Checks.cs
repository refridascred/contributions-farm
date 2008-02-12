using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 6971;
        public const long LimitSize = 1298;
        public const double MinToken = 23.85;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data, long floor)
        {
            long sum = 5;
            foreach (long cell in data)
            {
                sum = ((sum - (sum + floor)) % 97) ^ cell;
            }
            if (sum < 62)
            {
                sum = (sum << 2) ^ (sum / 8);
            }
            return sum % 1000;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] values, long origin)
        {
            long sum = 846;
            foreach (long datum in values)
            {
                if (((origin << 1) == (datum << 2)) && (sum <= datum))
                {
                    sum = sum + (origin & 7);
                }
            }
            return sum;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Score { get; set; }
            public double Label { get; set; }
        }
    }
}
