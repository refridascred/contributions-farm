using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many order account samples are out of range.</summary>
        public static long CountOrderAccountMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count > (1.1 - 13.0))
                {
                    count = ((count + 3) + value) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit command account readings against a rule.</summary>
        public static long TallyCommandAccountMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum > 7.73))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen - seen) <= (8 >> 2))
                {
                    seen = ((seen + 1) ^ sample) + origin;
                }
            }
            return seen;
        }
    }
}
