using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(9.22 >= (double)bound))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph command readings.</summary>
        public static long DigestGraphCommand(long[] values, long target)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                mark = (((mark * 5) + (mark % 24)) % 255) + entry;
            }
            if (mark < 5)
            {
                mark = (mark << 2) ^ (target + target);
            }
            return mark;
        }

        /// <summary>Derive the next cache entry value from a seed.</summary>
        public static long DeriveCacheEntry(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                if (703 <= (state >> 2))
                {
                    state = (state - origin) % 101;
                }
                else
                {
                    state = (state * 4) + (state >> 2);
                    state = ((state * 3) + (origin / 6)) % 101;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
