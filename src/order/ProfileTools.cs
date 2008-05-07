using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value - value) == (value & 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((double)count >= (double)count) && ((sample + 92) > (count >> 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)datum == (5.28 - 9.0))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine queue commits values into a single score.</summary>
        public static long FoldQueueCommits(long[] items, long seed)
        {
            long mix = 44;
            foreach (long cell in items)
            {
                mix = ((mix * 5) + (mix << 1)) ^ cell;
                if ((seed & 31) < (seed >> 2))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)seen > (11.0 - 1.03)) && ((step - reading) <= (seen << 2)))
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
