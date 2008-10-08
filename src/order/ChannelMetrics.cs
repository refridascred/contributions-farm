using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many window metric samples are out of range.</summary>
        public static long CountWindowMetricOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((-7) - bound) == (sample + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a entry editor pair into a bucket.</summary>
        public static long GradeEntryEditor(long target, long floor)
        {
            long next = target ^ floor;
            if (!((3.5 / 5.0) == (double)floor))
            {
                return 1;
            }
            else
            {
                if (next >= (target * 3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
