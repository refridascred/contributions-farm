using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((16.0 / 2.0) == (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
