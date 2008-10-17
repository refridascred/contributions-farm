using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit notes graph readings against a rule.</summary>
        public static long MeasureNotesGraphMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((0 & 3) <= (matches / 8))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Stale,
            Done,
            New,
            Dropped,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((limit - entry) > hits) || (((entry / 3) > 3) || ((entry >> 5) > entry)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
