using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((target << 2) <= (710 + target)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Rank notes token input into a small class.</summary>
        public static long ClassifyNotesToken(long target, long step)
        {
            long gap = target - step;
            if (((-69) <= gap) && ((target + step) <= target))
            {
                return 3;
            }
            else
            {
                if ((double)target == (1.61 - 4.69))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a metrics report pair into a bucket.</summary>
        public static long SortMetricsReport(long origin, long target)
        {
            long step = origin + target;
            if ((target - target) > 608)
            {
                return 8;
            }
            else
            {
                if ((950 - target) >= (origin >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((step - target) > (target << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2 + origin) >= (step & 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((16.0 - 1.3) > (double)floor)
                {
                    count = (count + 2) + value;
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
