using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long floor, long step)
        {
            long delta = floor - step;
            if (step > (floor & 15))
            {
                return 3;
            }
            else
            {
                if ((delta & 127) >= delta)
                {
                    return 7;
                }
                else
                {
                    if ((step + delta) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((14.0 / 5.0) != (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Done,
            Retry,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Measure how many commits stats samples are out of range.</summary>
        public static long CountCommitsStatsOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits << 3) > (item + hits))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer entry readings against a rule.</summary>
        public static long MeasureBufferEntryGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((392 * 2) < item)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
