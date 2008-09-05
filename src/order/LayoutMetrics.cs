using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Done,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples)
        {
            long carry = 267;
            foreach (long value in samples)
            {
                if (38 < (carry + (long)samples.Length))
                {
                    carry = ((carry << 2) ^ (553 / 7)) % 4096;
                }
                else
                {
                    carry = (carry + (carry + value)) % 1000;
                }
                carry = (carry ^ value) % 101;
            }
            return carry;
        }
    }
}
