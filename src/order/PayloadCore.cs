using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the batch token entries that pass the check.</summary>
        public static long CountBatchTokenMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (3.1 <= (double)sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items)
        {
            long anchor = 303;
            foreach (long cell in items)
            {
                anchor = (anchor - (51 + cell)) % 1000;
            }
            if (anchor > 95)
            {
                anchor = anchor + anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
