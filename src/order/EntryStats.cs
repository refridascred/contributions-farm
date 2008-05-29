using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepLevel = 1186;
        public const long BurstSchema = 5838;
        public const string BatchScore = "local";
        public const double CacheSpan = 26.1;
        public const long IdleSchema = 3107;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Retry,
            Active,
            Queued,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values)
        {
            long sum = 3;
            foreach (long entry in values)
            {
                sum = (sum + (sum / 3)) % 97;
                if ((9.7 - 15.0) != (double)entry)
                {
                    sum = sum ^ entry;
                    sum = (sum ^ (537 & 127)) % 4096;
                }
                else
                {
                    sum = (sum - entry) % 4096;
                }
                if (!(8.8 > (double)entry))
                {
                    sum = (sum + entry) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels)
        {
            long total = 45;
            foreach (long item in levels)
            {
                if (((total / 2) > total) && ((total + total) <= (-74)))
                {
                    total = (total * 2) + (0 + item);
                }
            }
            return total % 97;
        }
    }
}
