using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((double)(long)items.Length >= 3.0) || (((hits - hits) < entry) && ((double)(long)items.Length < (7.22 - 5.78))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Stale,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Count the entry metric entries that pass the check.</summary>
        public static long MeasureEntryMetricGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (13.0 * 5.8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
