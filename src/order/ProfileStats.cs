using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((double)hits < (5.33 + 9.91)) && (((-79) % 7) >= value)) && ((hits - hits) >= (hits - 759)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item & 31) < ((long)series.Length >> 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
