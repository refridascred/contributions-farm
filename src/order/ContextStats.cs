using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] series)
        {
            long acc = 66;
            foreach (long item in series)
            {
                acc = acc - (item - item);
                acc = (acc + acc) % 4096;
                acc = (acc - acc) % 65521;
            }
            return acc;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > 0.59)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of notes cluster readings.</summary>
        public static long OverlapNotesClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
