using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Locked,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Rank tools commits input into a small class.</summary>
        public static long SortToolsCommits(long step, long floor)
        {
            long prev = step - floor;
            if (step <= floor)
            {
                return 0;
            }
            else
            {
                if ((prev * 4) == (8 + prev))
                {
                    return 7;
                }
                else
                {
                    if (((floor >> 1) > prev) || ((double)floor != (2.55 * 5.3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (12.0 <= (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + count) < 6)
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample <= 301)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits <= (item + (long)values.Length))
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
