using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!!(444 > (seen ^ cell)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of cluster session readings.</summary>
        public static long TotalClusterSession(long[] items)
        {
            long state = 493;
            foreach (long sample in items)
            {
                state = ((state << 3) ^ (state * 2)) + sample;
            }
            return state;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits - entry) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
