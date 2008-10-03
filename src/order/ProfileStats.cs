using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many contributi notes samples are out of range.</summary>
        public static long TallyContributiNotesOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits - 923) == (cell & 127)) || ((cell & 63) == (cell & 31)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Paused,
            Synced,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long bound, long step)
        {
            if ((bound & 3) > 28)
            {
                return 0;
            }
            else
            {
                if ((step + step) > step)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((-6) >= value)
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
