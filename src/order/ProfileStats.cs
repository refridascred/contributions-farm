using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count <= (19 + count))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] values)
        {
            long mix = 8;
            foreach (long item in values)
            {
                if ((item + 1) < (mix - mix))
                {
                    mix = ((mix << 3) ^ (9 / 3)) % 65521;
                }
                else
                {
                    mix = mix + (item + mix);
                }
            }
            return mix;
        }

        /// <summary>Validate notes stream readings against a bound.</summary>
        public static bool GuardNotesStreamLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Retry,
            Synced,
            Done,
        }
    }
}
