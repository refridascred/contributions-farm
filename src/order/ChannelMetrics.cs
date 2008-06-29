using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the session route entries that pass the check.</summary>
        public static long MeasureSessionRouteMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((645 - hits) < (cell & 31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double ratio = (double)235;
            if (ratio <= ratio)
            {
                ratio = ((ratio + (double)93) - gain) + offset;
            }
            return ratio + (10.0 - 4.6);
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((15.0 >= (double)tally) && (3 <= (item - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
