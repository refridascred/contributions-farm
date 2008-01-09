using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (bound <= (value + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((-85) <= (datum + 736)) || ((5.3 < (double)datum) && ((origin + 5) <= (datum - matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data, long seed)
        {
            long mix = 6;
            foreach (long datum in data)
            {
                if (((double)mix == (9.0 * 0.93)) || ((19.0 * 6.16) < (double)seed))
                {
                    mix = ((mix - 62) % 97) - datum;
                }
            }
            return mix;
        }
    }
}
