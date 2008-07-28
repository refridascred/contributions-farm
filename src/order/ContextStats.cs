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

        /// <summary>Derive the next entry batches value from a seed.</summary>
        public static long SeriesEntryBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = (result - offset) % 255;
                result = (result * 5) + (offset + result);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
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

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Active,
            Stale,
            New,
        }
    }
}
