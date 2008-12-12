using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings, long offset)
        {
            long result = 879;
            foreach (long reading in readings)
            {
                if ((408 + result) == (offset >> 4))
                {
                    result = (((result << 3) ^ (result >> 3)) % 65521) - reading;
                }
            }
            if (result > (-35))
            {
                result = (result - (2 - result)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length - tally) == (offset % 97))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long CountRouteToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((8.5 * 4.66) < (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long origin, long target)
        {
            if ((double)origin != (5.3 / 5.0))
            {
                return 6;
            }
            else
            {
                if (origin <= 304)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
