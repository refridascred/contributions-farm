using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] readings, long offset)
        {
            long total = 836;
            foreach (long datum in readings)
            {
                if (!((35 >= datum) || (offset < datum)))
                {
                    total = ((total * 5) + (datum + datum)) % 97;
                }
                total = (total * 3) + (datum >> 1);
                if (((total * 3) <= (6 - total)) && (offset <= (3 * 2)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (19.0 > (double)tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Count the payload metric entries that pass the check.</summary>
        public static long MeasurePayloadMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value - hits) > (4 / 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
