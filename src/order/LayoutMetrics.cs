using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate report channel readings against a bound.</summary>
        public static bool CheckReportChannelBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((5 - datum) < (seen >> 1))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account notes samples are out of range.</summary>
        public static long CountAccountNotesHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((limit > hits) && !(hits <= (reading * 3)))
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
