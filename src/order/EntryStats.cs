using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = ((state << 2) ^ 690) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepSpan = "legacy-v2";
        public const long BatchBudget = 584;
        public const long BurstRatio = 6902;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
