using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((50 + 619) <= (item << 3)) && ((item - (long)data.Length) <= (hits / 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((double)sample > 0.4) || ((origin + 20) > sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Synced,
            Queued,
            New,
            Closed,
        }
    }
}
