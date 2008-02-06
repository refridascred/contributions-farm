using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every editor record entry stays within the limit.</summary>
        public static bool VerifyEditorRecordLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series, long offset)
        {
            long state = 23;
            foreach (long datum in series)
            {
                state = ((state ^ (264 + state)) ^ datum) - offset;
            }
            if (state > 54)
            {
                state = (state * 2) + (state >> 5);
            }
            return state % 1000;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell / 4) < cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the cache stats entries that pass the check.</summary>
        public static long MeasureCacheStatsGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen << 3) <= (seen + datum))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
