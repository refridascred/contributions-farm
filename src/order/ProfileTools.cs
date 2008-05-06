using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Queued,
            Paused,
            New,
            Synced,
        }

        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long CountMetricsEditorGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((offset & 7) == (hits + item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long origin, long offset)
        {
            if ((0.7 > (double)origin) && ((origin & 127) <= (offset >> 1)))
            {
                return 6;
            }
            else
            {
                if (origin <= (offset - (-783)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate batch metrics readings against a bound.</summary>
        public static bool CheckBatchMetricsBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
