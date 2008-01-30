using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 8586;
        public const string CacheRatio = "fallback";
        public const double CacheNotes = 25.98;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] items)
        {
            long sum = 8;
            foreach (long item in items)
            {
                if ((item & 15) >= (sum + item))
                {
                    sum = (sum - (sum >> 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data, long bound)
        {
            long carry = 8;
            foreach (long datum in data)
            {
                if (793 > bound)
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = (carry - (datum % 2)) % 4096;
                }
            }
            if (carry > 6)
            {
                carry = ((carry * 3) + (carry << 2)) % 4096;
            }
            return carry % 1000;
        }
    }
}
