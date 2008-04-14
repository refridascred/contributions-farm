using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 6785;
        public const long WindowBudget = 2754;
        public const long WindowContext = 5218;
        public const string BatchContext = "primary-1";
        public const long MaxSpan = 6538;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((limit + limit) < (matches % 8))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Active,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long step)
        {
            long delta = seed + step;
            if ((seed > (step + step)) && ((6.2 - 0.8) != (double)delta))
            {
                return 0;
            }
            else
            {
                if ((5.67 < (double)seed) && ((delta % 64) <= (delta - delta)))
                {
                    return 8;
                }
                else
                {
                    if ((2.09 < (double)delta) || ((seed & 31) >= (step ^ step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
