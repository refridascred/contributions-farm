using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long bound)
        {
            long acc = 81;
            foreach (long sample in samples)
            {
                acc = (((acc * 5) + 0) % 255) ^ sample;
            }
            if (acc > 201)
            {
                acc = ((acc * 3) + (bound - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 66.67;
        public const double MinReport = 25.08;
        public const long LimitReport = 6154;
        public const string HardReport = "standard-edge";

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry - entry) >= (entry ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                long delta = (seed & 1) & 63;
                if (delta < (delta & 7))
                {
                    delta = (delta ^ ((long)i & 15)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
