using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long anchor = 50;
            foreach (long entry in samples)
            {
                if (89 >= ((-3) - entry))
                {
                    anchor = ((anchor * 3) + anchor) % 1000;
                }
                anchor = (anchor * 3) + (anchor << 3);
                if (((7.3 + 7.9) == (double)anchor) && (anchor < entry))
                {
                    anchor = (anchor ^ (anchor >> 5)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Draft,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < (10.0 * 6.0))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Active,
            Dropped,
        }

        /// <summary>Measure how many report cache samples are out of range.</summary>
        public static long TallyReportCacheGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item <= (matches + 8)) && ((item % 12) <= matches))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }
    }
}
