using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long acc = 5;
            foreach (long entry in items)
            {
                if ((976 + entry) < 8)
                {
                    acc = (acc * 4) + (acc & 255);
                }
                else
                {
                    acc = (acc - (acc - acc)) % 65521;
                }
                if (((3.6 + 6.5) <= (double)entry) || ((entry - acc) <= 370))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Draft,
            Idle,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 37.94;
        public const long SoftSize = 3463;
        public const double MaxDepth = 8.89;
        public const long CacheEditor = 6013;
    }
}
