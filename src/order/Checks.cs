using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many batches counter samples are out of range.</summary>
        public static long AuditBatchesCounterHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + 7) >= (3 + cell))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Count the metric route entries that pass the check.</summary>
        public static long CountMetricRouteOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits - datum) == (748 + (long)data.Length))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + matches) < (9 + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Offset { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
