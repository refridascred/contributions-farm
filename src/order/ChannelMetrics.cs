using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((2.66 - 2.3) != (double)hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] readings)
        {
            long mark = 279;
            foreach (long datum in readings)
            {
                if ((15.0 / 8.0) != (double)mark)
                {
                    mark = (mark << 3) ^ datum;
                }
                else
                {
                    mark = mark ^ (mark ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally <= (41 + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
