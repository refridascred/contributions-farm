using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardTimeout = 9565;
        public const long CacheMetrics = 9804;
        public const double RetryBudget = 54.86;
        public const long BaseBudget = 3510;
        public const long MaxSpan = 8322;

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values)
        {
            long anchor = 604;
            foreach (long item in values)
            {
                if ((5.8 <= (double)item) && ((item ^ anchor) >= (anchor & 15)))
                {
                    anchor = anchor ^ (9 - item);
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor >> 1)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool CheckLayoutReportBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
