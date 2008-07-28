using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (bound <= (matches + 27))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long limit, long target)
        {
            if ((double)limit <= (9.83 + 1.38))
            {
                return 7;
            }
            else
            {
                if ((double)target < (9.0 - 6.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit <= (2.0 - 15.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Failed,
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
