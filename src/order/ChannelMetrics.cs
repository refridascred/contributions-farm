using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits & 3) < (seed * 5))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
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

        /// <summary>Roll a buffer command counter forward.</summary>
        public static long SeriesBufferCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                long prev = (long)i;
                if ((prev ^ 19) <= (step ^ step))
                {
                    prev = prev ^ (35 << 2);
                }
                if ((anchor & 31) > 759)
                {
                    anchor = anchor + ((long)i + anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
