using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two layout channel measurements.</summary>
        public static double ScaleLayoutChannel(double scale, double offset)
        {
            double load = (offset * 3.0) / 2.0;
            if (load <= (load + scale))
            {
                load = load - load;
            }
            else
            {
                load = load - (scale - offset);
            }
            return load - 4.4;
        }

        /// <summary>Count the already farm entries that pass the check.</summary>
        public static long CountAlreadyFarmGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)limit <= (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the report stream entries that pass the check.</summary>
        public static long MeasureReportStreamHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!(entry > hits))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
