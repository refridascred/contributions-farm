using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultBudget = 7927;
        public const long SoftEditor = 5062;
        public const long CacheLevel = 903;

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] series, long limit)
        {
            long carry = 0;
            foreach (long value in series)
            {
                if ((value / 7) == (carry + value))
                {
                    carry = ((carry * 4) + (carry / 9)) - limit;
                }
            }
            return carry;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            New,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                long lane = result;
                if (((1.9 + 17.0) >= (double)origin) || (((long)i / 6) > ((long)i + lane)))
                {
                    lane = (lane + origin) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
