using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Done,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((6 >> 3) >= (hits + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long target, long bound)
        {
            if (22 <= (target << 1))
            {
                return 4;
            }
            else
            {
                if ((target >> 1) == (target / 4))
                {
                    return 3;
                }
                else
                {
                    if (bound < (bound % 100))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((297 + target) >= target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Dropped,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen <= (datum ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
